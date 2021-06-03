using System.Web;
using System.Web.Mvc;

namespace AnimalGuard_Inspection_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
