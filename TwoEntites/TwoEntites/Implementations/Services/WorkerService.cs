using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;
using TwoEntites.Implementations.Repository;
using TwoEntites.Interfaces.Repository;
using TwoEntites.Interfaces.Services;


namespace TwoEntites.Implementations.Services
{
    public class WorkerService:IWorkerService
    {
        private readonly IWorkerRepository _workerRepository;


        public WorkerService (IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }


        public bool RegisterWorker (Worker worker)
        {
            var t = _workerRepository.EmailExist(worker.Email);
            if (t )
            {
                throw new Exception($"Worker with Email {worker.Email} already exist");
            }
            var work=new Worker()
            {
                FirstName = worker.FirstName,
                LastName = worker.LastName,
                Age = worker.Age,
                DepartmentId = worker.DepartmentId,
                Email = worker.Email
            };

            _workerRepository.AddWorker(work);
            return true;
        }



        public string DeleteWorker (int id)
        {
            var y = _workerRepository.GetWorker(id);
            if (y == null)
            {
                throw new Exception($"Worker with  id {id} does not exist");
            }
            else
            {
                _workerRepository.DeleteWorker(id);
                return $"Worker with Id {id} deleted Successfully";
            }
        }



        public Worker GetWorker (int id)
        {
            return _workerRepository.GetWorker(id);
        }



        

        public IList<Worker> GetWorkers()
        {
            return _workerRepository.Workers();
        }


   
        public IList<Worker> DepartWorkers(int id)
        {
            return _workerRepository.DepartmentWorkers(id);
        }


        public bool UpdateWorker (int id, Worker worker)
        {
            var y = _workerRepository.GetWorker(id);
            if (y == null)
            {
                throw new Exception($"Worker with  id {id} does not exist");
            }
            else
            {

                y.FirstName = worker.FirstName;
                y.LastName = worker.LastName;
                y.Age = worker.Age;
                y.DepartmentId = worker.DepartmentId;
                y.Email = worker.Email;
                

                _workerRepository.UpdateWorker(id);
                return true;
            }
        }
    }
}
