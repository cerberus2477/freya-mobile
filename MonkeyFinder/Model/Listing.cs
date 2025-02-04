using System.Text.Json.Serialization;

namespace FreyaMobile.Model;

public class Listing
{
    //userid, city, title, plant(ID), descr, media, sell(bool)
    public string Title { get; set; }
    public string Description { get; set; }
    public string UserName { get; set; }
    public string PlantName { get; set; }
}

[JsonSerializable(typeof(List<Listing>))]
internal sealed partial class ListingContext : JsonSerializerContext
{
   

}