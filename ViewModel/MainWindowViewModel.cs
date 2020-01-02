using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMTestWithAsingleCompany.Model;
using MVVMTestWithAsingleCompany.View;
namespace MVVMTestWithAsingleCompany.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Company myCompany;
        public Company MyCompany
        {
            get { return myCompany; }
            set
            {
                if (myCompany != value)
                    myCompany = value;
                OnPropertyChanged("MyCompany");
            }
        }
       public ICommand DoubleClickCommand { get; private set; }
      

        public MainWindowViewModel()
        {
            Companies = new ObservableCollection<Company>();
            Companies.Add(new Company() { Id = 1, CompanyName = "erm" });
            Companies.Add(new Company() { Id = 2, CompanyName = "haha" });
            Companies.Add(new Company() { Id = 3, CompanyName = "asads" });
            DoubleClickCommand = new Command(executeMethod, canExecuteMethod);
            
        }

        private bool canExecuteMethod(object arg)
        {
            return true;
        }

        private void executeMethod(object obj)
        {
            WindowService ws = new WindowService();
            MainWindowViewModel dataViewModel = new MainWindowViewModel();
            ws.ShowWindow<AddEdit>(dataViewModel);
        }   
        
    }
}
