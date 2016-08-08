using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.ViewComponents
{
    public class ControlSidebarViewComponent : ViewComponent
    {

        public ControlSidebarViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
