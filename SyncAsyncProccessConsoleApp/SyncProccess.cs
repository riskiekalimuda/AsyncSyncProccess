using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAsyncProccessConsoleApp
{
    public class SyncProccess
    {
        public static void ProcessDataSync()
        {
            Console.WriteLine("Fetching data from API...");
            var data = FetchDataFromApi();  // Memanggil API secara sinkron
            Console.WriteLine("Processing data...");
            ProcessData(data);  // Memproses data setelah API selesai
            Console.WriteLine("Data processed!");
        }

        public static string FetchDataFromApi()
        {
            // Simulasi permintaan API yang memakan waktu (blocking)
            Thread.Sleep(3000);  // Menunggu 3 detik
            return "Data from API";
        }

        public static void ProcessData(string data)
        {
            // Simulasi proses data
            Thread.Sleep(2000);  // Menunggu 2 detik
            Console.WriteLine($"Processed: {data}");
        }

    }
}
