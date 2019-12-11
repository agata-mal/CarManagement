using AutoMapper;
using repo.Service;
using repo.ViewModels;

namespace repo.Builder
{
    public class VM_CarBuilder : BuilderAbstract<VM_Car>
    {
        private readonly WorkerService _workerService;
        private readonly CarService _carService;
        public VM_CarBuilder()
        {
            _workerService = new WorkerService();
            _carService = new CarService();
        }

        public VM_CarBuilder Initialize()
        {
            Prototype = new VM_Car();
            return this;
        }
        public VM_CarBuilder SetWorkersList()
        {
            Prototype.ListOfWorkers = _workerService.GetAll();
            return this;
        }
        public VM_CarBuilder SetExistingEntity(int id)
        {
            var model = _carService.GetById(id);
            Mapper.Map(model, Prototype);
            return this;
        }

    }
}