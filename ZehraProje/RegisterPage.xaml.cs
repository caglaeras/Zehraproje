using Microsoft.Maui.Controls;
using System;

namespace ZehraProje
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {

            string username = UsernameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;
            DateTime birthDate = BirthDatePicker.Date;


            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                await DisplayAlert("Hata", "Tüm alanlarý doldurun.", "Tamam");
                return;
            }

            if (password != confirmPassword)
            {
                await DisplayAlert("Hata", "Þifreler Eþleþmiyor.", "Tamam");
                return;
            }

            if (!email.Contains("@"))
            {
                await DisplayAlert("Hata", "Geçerli bir e-posta adresi girin.", "Tamam");
                return;
            }

            if (birthDate > DateTime.Today)
            {
                await DisplayAlert("Hata", "Do?um tarihi bugünden ileri bir tarih olamaz.", "Tamam");
                return;
            }


            await DisplayAlert("Ba?ar?l?", $"Kay?t tamamland?.\nKullan?c? Ad?: {username}\nE-posta: {email}\nDo?um Tarihi: {birthDate:dd/MM/yyyy}", "Tamam");


            await Navigation.PopAsync();
        }
    }
}