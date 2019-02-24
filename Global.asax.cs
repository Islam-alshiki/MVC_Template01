using $safeprojectname$.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace $safeprojectname$
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Register the default hubs route: ~/signalr
            //RouteTable.Routes.MapHubs();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MappingConfig.RegisterMaps();
        }

        //
        //protected void Application_PreSendRequestHeaders()
        //{
        //    Response.Headers.Remove("Server");              //Remove Server Header   
        //    Response.Headers.Remove("X-AspNet-Version");    //Remove X-AspNet-Version Header
        //    Response.Headers.Remove("X-Powered-By");        //Remove X-Powered Header
        //    Response.Headers.Remove("X-Frame-Options");     //Remove X-Powered Header
        //    Response.Headers.Remove("X-SourceFiles");       //Remove X-Powered Header
        //}

        //
        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    Exception exception = Server.GetLastError();

        //    Response.Clear();
        //    var httpException = exception as HttpException;
        //    var routeData = new RouteData();
        //    routeData.Values.Add("controller", "Error");

        //    if (httpException == null)
        //    {
        //        routeData.Values.Add("action", "Index");
        //    }
        //    else
        //    {
        //        switch (httpException.GetHttpCode())
        //        {
        //            case 404:
        //                routeData.Values.Add("action", "NotFound");
        //                break;
        //            default:
        //                routeData.Values.Add("action", "Index");
        //                break;
        //        }
        //    }

        //    routeData.Values.Add("error", exception);
        //    Server.ClearError();
        //    IController errorController = DependencyResolver.Current.GetService<ErrorController>();
        //    errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        //}
        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    var exception = Server.GetLastError();
        //    var httpException = exception as HttpException;

        //    //log the error!
        //    ALMEDADSOFT_StoreEntities1 dB = new ALMEDADSOFT_StoreEntities1();
        //    dB.tUsersLogins.Add(new tUsersLogin()
        //    {
        //        userLogin_date = DateTime.Now,
        //        userLogin_note = "Error=> " + exception.StackTrace,
        //        userLogin_browser = "Error=> " + exception.Message,
        //        userLogin_user = 0,
        //        userLogin_waraingType = 9
        //    });
        //    dB.SaveChanges();
        //    var httpContext = ((HttpApplication)sender).Context;
        //    httpContext.Response.Clear();
        //    httpContext.ClearError();
        //    ExecuteErrorController(httpContext, exception, httpException);
        //}

        //
        //private void ExecuteErrorController(HttpContext httpContext, Exception exception, HttpException httpException)
        //{
        //    var routeData = new RouteData();
        //    routeData.Values["controller"] = "Error";
        //    routeData.Values["action"] = "Index";
        //    //routeData.Values["errorType"] = 9; //this is your error code. Can this be retrieved from your error controller instead?
        //    routeData.Values["exception"] = exception;
        //    routeData.Values["httpException"] = httpException;
        //    routeData.Values["date"] = DateTime.Now;

        //    using (Controller controller = new ErrorController())
        //    {
        //        ((IController)controller).Execute(new RequestContext(new HttpContextWrapper(httpContext), routeData));
        //    }
        //}

    }
}
