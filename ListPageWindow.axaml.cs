using System.Threading.Tasks;
using Avalonia.Controls;
using MyApp.Interface;
using MyApp.Models;
using MyApp.ViewModels;

namespace MyApp
{
    public partial class ListPageWindow : Window, IGoBack
    {
        public ListPageWindow()
        {
            InitializeComponent();
            var vm = new MvListPage(this);
            vm.InfoListPage = "list page";
            this.DataContext = vm;
            vm.GetContentFromWeb();
        }

        public async Task DoGoBack()
        {
            var dialog = AppManager.ListPageDialog;
            dialog.Close();

        }
    }
}