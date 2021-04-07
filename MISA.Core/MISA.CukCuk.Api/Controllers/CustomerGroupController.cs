using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    public class CustomerGroupController : Controller
    {
        // GET: CustomerGroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerGroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerGroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerGroupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
