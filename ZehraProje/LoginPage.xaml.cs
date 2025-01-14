using Microsoft.Maui.Controls;
using ZehraProje;
namespace ZehraProje;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Hata", "L�tfen t�m alanlar? doldurun.", "Tamam");
            return;
        }

        await DisplayAlert("Ba�ar�l�", "Giri� Ba�ar�l�!", "Tamam");
        await Navigation.PushAsync(new HomePage());
    }

    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}