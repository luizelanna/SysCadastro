using System.Web.Mvc;

namespace CrossCutting.Filtros.Filtros
{
    public class GlobalErrorHandler : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                filterContext.Controller.TempData["Erro: "] = 1010;
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
