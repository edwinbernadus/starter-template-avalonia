using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;

namespace MyApp.ViewModels;

public class ListPageDetailViewModel
{
    public ListPageDetailViewModel(ListPageViewModel listPageViewModel)
    {
        this.Parent = listPageViewModel;
        OnInfoClickCommand = ReactiveCommand.Create(ShowOnParent);
    }

    public ICommand OnInfoClickCommand { get; set; }

    public ListPageViewModel Parent { get; set; }

    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }

    public async Task ShowOnParent()
    {
        // hint_show_detail_item_on_alert
        this.Parent.DisplayInfoAlert = $"{id}-{title}";
    }
}