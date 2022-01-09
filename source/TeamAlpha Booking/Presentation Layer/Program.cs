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
                var r = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(r);
            }


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IRentRepository, RentRepository>();
            services.AddSingleton<IApartmentRepository, ApartmentRepository>();

            services.AddSingleton<IUserBusiness, UserBusiness>();

            services.AddSingleton<MainForm>();
            services.AddSingleton<Registration>();

            


           /* services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemBusiness, ItemBusiness>();
            services.AddScoped<Magacin>(); */
        }
    }
}
