using System.Web;
using System.Web.Mvc;

namespace A4_BigSchools
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Bộ lọc xử lí lỗi
            filters.Add(new HandleErrorAttribute());
        }
    }
}
