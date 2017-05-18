using CrossCutting.Filtros.Filtros;
using System.Web.Mvc;

namespace Gestao.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());

        }
    }
}
