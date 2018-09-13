using Microsoft.AspNetCore.Hosting;

namespace sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://0.0.0.0:80")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
