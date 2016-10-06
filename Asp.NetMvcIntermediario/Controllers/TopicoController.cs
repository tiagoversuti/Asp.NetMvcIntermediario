using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asp.NetMvcIntermediario.Models;

namespace Asp.NetMvcIntermediario.Controllers
{
    public class TopicoController : Controller
    {
        private BancoContexto db = new BancoContexto();

        // GET: Topico
        public ActionResult Index()
        {
            var topicos = db.Topicos.Include(t => t.Professor);
            return View(topicos.ToList());
        }

        // GET: Topico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicos.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // GET: Topico/Create
        public ActionResult Create()
        {
            ViewBag.IDProfessor = new SelectList(db.Professores, "IDProfessor", "Nome");
            return View();
        }

        // POST: Topico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDTopico,IDProfessor,Descricao")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Topicos.Add(topico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDProfessor = new SelectList(db.Professores, "IDProfessor", "Nome", topico.IDProfessor);
            return View(topico);
        }

        // GET: Topico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicos.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDProfessor = new SelectList(db.Professores, "IDProfessor", "Nome", topico.IDProfessor);
            return View(topico);
        }

        // POST: Topico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDTopico,IDProfessor,Descricao")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDProfessor = new SelectList(db.Professores, "IDProfessor", "Nome", topico.IDProfessor);
            return View(topico);
        }

        // GET: Topico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicos.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // POST: Topico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Topico topico = db.Topicos.Find(id);
            db.Topicos.Remove(topico);
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
