using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAsyncProccessConsoleApp
{
    public class AsyncProccess
    {
        public async Task ProcessDataAsync()
        {
            Console.WriteLine("Fetching data from API asynchronously...");
            var data = await FetchDataFromApiAsync();  // Memanggil API secara async
            Console.WriteLine("Processing data asynchronously...");
            await ProcessDataAsync(data);  // Memproses data setelah API selesai
            Console.WriteLine("Data processed!");
        }

        public async Task<string> FetchDataFromApiAsync()
        {
            // Simulasi permintaan API async (non-blocking)
            await Task.Delay(3000);  // Menunggu 3 detik secara async
            return "Data from API";
        }

        public async Task ProcessDataAsync(string data)
        {
            // Simulasi proses data async (non-blocking)
            await Task.Delay(2000);  // Menunggu 2 detik secara async
            Console.WriteLine($"Processed asynchronously: {data}");
        }

    }
}
