using System;
using System.Collections.Generic;
using System.Text;
using StudentAppFile.Repositories;


namespace StudentAppFile
{
    class TeacherMenu
    {
        TeacherRepository teacherRepository=new TeacherRepository();

        public void Menu ()
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
                      teacherRepository.RegisterTeacher();
                      Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        teacherRepository.GetOne();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        teacherRepository.GetAll();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        teacherRepository.UpdateTeacher();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        teacherRepository.DeleteTeacher();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }
        }

        public void PrintMenu ()
        {
            Console.WriteLine("Enter 1 to  register  Teacher");
            Console.WriteLine("Enter 2 to  get one   Teacher");
            Console.WriteLine("Enter 3 to  get all   Teacher");
            Console.WriteLine("Enter 4 to  update    Teacher");
            Console.WriteLine("Enter 5 to  delete    Teacher");
            Console.WriteLine("Enter 0 to  exit");
        }
        public static void MenuMain ()
        {
            TeacherMenu teacherMenu=new TeacherMenu();
            teacherMenu.Menu();
        }
    }
}
