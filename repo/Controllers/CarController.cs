using repo.Builder;
using repo.Models;
using repo.Service;
using repo.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace repo.Controllers
{
    public class CarController : Controller
    {
        private readonly CarService _carService;
        private readonly VM_CarBuilder _vmCarBuilder;
        public CarController()
        {
            _carService = new CarService();
            _vmCarBuilder = new VM_CarBuilder();
        }
        // GET: Car
        public ActionResult Index()
        {
            var list = _carService.GetAll();
            var vmList = new List<VM_Car>();
            AutoMapper.Mapper.Map(list, vmList);
            return View("CarList", vmList);
        }
        public ActionResult Create()
        {

            return View("CreateCar");
        }
        [HttpGet]
        public ActionResult AddWorkerToCar(int id)
        {
            var addWorkerToCar = _vmCarBuilder
                .Initialize()
                .SetExistingEntity(id)
                .SetWorkersList()
                .GetProduct();
            return View("AddWorkerToCar", addWorkerToCar);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var delete = _carService.GetById(id);
            var deleteVMCar = new VM_Car();
            AutoMapper.Mapper.Map(delete, deleteVMCar);
            return View("DeleteCar", deleteVMCar);
        }

        [HttpGet]
        public ActionResult EditCar(int id)
        {
            var editCar = _carService.GetById(id);
            var editVMCar = new VM_Car();
            AutoMapper.Mapper.Map(editCar, editVMCar);
            return View("EditCar", editVMCar);
        }

        [HttpPost]
        public ActionResult Create(VM_Car car)
        {
            var carEntity = new Car();
            AutoMapper.Mapper.Map(car, carEntity);
            _carService.Create(carEntity);
            return RedirectToAction("Index", "Car");
        }
        public ActionResult AddWorkerToCar(VM_Car car)
        {
            _carService.AddWorkerToCar(car);
            return RedirectToAction("Index", "Car");
        }
        public ActionResult EditCar(VM_Car car)
        {
            var carEntity = new Car();
            AutoMapper.Mapper.Map(car, carEntity);
            _carService.EditCar(carEntity);
            return RedirectToAction("Index", "Car");
        }
        public ActionResult Delete(VM_Car car)
        {
            var carEntity = new Car();
            AutoMapper.Mapper.Map(car, carEntity);
            _carService.Delete(carEntity);
            return RedirectToAction("Index", "Car");
        }
    }
}