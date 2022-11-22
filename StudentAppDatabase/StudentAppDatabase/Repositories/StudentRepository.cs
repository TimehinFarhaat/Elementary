using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;
using StudentAppDatabase.Model;


namespace StudentAppDatabase.Repositories
{
    class StudentRepository
    {
        private MySqlConnection _connection;


        List<Student> students = new List<Student>();
        public StudentRepository (MySqlConnection connection)
        {
            _connection = connection;
        }


      


        public bool Register ()
        {
            Console.Write("Enter student name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter student Last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter student age: ");
            int  age = int.Parse(Console.ReadLine());
            Console.Write("Enter student id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter student address: ");
            string address = Console.ReadLine();
            Console.Write("Enter student Phone Number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Enter student Email: ");
            string email = Console.ReadLine();

              
            return false;
        }

      


     
    }
}
