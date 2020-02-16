using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora_MVC.Controllers
{
    public class Control_calciController : Controller
    {
        // GET: Control_calci
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult invertir(int value) {

            int residuo, numeroF = 0;

            if (value >= 10 && value <= 99) {

                while(value > 0)
                {
                    residuo = value % 10;
                    value = value / 10;
                    numeroF = numeroF * 10 + residuo;
                }
            }
            else
            {
                Response.Write("<script>alert('Debes insertr un numero de dos cifras')</script>");
             
            }

            return Content("El Numero invertido es " + numeroF);
        }
    }
}