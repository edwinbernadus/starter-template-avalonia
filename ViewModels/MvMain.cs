using System.Threading.Tasks;
using Avalonia.Controls;
using MyApp.Interface;

namespace MyApp.ViewModels
{
    public class MvMain
    {
        private readonly IShowDialog _showDialog;

        public string InfoMainPage { get; set; } = "";
        // public Window Dialog { get; set; }

        public MvMain(IShowDialog showDialog)
        {
            _showDialog = showDialog;
        }

        public async Task OnClickCommand()
        {
            await _showDialog.DoShowDialogAsync();
        }
    }
}