using System.Web;
using System.Web.Mvc;

namespace FirstProjectUniciv.webs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
