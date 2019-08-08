using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using log4net;

namespace AIMailService
{
    public class Global : HttpApplication
    {
        public ILog log
        {
            get { return LogManager.GetLogger("YourAppNameLogger"); }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // 응용 프로그램 시작 시 실행되는 코드
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            log.Fatal("Site Application_Error", Server.GetLastError());
            Response.Redirect("/SiteException.aspx", false);
            System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest();
            Server.ClearError();
        }
    }
}