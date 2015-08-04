using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HojaConduccion1.Models;

namespace HojaConduccion1.Controllers
{
    public class ManiobrasController : Controller
    {
        private HojaConduccion1Context db = new HojaConduccion1Context();

        // GET: Maniobras
        public ActionResult Index()
        {
            return View(db.Maniobras.ToList());
        }

        // GET: Maniobras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maniobra maniobra = db.Maniobras.Find(id);
            if (maniobra == null)
            {
                return HttpNotFound();
            }
            return View(maniobra);
        }

        // GET: Maniobras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maniobras/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManiobraID,Tren,CocheP,Radio,LugarIni,HoraIni,HoraFin,LugarFin,DuracionManiobra")] Maniobra maniobra)
        {
            if (ModelState.IsValid)
            {
                db.Maniobras.Add(maniobra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maniobra);
        }

        // GET: Maniobras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maniobra maniobra = db.Maniobras.Find(id);
            if (maniobra == null)
            {
                return HttpNotFound();
            }
            return View(maniobra);
        }

        // POST: Maniobras/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManiobraID,Tren,CocheP,Radio,LugarIni,HoraIni,HoraFin,LugarFin,DuracionManiobra")] Maniobra maniobra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maniobra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maniobra);
        }

        // GET: Maniobras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maniobra maniobra = db.Maniobras.Find(id);
            if (maniobra == null)
            {
                return HttpNotFound();
            }
            return View(maniobra);
        }

        // POST: Maniobras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maniobra maniobra = db.Maniobras.Find(id);
            db.Maniobras.Remove(maniobra);
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
