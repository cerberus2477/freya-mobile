using System;
using FreyaMobile.Services;

namespace FreyaMobile.ViewModel;

public partial class ListingsViewModel : BaseViewModel
{
    public ObservableCollection<Listing> Listings { get; } = new();
    ListingService listingService;
    public ListingsViewModel(ListingService listingService)
    {
        Title = "Hirdetések";
        this.listingService = listingService;
    }

    [RelayCommand] //exposeoljuk a metódust egy ICommandon keresztül (community toolkit shortcuttal egy csak egy relaycommand attribute)
    async Task GetListingsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            var listings = await listingService.GetListings();
            if (Listings.Count != 0)
                Listings.Clear();

            foreach (var listing in listings)
                listings.Add(listing);
        }
        //nem olyan szép, mert nem a viewből piszkáljuk a viewt (error popup) (i might be wrong tho)
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get listings: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");

        }
        finally
        {
            IsBusy = false;
        }

    }
}
