using AdminLTE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdminLTE.ViewComponents
{
    public class MenuUserViewComponent : ViewComponent
    {

        public MenuUserViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
