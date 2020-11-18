using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CRM.Web
{
    public class AutoFacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            Assembly controllerAss = Assembly.Load("CRM.Web");
            builder.RegisterControllers(controllerAss);

            Assembly respAss = Assembly.Load("CRM.Repository"); //CRM.Repository
            builder.RegisterTypes(respAss.GetTypes()).AsImplementedInterfaces();

            Assembly serviceAss = Assembly.Load("CRM.Services");//CRM.Services
            builder.RegisterTypes(serviceAss.GetTypes()).AsImplementedInterfaces();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}