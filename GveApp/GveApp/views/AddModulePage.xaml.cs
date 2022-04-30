using GveApp.Services;
using System;
using Xamarin.Forms;

namespace GveApp.views
{

    public partial class AddModulePage : ContentPage
    {
        public AddModulePage()
        {
            InitializeComponent();
            ScannerAsnyc();
        }
        public async void ScannerAsnyc()
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                string result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.TextColor = Color.Gray;
                    txtBarcode.FontSize = 20;
                    txtBarcode.Text = result;
                    btn_scanner.IsEnabled = false;
                    txtBarcode.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                txtBarcode.Text = "Mauvais QR Code !";
                txtBarcode.TextColor = Color.Red;
                txtBarcode.FontSize = 20;
                Console.WriteLine(ex.Message);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ScannerAsnyc();
        }
    }
}