using System.Threading.Tasks;
using Avalonia.Controls;
using MyApp.Interface;
using MyApp.Models;
using MyApp.ViewModels;

namespace MyApp
{
    public partial class MainWindow : Window, IShowDialog
    {

        public MainWindow()
        {
            InitializeComponent();
            // AppManager.MainWindow = this;
            var vm = new MvMain(this);
            vm.InfoMainPage = "home page";
            this.DataContext = vm;
        }


        public async Task DoShowDialogAsync()
        {
            var dialog = new ListPageWindow();
            AppManager.ListPageDialog = dialog;
            // hint_open_new_page
            var result = await dialog.ShowDialog<MvListPage>(this);
        }
    }
}