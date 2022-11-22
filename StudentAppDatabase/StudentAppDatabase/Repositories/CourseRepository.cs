using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using StudentAppDatabase.Model;


namespace StudentAppDatabase.Repositories
{
    class CourseRepository
    {
        public MySqlConnection mySqlConnection;


        public CourseRepository(MySqlConnection connection)
        {
            mySqlConnection = connection;
        }


        public bool CreateCourse()
        {
            Console.Write("Please enter the Course name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the course code: ");
            string code = Console.ReadLine();
            Console.Write("Please enter the course  description: ");
            string description = Console.ReadLine();
            try
            {
                mySqlConnection.Open();
                string query = $"insert into departments(name, code, description) values ('" +name +"','" +code +"','" +description +"')";
                MySqlCommand command=new MySqlCommand(query,mySqlConnection);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    Console.WriteLine("Department created successfully.");
                    mySqlConnection.Close();
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }


        public Course Find(int id)
        {
            Course course = null;
            try
            {
                mySqlConnection.Open();
                string query = "select * from courses where Id='" +id +"'";
                MySqlCommand command=new MySqlCommand(query,mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var name = reader.GetString(1);
                    var code = reader.GetString(2);
                    var description = reader.GetString(3);
                    mySqlConnection.Close();
                    return new Course(id,name,code,description);
                }
                mySqlConnection.Close();
            }
            catch (MySqlException  e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }


        public List<Course> GetAll()
        {
            List<Course> courses=new List<Course>();
            try
            {
                mySqlConnection.Open();
                string query = "select * from courses";
                MySqlCommand command=new MySqlCommand(query,mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var code = reader.GetString(2);
                    var description = reader.GetString(3);
                    var course=new Course(id,name,code,description);
                    courses.Add(course);
                }
                mySqlConnection.Close();
            }
            catch (MySqlException  e)
            {
                Console.WriteLine(e.Message);
            }

            return courses;
        }


        public bool update()
        {
            Console.Write("Please enter the department id to update: ");
            int id = int.Parse(Console.ReadLine());
            var s = Find(id);
            try
            {
                if (s  != null)
                {
                    Console.Write("Please enter the Course name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter the course code: ");
                    string code = Console.ReadLine();
                    Console.Write("Please enter the course  description: ");
                    string description = Console.ReadLine();
                    mySqlConnection.Open();
                    string query="update courses set name = '" + name + "', code = '" +code +"', description = '" +description +"' where id = '" + id +"'";
                    MySqlCommand command=new MySqlCommand(query,mySqlConnection);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine("Course  is updated successfully");
                        mySqlConnection.Close();
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine($"Course with id {id} does not exist");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }


        public void Delete()
        {
            Console.Write("Please enter the department id to update: ");
            int id = int.Parse(Console.ReadLine());
            var s = Find(id);
            try
            {
                if (s != null)
                {
                    mySqlConnection.Open();
                    string query = "delete from courses where id='" + id + "'";
                    MySqlCommand command=new MySqlCommand(query,mySqlConnection);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine("Course deleted successfully");
                    }
                }
                else
                {
                    Console.WriteLine($"Course with id {id} does not exist");
                }
                mySqlConnection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }



        public void GetCourses()
        {
            var course = GetAll();
            foreach (var dept in course)
            {
                Console.WriteLine($"{dept.Id}\t  {dept.Name}\t  {dept.Code}\t  {dept.Description}");
            }
        }



        public void GetCourse()
        {
            Console.Write("Enter the course id: ");
            int id = int.Parse(Console.ReadLine());
            var corse = Find(id);
            if (corse != null)
            {
                Console.WriteLine($"{corse.Id}\t  {corse.Name}\t  {corse.Code}\t  {corse.Description}");
            }
        }




































    }
}
