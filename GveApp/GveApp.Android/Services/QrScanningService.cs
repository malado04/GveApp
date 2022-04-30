using System;
using ZXing.Mobile;
using System.Threading.Tasks;
using Xamarin.Forms;
using GveApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(GveApp.Droid.Services.QrScanningService))]

namespace GveApp.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public Task<Image> CreateAsnyc()
        {
            throw new NotImplementedException();
        }

        public async Task<string> ScanAsync()
        {
            var OptionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scanner code QR",
                BottomText = "Patientez svp...",
            };

            var scanResult = await scanner.Scan(OptionsDefault);
            return scanResult.Text;
        }
    }
}