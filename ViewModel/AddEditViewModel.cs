using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MVVMTestWithAsingleCompany.Model;
using System.Windows.Input;
using MVVMTestWithAsingleCompany.View;

namespace MVVMTestWithAsingleCompany.ViewModel
{
    public class AddEditViewModel : ViewModelBase
    {
        private int idTextBox;
        private string nameTxtBox;

        public int IdTxtbox
        {
            get { return idTextBox; }
            set
            {
                if (idTextBox != value)
                    idTextBox = value;
                OnPropertyChanged("IdTxtBox");
            }
        }
        public string NameTextBox
        {
            get { return nameTxtBox; }
            set
            {
                if(nameTxtBox != value)
                {
                    nameTxtBox = value;
                    OnPropertyChanged("NameTextbox");
                }
            }
        }

        public ICommand SaveCommand { get; private set; }

        public AddEditViewModel()
        {
            
           // SaveCommand = new Command(executeSave, canExecuteSave);
        }
        public AddEditViewModel(int id, string companyName)
        {
            this.idTextBox = id;
            this.NameTextBox = companyName;
            SaveCommand = new Command(executeSave, canExecuteSave);
        }
        private bool canExecuteSave(object arg)
        {
            return true;
        }

        private void executeSave(object obj)
        {
            CompanyModel company = new CompanyModel();
            company.Id = idTextBox;
            company.CompanyName = nameTxtBox;
            MainWindowViewModel.Companies.Add(company);
        }
    }
}
