using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GveApp.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
        Task<Image> CreateAsnyc();
    }
}
