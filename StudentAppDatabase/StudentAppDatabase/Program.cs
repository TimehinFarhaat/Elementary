using System;
using MySql.Data.MySqlClient;
using StudentAppDatabase.Repositories;


namespace StudentAppDatabase
{
    class Program
    {
        static void Main (string[] args)
        {
            string connectionString = "server=localhost;user=root;database=SchoolAppDataBase;port=3306;password=alfawwazstaa99";
            MySqlConnection connection = new MySqlConnection(connectionString);
            DepartmentRepository deptRepo = new DepartmentRepository(connection);
            deptRepo.Delete();  
    
           

        }
    }
}
