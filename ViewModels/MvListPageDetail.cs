using System.Threading.Tasks;

namespace MyApp.ViewModels;

public class MvListPageDetail
{
    public MvListPageDetail(MvListPage mvListPage)
    {
        this.Parent = mvListPage;
    }

    public MvListPage Parent { get; set; }

    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }

    public async Task OnInfoClickCommand()
    {
        // hint_show_detail_item_on_alert
        this.Parent.DisplayInfoAlert = $"{id}-{title}";
    }
}