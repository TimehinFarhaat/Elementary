using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
  public  class Student
    {
        //Question1
        public string FullName;
        public string Course;
        public string University;
        public string Email; 
        public string PhoneNumber;
        public static int Level;


        public Student()
        {

        }

        //Question2
        public Student(string name,string phoneNumber) 
        {
            FullName = name;
            PhoneNumber = phoneNumber;
        }
        public Student (string course,string university,string email)
        {
            Course = course;
            University = university;
            Email = email;
        }
        public Student(string name, string course, string university, string email, string phoneNumber)
        {

            FullName = name;
            PhoneNumber = phoneNumber;
            Course = course;
            University = university;
            Email = email;
        }
        
        //Question 3
        //Question4
        public void PrintInfo (Student student)
        {
            Console.WriteLine(student.FullName);
            Console.WriteLine(student.Course);
            Console.WriteLine(student.University);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.PhoneNumber);
        }
        
        
    }


    public class Student1
    {
        //Question5
        private string FullName;
        private string Course;
        private string University;
        private string Email;
        private int    PhoneNumber;

        public void SetName(string name)
        {
            FullName = name;
        }
        public string GetName()
        {
            return FullName;
        }

        public void SetCourse (string course)
        {
            Course = course;
        }
        public string GetCourse ()
        {
            return Course;
        }

        public void SetUniverse (string university)
        {
            University = university;
        }
        public string GetUniverse ()
        {
            return University;
        }

        public void SetEmail (string email)
        {
            Email = email;
        }
        public string GetEmail ()
        {
            return Email;
        }
        public void SetPhone (int  phone)
        {
            PhoneNumber = phone;
        }
        public int GetPhone ()
        {
            return PhoneNumber;
        }
        //question6

        Student what  =new Student("Ade","science","Unilag","ade@gmail.com","09087564734");
        Student what1 =new Student("Ade","science","Unilag","ade@gmail.com","09087564734");
        Student what2 =new Student("Ade","science","Unilag","ade@gmail.com","09087564734");
        Student what3 =new Student("Ade","science","Unilag","ade@gmail.com","09087564734");
    }

    //Question7
    public  class StudenTest
    {
        
    }



    //Question8 and 9,10,11,12,13,14
    public class GSM:logs
    {
        public string Model;
        public string Manufacturer;
        public int   Price;
        public string Owner;
        private string Colour;
        private static string Nokia95;
        


        public  GSM (string nokia,string num):base(num)
        {
            Nokia95 = nokia;
        }

        public string AddCall (logs obj)
        {
            return AddCall(obj);
        }


        public string DeleteCall (logs obj)
        {
            return DeleteCall(obj);
        }


        public static string Getinfo()
        {
            return Nokia95;
        }
        public override string  ToString()
        {
            return Price + Owner;
        }

        public  void CoInfo (string colour)
        {
            Colour = colour;
        }

        public  string CoGetinfo ()
        {
            return Colour;
        }


        public void PrintInfo()
        {
            string[] arr=new string[]{Owner,Model,Manufacturer,Price.ToString(),Colour};
            Getinfo();
        }


        public int PriceCall(int price)
        {
            return price *End.Second;
        }
        public void PriceCalls (int price)
        {
            int f = 0;
             f += PriceCall(price);
            Console.WriteLine(f);
        }




        public GSM(string model, string manufacturer, int price, string owner,string num):base(num)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
        }
    }


    public class Battery
    {
        public int    Model;
        public int    Idle;
        public string Time;
        public int    Hours;
        public string Talk;
        private string Colour;
        public void ColInfo (string colour)
        {
            Colour = colour;
        }

        public string ColGetinfo ()
        {
            return Colour;
        }



        public Battery(int model, int idle, string time, int hours, string talk)
        {
            Model = model;
            Idle = idle;
            Time = time;
            Hours = hours;
            Talk = talk;
        }
    }


    public class Display
    {
        public int Size;
        public string Colors;
        private string Text;
        public Display(int size, string colors)
        {
            Size = size;
            Colors = colors; 
        }
        public void TeInfo (string text)
        {
            Text = text;
        }

        public string TeGetinfo ()
        {
            return Text;
        }
    }


    public enum BatteryType
    {
        Lechlanche,
        Nickelion,
    }

    //Question 15
    public class logs
    {
        public string number { get; set; }
        public DateTime Date { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public logs(string num)
        {
            number = num;

            Date = DateTime.Now;
            Begin = DateTime.UtcNow;
            End = DateTime.UtcNow;
        }
        public string  List()
        {
            string a = $"{number}   {Date} {Begin} {End}";
            return a;
        }
    }


    public class Call<T> where T : logs
    {
        
        public string Listlogs(T obj)
        {
            return (obj.List());
        }


    }


    public class lisTcall
    {
        public static void Enlist()
        {
            logs log=new logs("09876");
            Call<logs> s=new Call<logs>();
            Console.WriteLine(s.Listlogs(log));
        }


    }
    
    //Question 20
    public class Libarary:Book
    {
        public const string Name="LIb";
        public  static List<Book> books=new List<Book>();


        public Libarary(string author,string title):base(title,author)
        {
            
            Author = author;
            Title = title;
            ISBN = GetISBN();
        }
        public void AddBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Libarary b=new Libarary(author,title);
            string f = b.ISBN;
            books.Add(b);
            Console.WriteLine($"The book ISBN is {f}");

        }

        public static void ListBooks()
        {
            if (books.Count==0)
            {
                Console.WriteLine("No book is not available");
                
            }
            else
            {
                foreach (var b in books)
                {
                    if (books.Contains(b))
                    {
                        Console.WriteLine($"The book name is {b.Title}  and the author is {b.Author}.The book ISBN is {b.ISBN} the book was relesed at{b.TimeReleased} ");
                    }
                }
            }
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book ISBN: ");
            string isbn = Console.ReadLine();
            foreach (var b in books)
            {
                if (b.ISBN==isbn && b.Author==author)
                {
                    books.Remove(b);
                    break;
                }
            }
            Console.WriteLine("The book has been removed successfully");
        }
    }


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime TimeReleased { get; set; }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = GetISBN();
            TimeReleased = DateTime.UtcNow;

        }


        public string GetISBN()
        {
            Random random = new Random();
            string r = random.Next(123456789).ToString();
            return r;
        }


        //Question 21
        public class TestClass
        {
            public static void Test()
            {
                Libarary b = new Libarary("g", "h");
                b.AddBook();
                b.RemoveBook();
                Libarary.ListBooks();

            }
        }


        //Question 22
        public class School
        {
            public const string NameOfSchool = "Legacy";
            public const string Address      = "1,qqq street";

        }


        public class SchoolClass
        {
            public string Grade1 { get; set; }
            public string Grade2 { get; set; }
            public string Grade3 { get; set; }
            public string Grade4 { get; set; }
            public string Grade5 { get; set; }
            public string Grade6 { get; set; }


            public void GradeOneClass()
            {
                List<string> iGrade1s = new List<string>();

                foreach (var teacher in Teachers.teachers)
                {
                    if (teacher.Level == Grade1)
                    {

                        iGrade1s.Add($"{teacher.Name}    {teacher.Age}");
                    }
                }

                foreach (var disciple in Disciples.disciples)
                {
                    if (disciple.Level == Grade1)
                    {

                        iGrade1s.Add($"{disciple.Name}    {disciple.Age}");
                    }
                }

                foreach (var studentse in Students.stud)
                {
                    if (studentse.Level == Grade1)
                    {

                        iGrade1s.Add($"{studentse.Name}    {studentse.Age}");
                    }
                }
            }


            public void GradtwoClass()
            {
                List<string> grade2 = new List<string>();

                foreach (var teacher in Teachers.teachers)
                {
                    if (teacher.Level == Grade2)
                    {

                        grade2.Add($"{teacher.Name}    {teacher.Age}   {teacher.TeachersId}");
                    }
                }

                foreach (var disciple in Disciples.disciples)
                {
                    if (disciple.Level == Grade2)
                    {

                        grade2.Add($"{disciple.Name}    {disciple.Age}   {disciple.DicipleId}");
                    }
                }

                foreach (var studentse in Students.stud)
                {
                    if (studentse.Level == Grade2)
                    {
                        grade2.Add($"{studentse.Name}    {studentse.Age}");
                    }
                }

                foreach (var person in grade2)
                {
                    Console.WriteLine(person);
                }
            }

        }


        public class Students
        {
            public static List<Students> stud = new List<Students>();
            public string Name { get; set; }
            public string Level { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }


            public Students(string name, string address, int age, string level)
            {
                Name = name;
                Address = address;
                Age = age;
                levels(level);


            }


            public string levels(string level)
            {
                Level = level;
                return Level;
            }


            public static void RegisterStudents()
            {

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your Address: ");
                string address = Console.ReadLine();
                Console.Write("Enter your Age");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter level: ");
                string level = Console.ReadLine();
                Students s = new Students(name, address, age, level);
                s.levels(level);
                stud.Add(s);
                Console.WriteLine("Welcome");
            }


            public static void ListStudents()
            {

                foreach (var f in stud)
                {
                    Console.WriteLine($"Name: {f.Name}    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}  ");
                }
            }



        }


        public class Teachers : Students
        {
            public static List<Teachers> teachers = new List<Teachers>();
            public string TeachersId { get; set; }


            public Teachers(string name, string address, int age, string level) : base(name, address, age, level)
            {
                TeachersId = Teacherid();
                Name = name;
                Address = address;
                Age = age;
                Levels(level);
            }


            public string Teacherid()
            {
                Random random = new Random();
                string id = random.Next(1, 100).ToString();
                return id;

            }


            public string Levels(string level)
            {
                Level = level;
                return Level;
            }


            public static void RegisterTeachers()
            {

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your Address: ");
                string address = Console.ReadLine();
                Console.Write("Enter your Age");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter your  class : ");
                string level = Console.ReadLine();
                Teachers s = new Teachers(name, address, age, level);
                s.Levels(level);
                string a = s.Teacherid();
                teachers.Add(s);
                Console.WriteLine($"Welcome your Id is {a}");
            }


            public static void ListTeachers()
            {
                foreach (var f in teachers)
                {
                    Console.WriteLine($"Name: {f.Name}    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}    Id:{f.TeachersId}");
                }
            }



        }


        public class Disciples : Students
        {
            public static List<Disciples> disciples = new List<Disciples>();
            public string DicipleId { get; set; }


            public Disciples(string name, string address, int age, string level) : base(name, address, age, level)
            {
                Name = name;
                Address = address;
                Age = age;
                DicipleId = Discipleid();
                Levels1(level);
            }


            public string Discipleid()
            {
                Random random = new Random();
                string id = random.Next(100, 200).ToString();
                return id;

            }


            public string Levels1(string level)
            {
                Level = level;
                return Level;
            }


            public static void RegisterDisciples()
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your Address: ");
                string address = Console.ReadLine();
                Console.Write("Enter your Age");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter your  class : ");
                string level = Console.ReadLine();
                Disciples d = new Disciples(name, address, age, level);
                d.Levels1(level);
                string a = d.Discipleid();
                disciples.Add(d);
                Console.WriteLine($"Welcome your Id is {a}");
            }


            public static void ListDisciples()
            {
                foreach (var f in disciples)
                {
                    Console.WriteLine($"Name: {f.Name}    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}    Id:{f.DicipleId}");
                }
            }
        }


        public class TestSchool
        {
            public static void Test()
            {
                Disciples.RegisterDisciples();
                Teachers.RegisterTeachers();
                Students.RegisterStudents();
                Disciples.ListDisciples();
                Teachers.ListTeachers();
                Students.ListStudents();
            }
        }


        //Question 24
        public class Items<T> where T : Property
        { }



        public class Property
        {
            public string Cloth { get; set; }
            public string Shoe { get; set; }
            public string Drink { get; set; }
            public string pencil { get; set; }



            public Property(string cloth, string shoe, string drink, string pencils)
            {
                Cloth = cloth;
                Shoe = shoe;
                Drink = drink;
                pencil = pencils;
            }


        }


        //Question 25
        public class Fraction
        {
            public float Numerator { get; set; }
            public float Denominator { get; set; }


            public Fraction(float numerator, float denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }


            public string Decimal()
            {
                string a = "";
                for (int i = 0; i < Numerator/2 && i < Denominator/2; i++)
                {
                    if (i % Numerator == 0 && i % Denominator == 0)
                    {
                        a= $"{Numerator}/{Denominator}";
                        break;
                    }
                }

                return a;
            }


            public float Division()
            {
                return Numerator / Denominator;
            }
            public string Numbers ()
            {
                return $"{Numerator} /{Denominator}";
            }


        }





    }
}  


