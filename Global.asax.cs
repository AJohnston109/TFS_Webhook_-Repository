using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Windows;
using System.Windows.Media;
using System.Net;
using System.IO;
using Fluent.Infrastructure.FluentModel;

namespace WebHook
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public partial class MainWindow : Window
        {
            protected void Application_Start()
            {

                AreaRegistration.RegisterAllAreas();
                GlobalConfiguration.Configure(WebApiConfig.Register);
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);
            }
            //[System.Web.Http.HttpPost]
            //[ValidateAntiForgeryToken]
            //public MainWindow()
            //public ActionResult Login(LoginViewModel model, string returnUrl)
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return View(model);
            //    }
        }
        }
       
    }

