using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compass.Controllers
{
    public class PILController : Controller
    {
        // GET: PILController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PILController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PILController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PILController/Create
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

        // GET: PILController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PILController/Edit/5
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

        // GET: PILController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PILController/Delete/5
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
