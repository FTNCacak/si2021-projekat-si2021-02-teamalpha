using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using Shared.Interfaces;
using Business_Layer;
using Data_Layer;

namespace Web_Presentation_Layer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            container.RegisterType<IUserBusiness, UserBusiness>();
            container.RegisterType<IUserRepository, UserRepository>();

            container.RegisterType<IApartmentBusiness, ApartmentBusiness>();
            container.RegisterType<IApartmentRepository, ApartmentRepository>();

            container.RegisterType<IRentRepository, RentRepository>();
            container.RegisterType<IRentBusiness, RentBusiness>();           
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}