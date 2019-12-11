using repo.Models;
using repo.Models.Repository;
using repo.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace repo.Service
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        public CarService()
        {
            _carRepository = new CarRepository();
        }
        public void Create(Car model)
        {
            _carRepository.Create(model);
        }
        public List<Car> GetAll()
        {
            var list = _carRepository.GetWhereWithIncludes(x => x.Id > 0, y => y.Workers);
            return list;
        }
        public void AddWorkerToCar(VM_Car model)
        {
            var car = _carRepository.GetWhere(x => x.Id == model.Id).FirstOrDefault();
            car.WorkerId = model.WorkerId;
            _carRepository.Edit(car);
        }
        public void EditCar(Car car)
        {
            _carRepository.Edit(car);
        }
        public void Delete(Car model)
        {
            _carRepository.Delete(model);
        }
        public Car GetById(int id)
        {

            return _carRepository.GetWhereWithIncludes(x => x.Id == id, y => y.Workers).FirstOrDefault();
        }

    }
}