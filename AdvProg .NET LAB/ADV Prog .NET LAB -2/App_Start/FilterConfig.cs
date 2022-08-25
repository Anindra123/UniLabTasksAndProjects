using System.Web;
using System.Web.Mvc;

namespace ADV_Prog.NET_LAB__2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
