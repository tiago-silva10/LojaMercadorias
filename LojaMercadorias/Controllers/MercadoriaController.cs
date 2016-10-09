using LojaMercadorias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaMercadorias.Controllers
{
    public class MercadoriaController : Controller
    {
        private EntidadesLojaMercadoriasBD db = new EntidadesLojaMercadoriasBD();

        //GET
        public ActionResult Index()
        {
            var mercadorias = db.MERCADORIA.ToList();
            ViewBag.TipoMercadoria = new SelectList(db.TIPO_MERCADORIA, "TipoID", "NOME");
            ViewBag.IDNegocio = new SelectList(db.TIPO_NEGOCIO, "NegocioID", "NOME");
            return View(mercadorias);
        }

        //GET
        public ActionResult Adicionar()
        {
            ViewBag.TipoMercadoria = new SelectList(db.TIPO_MERCADORIA, "TipoID", "NOME");
            ViewBag.IDNegocio = new SelectList(db.TIPO_NEGOCIO, "NegocioID", "NOME");

            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Adicionar(MERCADORIA mercadoria)
        {
            if (ModelState.IsValid)
            {
                db.MERCADORIA.Add(mercadoria);
                db.SaveChanges();
                return RedirectToAction("Index", "Mercadoria");
            }

            ViewBag.TipoMercadoria = new SelectList(db.TIPO_MERCADORIA, "TipoID", "NOME", mercadoria.TIPO_MERCADORIA.TipoID);
            ViewBag.IDNegocio = new SelectList(db.TIPO_NEGOCIO, "NegocioID", "NOME", mercadoria.TIPO_NEGOCIO.NegocioID);

            return View(mercadoria);
        }

        //GET
        public ActionResult Editar(int id)
        {
            var mercadoria   = db.MERCADORIA.Find(id);
            ViewBag.TipoMercadoria = new SelectList(db.TIPO_MERCADORIA, "TipoID", "NOME");
            ViewBag.IDNegocio = new SelectList(db.TIPO_NEGOCIO, "NegocioID", "NOME"); 

            return View(mercadoria);
        }

        //POST
        [HttpPost]
        public ActionResult Editar(MERCADORIA mercadoria)
        {
            if (ModelState.IsValid)
            {
                db.MERCADORIA.Add(mercadoria);
                db.SaveChanges();
                return RedirectToAction("Index", "Mercadoria");
            }

            ViewBag.TipoMercadoria = new SelectList(db.TIPO_MERCADORIA, "TipoID", "NOME", mercadoria.TIPO_MERCADORIA.TipoID);
            ViewBag.IDNegocio = new SelectList(db.TIPO_NEGOCIO, "NegocioID", "NOME", mercadoria.TIPO_NEGOCIO.NegocioID);

            return View(mercadoria);
        }

        //GET
        public ActionResult Excluir(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Não foi possível salvar as mudanças. Tente novamente......";
            }
            var mercadoria = db.MERCADORIA.Find(id);
            return View(mercadoria);
        }

        // POST
        [HttpPost, ActionName("Excluir")]
        public ActionResult Excluir(int id)
        {
            try
            {
                var mercadoria = db.MERCADORIA.Find(id);
                db.MERCADORIA.Remove(mercadoria);
                db.SaveChanges();
            }
            catch
            {
                return RedirectToAction("Excluir", new System.Web.Routing.RouteValueDictionary {
               { "ID", id },
               { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}
