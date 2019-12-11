using repo.Models;
using repo.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace repo.Service
{
    public class WorkerService
    {
        private readonly WorkerRepository _workerRepository;
        public WorkerService()
        {
            _workerRepository = new WorkerRepository();
        }
        public void Create(Worker worker)
        {
            _workerRepository.Create(worker);
        }
        public List<Worker> GetAll()
        {
            var list = _workerRepository.GetWhere(x => x.Id > 0);
                return list;
        }
        public void Edit(Worker model)
        {
            _workerRepository.Edit(model);
            
        }
        public void Delete (Worker model)
        {
            _workerRepository.Delete(model);
        }
        public Worker GetById(int id)
        {
            return _workerRepository.GetWhere(x => x.Id == id).FirstOrDefault();
        }

    }
}