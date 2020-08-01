using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cadastro_Mvc;

namespace Cadastro_Mvc.Controllers
{
    public class tbldepartamentoesController : Controller
    {
        private MeuBanco db = new MeuBanco();

        // GET: tbldepartamentoes
        public ActionResult Index()
        {
            return View(db.tbldepartamento.ToList());
        }

        // GET: tbldepartamentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartamento tbldepartamento = db.tbldepartamento.Find(id);
            if (tbldepartamento == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartamento);
        }

        // GET: tbldepartamentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbldepartamentoes/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nome,descricao")] tbldepartamento tbldepartamento)
        {
            if (ModelState.IsValid)
            {
                db.tbldepartamento.Add(tbldepartamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbldepartamento);
        }

        // GET: tbldepartamentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartamento tbldepartamento = db.tbldepartamento.Find(id);
            if (tbldepartamento == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartamento);
        }

        // POST: tbldepartamentoes/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,descricao")] tbldepartamento tbldepartamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbldepartamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbldepartamento);
        }

        // GET: tbldepartamentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartamento tbldepartamento = db.tbldepartamento.Find(id);
            if (tbldepartamento == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartamento);
        }

        // POST: tbldepartamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbldepartamento tbldepartamento = db.tbldepartamento.Find(id);
            db.tbldepartamento.Remove(tbldepartamento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
