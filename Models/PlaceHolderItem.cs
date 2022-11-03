using System.Threading.Tasks;

namespace MyApp.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

public class PlaceHolderItem
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
}