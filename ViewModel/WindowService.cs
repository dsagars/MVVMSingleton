using System.Windows;

namespace MVVMTestWithAsingleCompany.ViewModel
{
    public class WindowService : IWindowService
    {
        public void ShowWindow<T>(object viewModel) where T : Window, new()
        {
            T view = new T();
            view.DataContext = viewModel;
            view.Show();
        }
    }
}