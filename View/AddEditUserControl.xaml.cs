using System;
using System.Collections.Generic;
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
using MVVMTestWithAsingleCompany.ViewModel;


namespace MVVMTestWithAsingleCompany.View
{
    /// <summary>
    /// Interaction logic for AddEditUserControl.xaml
    /// </summary>
    public partial class AddEditUserControl : UserControl
    {
        
        public AddEditUserControl()
        {
            DataContext = new AddEditViewModel();
            InitializeComponent();
            
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditViewModel addViewmodel = new AddEditViewModel(int.Parse(idTextBox.Text), nameTxtBox.Text);
            MessageBox.Show("It hits");
            DataContext = addViewmodel;
        }

       
    }
}
