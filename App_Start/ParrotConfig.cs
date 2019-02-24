[assembly: WebActivatorEx.PreApplicationStartMethod(typeof($safeprojectname$.App_Start.ParrotConfig), "Start")]
namespace $safeprojectname$.App_Start
{
    using Parrot.AspNet;

    public class ParrotConfig
    {
        public static void Start()
        {
            System.Web.Mvc.ViewEngines.Engines.Add(new ParrotViewEngine());
        }
    }
}