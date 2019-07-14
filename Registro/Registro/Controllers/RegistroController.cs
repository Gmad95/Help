using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registro.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            List<Votazione> v = new List<Votazione>();
            if (Session["Votazioni"] != null)
                v = (Session["Votazioni"] as List<Votazione>);

            return View(v);
        }

        public ActionResult NewVotazione()
        {
            Votazione v = new Votazione();
            return View(v);
        }

        public ActionResult SaveNewVotazione(Votazione vForm)
        {
            List<Votazione> v = new List<Votazione>();
            if (Session["Votazioni"] != null)
                v = (Session["Votazioni"] as List<Votazione>);
            v.Add(vForm);
            Session["Votazioni"] = v;
            if (Request.Form["Salva2"] != null)
                return RedirectToAction("NewVotazione");
            else
                return Redirect("~");
        }
    }
}