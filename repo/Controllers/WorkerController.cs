using repo.Models;
using repo.Service;
using System.Web.Mvc;

namespace repo.Controllers
{
    public class WorkerController : Controller
    {
        private readonly WorkerService _workerService;
        public WorkerController()
        {
            _workerService = new WorkerService();
        }
        // GET: Worker
        public ActionResult Index()
        {
            var worker = _workerService.GetAll();
            return View("WorkerList",worker);
        }
        public ActionResult Create()
        {
            return View("CreateWorker");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var edit = _workerService.GetById(id);
            return View("EditWorker", edit);
        }
        [HttpGet]
        public ActionResult Delete (int id)
        {
            var delete = _workerService.GetById(id);
            return View("DeleteWorker", delete);
        }

       
        [HttpPost]
        public ActionResult Create(Worker model)
        {
            _workerService.Create(model);
            return RedirectToAction("Index", "Worker");
        }
        public ActionResult Edit(Worker model)
        {
            _workerService.Edit(model);
            return RedirectToAction("Index","Worker");
        }
        public ActionResult Delete (Worker model)
        {
            _workerService.Delete(model);
            return RedirectToAction("Index", "Worker");
        }
    }
}