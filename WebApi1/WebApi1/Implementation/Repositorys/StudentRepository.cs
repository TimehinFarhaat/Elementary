                                      using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Context;
using WebApi1.Entity;
using WebApi1.Interfaces.Repository;


namespace WebApi1.Implementation.Repositorys
{
    public class StudentRepository:BaseRepository<Student>,IStudentRepository
    {

        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
