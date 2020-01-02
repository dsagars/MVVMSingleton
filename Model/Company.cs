using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTestWithAsingleCompany.Model
{
    public class Company : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        private string company;
        
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                    id = value;
                OnPropertyChanged("Id");
            }
        }
        public string CompanyName
        {
            get { return company; }
            set
            {
                if(company != value)
                {
                    company = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
           if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
