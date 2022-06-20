using Microsoft.Extensions.Configuration;

namespace app_04
{
    public class IncMessageService : IMessageProvider
    {
        private int inc = 0;
        private string Prefix { get; init; } 
        public IncMessageService(IConfiguration conf)
            => Prefix = conf.GetValue("options:msg", "ok");
        
        public string NextMessage => $"{Prefix} ({++inc})";
    }
}