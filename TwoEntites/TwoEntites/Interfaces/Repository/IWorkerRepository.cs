using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;


namespace TwoEntites.Interfaces.Repository
{
    public interface IWorkerRepository
    {
        Worker  GetWorker (int     id);
      
        bool   AddWorker (Worker worker);
        bool    DeleteWorker (int  id);
        bool    UpdateWorker (int  id);
        bool   EmailExist (string email);
        IList<Worker> Workers ();
        IList<Worker> DepartmentWorkers (int id);
    }
}
