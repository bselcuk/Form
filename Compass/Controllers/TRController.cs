using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compass.Controllers
{
    public class TRController : Controller
    {
        // GET: TRController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TRController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TRController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRController/Create
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

        // GET: TRController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TRController/Edit/5
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

        // GET: TRController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TRController/Delete/5
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
