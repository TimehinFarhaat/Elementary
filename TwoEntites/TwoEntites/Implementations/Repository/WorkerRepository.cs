using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwoEntites.Context;
using TwoEntites.Entities;
using TwoEntites.Interfaces.Repository;


namespace TwoEntites.Implementations.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly ApplicationContext _context;


        public WorkerRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Worker GetWorker(int id)
        {
            var g = _context.Workers.Include(x=>x.Department).FirstOrDefault(x=>x.Id==id);
            return g;
        }




        public bool AddWorker(Worker worker)
        {
            _context.Workers.Add(worker);
            _context.SaveChanges();
            return true;
        }


        public bool DeleteWorker(int id)
        {
            var g = _context.Workers.Find(id);
            _context.Workers.Remove(g);
            _context.SaveChanges();
            return true;
        }


        public bool UpdateWorker(int id)
        {
            var g = _context.Workers.Find(id);
            _context.Workers.Update(g);
            _context.SaveChanges();
            return true;
        }


        public IList<Worker> DepartmentWorkers(int id)
        {
            return _context.Workers.Include(i=>i.Department).Where(y => y.DepartmentId == id).ToList();
        }



        public bool EmailExist(string email)
        {
            return _context.Workers.Any(u => u.Email == email);
        }


        public IList<Worker> Workers()
        {
            return _context.Workers.ToList();
        }
    }
}
