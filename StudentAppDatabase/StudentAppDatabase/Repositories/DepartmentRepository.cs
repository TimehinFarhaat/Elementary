using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using StudentAppDatabase.Model;


namespace StudentAppDatabase.Repositories
{
    class DepartmentRepository
    {


        public MySqlConnection _connection;
        public DepartmentRepository(MySqlConnection connection)
        {
            _connection = connection;
        }




        public bool CreateDept()
        {
            Console.Write("Please enter the department name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the department code: ");
            string code = Console.ReadLine();
            Console.Write("Please enter the department description: ");
            string description = Console.ReadLine();

            try
            {
                _connection.Open();
                string query = $"insert into departments(name, code, description) values ('"+name+"','"+code+"','"+description+"')";
                MySqlCommand command=new MySqlCommand(query,_connection);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    Console.WriteLine("Department created successfully.");
                    _connection.Close();
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
                
            }


            return false;
        }





        private Department Find(int id)
        {
            Department department = null;
            try
            {
                _connection.Open();
                string query = "select * from departments where Id='"+id+"'";
                MySqlCommand command=new MySqlCommand(query,_connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var name = reader.GetString(1);
                    var code = reader.GetString(2);
                    var description = reader.GetString(3);
                    _connection.Close();

                    return new Department(id, name, code, description);
                }
                _connection.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
              
            }

            return null;
        }




        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            try
            {
                _connection.Open();
                string query = "select * from departments";
                MySqlCommand command=new MySqlCommand(query,_connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var code = reader.GetString(2);
                    var description = reader.GetString(3);
                    var department= new Department(id, name, code, description);
                    departments.Add(department);
                }
                _connection.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);

            }

            return departments;
        }




        public bool Update()
        {
            
            Console.Write("Please enter the department id to update: ");
            int id = int.Parse(Console.ReadLine());
            var dept = Find(id);
            if (dept != null)
            {
                try
                {
                    _connection.Open();
                    Console.Write("Please enter the department name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter the department code: ");
                    string code = Console.ReadLine();
                    Console.Write("Please enter the department description: ");
                    string description = Console.ReadLine();

                   
                    string query = "update departments set name = '" + name + "', code = '" +code +"', description = '"+description+"' where id = '"+ id +"'";
                    MySqlCommand command=new MySqlCommand(query,_connection);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine("Department updated successfully.");
                        _connection.Close();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;

                }
            }
            else
            {
                Console.WriteLine("Department with the id "+ id +" does not exist");
            }

            return false;
        }


        public void Delete()
        {
            Console.Write("Please enter the department id to delete: ");
            int id = int.Parse(Console.ReadLine());
            var dept = Find(id);
            if (dept != null)
            {
                try
                {
                    _connection.Open();


                    string query = "delete from departments where id='" + id + "' ";
                    MySqlCommand command=new MySqlCommand(query,_connection);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine("Department deleted successfully.");
                      
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                _connection.Close();
            }
            else
            {
                Console.WriteLine("Department with the id " + id + " does not exist");
            }
        }



        public void GetDepartments()
        {
            var departments = GetAll();
            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.Id}\t  {dept.Name}\t  {dept.Code}\t  {dept.Description}");
            }
        }




        public void GetDepartment()
        {
            Console.Write("Enter the department id: ");
            int id = int.Parse(Console.ReadLine());
            var depart = Find(id);
            if (depart != null)
            {
                Console.WriteLine($"{depart.Id}\t  {depart.Name}\t  {depart.Code}\t  {depart.Description}");
            }
            else
            {
                Console.WriteLine($"The department with id {depart.Id} does not exist");
            }

        }

































































    }
}
