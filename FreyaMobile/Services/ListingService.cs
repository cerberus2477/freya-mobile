using System.Net.Http.Json;

namespace FreyaMobile.Services;

public class ListingService
{
    List<Listing> listings = new();

    HttpClient httpClient;
    public ListingService()
    {
        this.httpClient = new HttpClient();
    }

    public async Task<List<Listing>> GetListings()
    {
        if (listings?.Count > 0) return listings;

        //We can use the HttpClient to make a web request and parse it using the built in System.Text.Json deserialization.
        var response = await httpClient.GetAsync("/listings");

        if (response.IsSuccessStatusCode)
        {
            listings = await response.Content.ReadFromJsonAsync(ListingContext.Default.ListListing);
        }

        return listings;
    }
}
