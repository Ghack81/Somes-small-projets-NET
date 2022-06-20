using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace app_04
{
    class AppService : BackgroundService
    {
        public string Message { get; init; }

        public AppService(string msg) => Message = msg;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested) {
                Console.WriteLine(Message);
                try {
                    await Task.Delay(500);
                }
                catch(OperationCanceledException) {
                    break;
                }
            }
        }
    }
}