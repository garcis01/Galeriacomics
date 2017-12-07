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
            
            /*if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "mensaje desde el controlador"
            };*/

            ViewBag.tituloComic = "EL increible Hulk!!!";
            ViewBag.numeroComic = "790";
            ViewBag.descripcion = "<p>Hulk ayuda a los avengers a darle en la madre a <strong>ultron</strong></p>";
            ViewBag.artists = new string[]
                {
            "script: dan slott",
            "pencils: humberto ramos",
            "Inks: victor olazaba",
            "colors: Edgar Delgado",
            "letter: Chris eliopoulos"
                };
            return View();
        }
    }
}