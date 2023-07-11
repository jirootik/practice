using Microsoft.Extensions.Hosting;
using System;


namespace DiascanPraktika
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public IHostBuilder CreateHostBuilder(string[] args, App app)
        {
            return Host.
            CreateDefaultBuilder(args)
            .ConfigureServices(app.ConfigureServices);
        }
    }


}
