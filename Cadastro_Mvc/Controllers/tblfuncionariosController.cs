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
    public class tblfuncionariosController : Controller
    {
        private MeuBanco db = new MeuBanco();

        // GET: tblfuncionarios
        public ActionResult Index()
        {
            return View(db.tblfuncionarios.ToList());
        }

        // GET: tblfuncionarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblfuncionarios tblfuncionarios = db.tblfuncionarios.Find(id);
            if (tblfuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(tblfuncionarios);
        }

        // GET: tblfuncionarios/Create
        public ActionResult Create()
        {
            var lista = db.tbldepartamento.ToList();
            ViewBag.ListaDep = lista;
            return View();
        }

        // POST: tblfuncionarios/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_func,nome,sobrenome,email,rg,cpf,endereco,bairro,cidade,uf,departamento")] tblfuncionarios tblfuncionarios)
        {
            if (ModelState.IsValid)
            {
                db.tblfuncionarios.Add(tblfuncionarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblfuncionarios);
        }

        // GET: tblfuncionarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblfuncionarios tblfuncionarios = db.tblfuncionarios.Find(id);
            if (tblfuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(tblfuncionarios);
        }

        // POST: tblfuncionarios/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_func,nome,sobrenome,email,rg,cpf,endereco,bairro,cidade,uf,departamento")] tblfuncionarios tblfuncionarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblfuncionarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblfuncionarios);
        }

        // GET: tblfuncionarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblfuncionarios tblfuncionarios = db.tblfuncionarios.Find(id);
            if (tblfuncionarios == null)
            {
                return HttpNotFound();
            }
            return View(tblfuncionarios);
        }

        // POST: tblfuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblfuncionarios tblfuncionarios = db.tblfuncionarios.Find(id);
            db.tblfuncionarios.Remove(tblfuncionarios);
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
