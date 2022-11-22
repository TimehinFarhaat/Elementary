using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;


namespace TwoEntites.Interfaces.Services
{
    public interface IWorkerService
    {
        bool   RegisterWorker (Worker worker);
        string    DeleteWorker (int   id);
        Worker   GetWorker (int  id);
        IList<Worker> GetWorkers ();
        IList<Worker> DepartWorkers(int id);
       
        bool   UpdateWorker (int id, Worker worker);
    }
}
