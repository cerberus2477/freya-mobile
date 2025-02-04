using System.Text;

namespace FreyaMobile.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtPassword.Text;
        if (userName == null || password == null)
        {
            DisplayAlert("Hiba", "Hiányzó felhasználónév vagy jelszó", "OK");
            return;
        }


        //chatgpt mondta, idk, levi a login rad lesz bizva xd



        //var client = new HttpClient();
        //var url = ApiBaseUrl + "login";  // Your login route

        //var loginData = new
        //{
        //    email = userName,
        //    password = password
        //};

        //var jsonContent = JsonConvert.SerializeObject(loginData);
        //var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        //try
        //{
        //    var response = await client.PostAsync(url, content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var result = await response.Content.ReadAsStringAsync();
        //        // You can handle the success response here
        //        // For example, store the token
        //        await DisplayAlert("Success", "Logged in successfully!", "OK");
        //        // Save the token securely (using SecureStorage in Maui)
        //        await SecureStorage.SetAsync("user_token", result.token);  // assuming the token is in the response body
        //    }
        //    else
        //    {
        //        // Handle error response here (invalid credentials, etc.)
        //        var errorResponse = await response.Content.ReadAsStringAsync();
        //        await DisplayAlert("Error", "Login failed: " + errorResponse, "OK");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    await DisplayAlert("Error", "An error occurred: " + ex.Message, "OK");
        //}
    //}

}
}