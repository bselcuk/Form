using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compass.Controllers
{
    public class MBRController : Controller
    {
        // GET: MBRController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MBRController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MBRController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MBRController/Create
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

        // GET: MBRController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MBRController/Edit/5
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

        // GET: MBRController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MBRController/Delete/5
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
