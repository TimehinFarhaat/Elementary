using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using StudentAppFile.Model;



namespace StudentAppFile.Repositories
{
    class TeacherRepository
    {
        List<Teacher> teachers=new List<Teacher>();
        private string file = "C:\\Users\\staa99\\source\\ repos\\StudentAppFile\\StudentAppFile\\Files\\ teacherFile.txt";


        public TeacherRepository()
        {
            ReadTeacherFromFile();
        }


        private void ReadTeacherFromFile()
        {
            try
            {
                var AllTeachers = File.ReadAllLines(file);
                foreach (var item in AllTeachers)
                {
                    teachers.Add(Teacher.ToTeacher(item));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
        public Teacher RegisterTeacher ()
        {
            
            Console.Write("Enter  First Name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter  Last Name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter  age: ");
            int age =int.Parse(Console.ReadLine());
            Console.Write("Enter  Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter  phoneNumber: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Enter  Email: ");
            string email = Console.ReadLine();
            var teacher=new Teacher(firstname,lastname,age,address,phoneNum,email);
            int id = teacher.Id;
            Console.WriteLine($" You have been registered successfully and your id is {id}");

         

            AddTeacherFile(teacher);
            teachers.Add(teacher);
            return new Teacher(firstname,lastname,age,address,phoneNum,email,id);

        }



        private void AddTeacherFile(Teacher teacher)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    writer.WriteLine(teacher.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }


        public void GetAll()
        {
            if (teachers.Count==0)
            {
                Console.WriteLine("There is no teachers available");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    Console.WriteLine(teacher);
                }
            }
        }



        private void PrintTeachers(Teacher teacher)
        {
            Console.WriteLine(teacher.ToString());
        }





        public void GetTeacher ()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("THERE IS NO TEACHER AVAILABLE ");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    Console.Write("Enter Id: ");
                    int id =int.Parse(Console.ReadLine());
                    if (id == teacher.Id)
                    {
                        Console.WriteLine(teacher.ToString());
                        break;
                    }
                }
            }
        }




        public void UpdateTeacher ()
        {
            Console.Write("Enter the id of teacher to update: ");
            var id = int.Parse(Console.ReadLine());
            var teacher = GetTeacherById(id);
            if (teacher != null)
            {
                Console.Write("Enter teacher first name:");
                string fistname = Console.ReadLine();
                Console.Write("Enter teacher last name:");
                string lastname = Console.ReadLine();
                Console.Write("Enter teacher age:");
                int age =int.Parse(Console.ReadLine());


                teacher.FirstName = fistname;
                teacher.LastName = lastname;
                teacher.Age = age;

                RefreshFile();
                Console.WriteLine($"Teacher with id:{id} updated successfully");
            }
            else
            {
                Console.WriteLine($"Teacher with id:{id} does not exists");
            }
        }



        public void DeleteTeacher()
        {
            Console.Write("Enter the id of teacher to update: ");
            var id = int.Parse(Console.ReadLine());
            var teacher = GetTeacherById(id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
                RefreshFile();
                Console.WriteLine($"Teacher with id:{teacher.Id} has been removed successfully");
            }
            else
            {
                Console.WriteLine($"Teacher with id :{teacher.Id} is not found");
            }
        }


        public void GetOne()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("THERE IS NO STUDENT AVAILABLE ");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    Console.Write("Enter Id: ");
                    int id =int.Parse(Console.ReadLine());
                    if (id == teacher.Id)
                    {
                        Console.WriteLine($"{teacher.ToString()}");
                        break;
                    }
                }
            }
        }



        public Teacher GetTeacherById (int id)
        {
            foreach (var teacher in teachers)
            {
                if (teacher.Id == id)
                {
                    return teacher;
                    break;
                }
            }
            return null;
        }




        private void RefreshFile()
        {
            try
            {
                using (StreamWriter writer=new StreamWriter(file,false))
                {
                    foreach (var teacher in teachers)
                    {
                        writer.WriteLine(teacher.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
