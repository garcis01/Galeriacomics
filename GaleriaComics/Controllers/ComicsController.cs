using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GaleriaComics.Controllers
{
    public class ComicsController: Controller
    {
        /*public string Detalle()
        {
            return "mensaje desde el contolador";
        }*/

        public ActionResult Detalle()
        {
            return View();
            /*if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "mensaje desde el controlador"
            };*/
        }
    }
}