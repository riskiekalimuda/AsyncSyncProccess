using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAsyncProccessConsoleApp
{
    public class RunProccess
    {
        public static async Task RunAsyncronous()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AsyncProccess asyncProccess = new AsyncProccess();
            await asyncProccess.ProcessDataAsync();
            stopwatch.Stop();
            Console.WriteLine($"Asyncronous Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void RunSyncronous()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SyncProccess.ProcessDataSync();
            stopwatch.Stop();
            Console.WriteLine($"Syncronous Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static async Task RunSelectedProccess(int selectedProccess)
        {
            if (selectedProccess == 0)
                RunSyncronous();
            else
                await RunAsyncronous();
        }
    }
}
