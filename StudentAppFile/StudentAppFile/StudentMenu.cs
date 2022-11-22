using System;
using System.Collections.Generic;
using System.Text;
using StudentAppFile.Repositories;


namespace StudentAppFile
{
    class StudentMenu
    {
        StudentRepository studentRepository=new StudentRepository();


        public  void Menu()
        {
            var check = true;
            while (check)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Enter your choice: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        studentRepository.RegisterStudent();
                        Console.ReadKey();
                        break;
                    case 2:
                        studentRepository.GetStudent();
                        Console.ReadKey();
                        break;
                    case 3:
                        studentRepository.GetAll();
                        Console.ReadKey();
                        break;
                    case 4:
                        studentRepository.UpdateStudent();
                        Console.ReadKey();
                        break;
                    case 5:
                        studentRepository.DeleteStudent();
                        Console.ReadKey();
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;

                }
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("Enter 1 to  register  student");
            Console.WriteLine("Enter 2 to  get one   student");
            Console.WriteLine("Enter 3 to  get all   student");
            Console.WriteLine("Enter 4 to  update    student");
            Console.WriteLine("Enter 5 to  delete    student");
            Console.WriteLine("Enter 0 to  exit");
        }
        public static void MenuMain ()
        {
            StudentMenu studentMenu=new StudentMenu();
            studentMenu.Menu();
        }
    }
}
