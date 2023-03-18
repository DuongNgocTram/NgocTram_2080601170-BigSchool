using System.Web;
using System.Web.Mvc;

namespace NgocTram_2080601170
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
