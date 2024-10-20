using SyncAsyncProccessConsoleApp;
using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        await RunProccess.RunSelectedProccess(1);
    }
}