using System.Web;
using System.Web.Mvc;

namespace COMP2084Lab2NoahWilson
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
