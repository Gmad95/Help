using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registro.Controllers
{
    public class apiController : Controller
    {

        public ActionResult Media(List<Votazione> myArray)
        {
            int PesoTotale = 0;
            int SommaTotale = 0;
            int MediaCalcolata = 0;

            if (myArray != null)
            {
                foreach (Votazione v in myArray)
                {
                    PesoTotale += v.Peso;
                    SommaTotale += v.Voto * v.Peso;
                }
                MediaCalcolata = SommaTotale / PesoTotale;
            }
           
            string result = "{\"value\": " + MediaCalcolata.ToString() + "}"; //oggetto json con un solo valore,la media calcolata
            return Content(result,"application/json");
        }
    }
}