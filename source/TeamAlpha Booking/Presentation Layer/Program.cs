using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces;
using Data_Layer;
using Web_Presentation_Layer;
using Business_Layer;

namespace Presentation_Layer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form);
            }


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRentRepository, RentRepository>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IRentBusiness, RentBusiness>();
            services.AddScoped<IApartmentBusiness, ApartmentBusiness>();

            services.AddScoped<UserControls.Rents>();
            services.AddScoped<UserControls.Overview>();
            services.AddScoped<MainForm>();

        }
    }
}
