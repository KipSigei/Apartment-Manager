using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUINavigationApp1.Pages
{

    public enum OrderStatus { Paid , NotPaid};
    public class Tenant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdPass { get; set; }
        public string HouseNo { get; set; }
        public string Email { get; set; }
        public OrderStatus Status { get; set; }
    }
    /// <summary>
    /// Interaction logic for alltenants.xaml
    /// </summary>
    public partial class alltenants : UserControl
    {
        public alltenants()
        {
            InitializeComponent();

            ObservableCollection<Tenant> custdata = GetData();

            DG1.DataContext = custdata;
        }

        private ObservableCollection<Tenant> GetData()
        {
            var tenants = new ObservableCollection<Tenant>();
            tenants.Add(new Tenant { FirstName = "Orlando", LastName = "Chepkoech", IdPass="27656787", HouseNo= "A-100", Email = "orlando0@gmail.com",  Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Keith", LastName = "Wanjiku", IdPass = "25654673", HouseNo = "B-103", Email = "keith0@yahoo.com", Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Donna", LastName = "Akinyi", IdPass = "225436453", HouseNo = "A-234", Email = "donna0@gmail.com", Status = OrderStatus.NotPaid });
            tenants.Add(new Tenant { FirstName = "Janet", LastName = "Wanjala", IdPass = "20976873", HouseNo = "B-008", Email = "janet0@gmail.com",  Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Lucy", LastName = "Shiku", IdPass = "14567839", HouseNo = "A-110", Email = "lucy0@gmail.com", Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Rosmarie", LastName = "Mwikali", IdPass = "19867567", HouseNo = "B-136", Email = "rosmarie0@hotmail.com", Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Dominic", LastName = "Bet", IdPass = "26563789", HouseNo = "A-189", Email = "dominic0@yahoo.co.uk", Status = OrderStatus.NotPaid });
            tenants.Add(new Tenant { FirstName = "Kathleen", LastName = "Kimani", IdPass = "209876376", HouseNo = "A-160", Email = "kathleen0@gmail.com", Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Katherine", LastName = "Koech", IdPass = "37667899", HouseNo = "B-090", Email = "katherine0@yahoo.com", Status = OrderStatus.Paid });
            tenants.Add(new Tenant { FirstName = "Johnny", LastName = "Bravo", IdPass = "25556736", HouseNo = "A-230", Email = "johnny0@gmail.com", Status = OrderStatus.Paid });

            return tenants;
        }
    }
}
