using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace app_04
{
    class AppService : BackgroundService
    {
        private IConfiguration ConfService { get; init; }
        private IMessageProvider MsgService { get; init; }

        public AppService(IConfiguration conf, IMessageProvider msg) 
            => (ConfService, MsgService) = (conf, msg);

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested) {
                Console.WriteLine(MsgService.NextMessage);
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