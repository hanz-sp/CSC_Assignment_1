using System.Web;
using System.Web.Mvc;

namespace Assignment_Task_2_Practical_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
