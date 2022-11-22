using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineShopping.Repositories
{
    class UserRepository:IBaseRepository<User>,IUserRepository
    {
        private readonly ApplicatinContext _context;


        public User Create(User obj) => throw new NotImplementedException();


   
        public User Get(Expression<Func<User, bool>> expression) => throw new NotImplementedException();


  
        public List<User> GetMany(Expression<Func<User, bool>> expression) => throw new NotImplementedException();
        public User Update(User obj) => throw new NotImplementedException();


        /// <inheritdoc />
        public bool Delete(int id) => throw new NotImplementedException();


        /// <inheritdoc />
        public User CreateUser(User user) => throw new NotImplementedException();


        /// <inheritdoc />
        public User GetUser(string email) => throw new NotImplementedException();


        /// <inheritdoc />
        public User GetUser(string email, string password) => throw new NotImplementedException();


        /// <inheritdoc />
        public User GetUser(int id) => throw new NotImplementedException();


        /// <inheritdoc />
        public User DeleteUser(int id) => throw new NotImplementedException();


        /// <inheritdoc />
        public User UpdateUser(User user) => throw new NotImplementedException();
    }
}
 