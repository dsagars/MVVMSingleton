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
        private CompanyModel myCompany;
        private static ObservableCollection<CompanyModel> _companies;
        public static ObservableCollection<CompanyModel> Companies
        {
            get { return _companies; }
            set
            {
                if (_companies != value)
                    _companies = value;  
            }
        }
        public CompanyModel MyCompany
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
       public ICommand AddCommand { get; private set; }

        public MainWindowViewModel()
        {
            Companies = new ObservableCollection<CompanyModel>();
            Companies.Add(new CompanyModel() { Id = 1, CompanyName = "erm" });
            Companies.Add(new CompanyModel() { Id = 2, CompanyName = "haha" });
            Companies.Add(new CompanyModel() { Id = 3, CompanyName = "asads" });
            DoubleClickCommand = new Command(executeDoubleClick, canExecuteDoubleClick);
            AddCommand = new Command(executeAddButton, canExecuteAddButton);           
        }

        private bool canExecuteAddButton(object arg)
        {
            return true;
        }

        private void executeAddButton(object obj)
        {
            WindowService ws = new WindowService();
            MainWindowViewModel dataViewModel = new MainWindowViewModel();
            ws.ShowWindow<AddEdit>(dataViewModel);
        }

        private bool canExecuteDoubleClick(object arg)
        {
            return true;
        }

        private void executeDoubleClick(object obj)
        {
            WindowService ws = new WindowService();
            MainWindowViewModel dataViewModel = new MainWindowViewModel();
            ws.ShowWindow<AddEdit>(dataViewModel);
        }   
        
    }
}
