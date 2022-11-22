using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternAPI.Context;
using RepositoryPatternAPI.Entities;
using RepositoryPatternAPI.Interfaces.Repository;


namespace RepositoryPatternAPI.Implementation
{
    public class StudentRepository:BaseRepository<Student>,IStudentRepository
    {
        
        public StudentRepository (ApplicationContext context)
        {
            _context = context;
        }

    }
}
