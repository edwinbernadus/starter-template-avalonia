using System.Threading.Tasks;
using System.Windows.Input;
using MyApp.Navigator;
using ReactiveUI;

namespace MyApp.ViewModels
{
    public class StartPageViewModel : PageViewModelBase
    {
        public StartPageViewModel()
        {
            var vm = this;
            vm.InfoMainPage = "home page";
            OnClickCommand = ReactiveCommand.Create(NavigateOnClickCommand);
        }

        private void NavigateOnClickCommand()
        {
            // hint_open_new_page
            var vm = MainWindowViewModel.CurrentContext;
            vm.NavigateNext();
        }

        public string InfoMainPage { get; set; } = "";
    
        public ICommand OnClickCommand { get; }
        
        public override bool CanNavigateNext { get; protected set; } = true;
        public override bool CanNavigatePrevious { get; protected set; }
    }
}