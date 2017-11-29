using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TalentosEasy.Controllers
{
    public class TalentosController : Controller
    {
        // GET: Talentos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Talentos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Talentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talentos/Create
        [HttpPost]
        public ActionResult Create(JObject collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Talentos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Talentos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Talentos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Talentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
