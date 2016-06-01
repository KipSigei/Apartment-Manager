using FirstFloor.ModernUI.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUINavigationApp1
{
    class FormViewModel : NotifyPropertyChanged, IDataErrorInfo
    {

        private string firstName = "Kip";
        private string lastName;
        private string idNo;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (this.lastName != value)
                {
                    this.lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string IdNo
        {
            get { return this.idNo; }
            set
            {
                if (this.idNo != value)
                {
                    this.idNo = value;
                    OnPropertyChanged("IdNo");
                }
            }
        }


        public string this[string columnName]
        {
            get
            {
                if (columnName == "FirstName")
                {
                    return string.IsNullOrEmpty(this.firstName) ? "Required value" : null;
                }
                if (columnName == "LastName")
                {
                    return string.IsNullOrEmpty(this.lastName) ? "Required value" : null;
                }

                if (columnName == "IdNo")
                {
                    return string.IsNullOrEmpty(this.idNo) ? "Required value" : null;
                }


                return null;
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }
    }
}
