using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OperatorOverLoading
{
    class Program
    {

        //public delegate bool FilterDelegate(Student student);


        







        static void PrintStudent(string title,List<Student> student ,Func<Student,bool> filter)
        {
            Console.WriteLine($"-----------{title}-----------");
            foreach (var stud in  student)
            {
                if (filter(stud))
                {
                    Console.WriteLine(stud);
                }
            }
        }


   




        static void Main(string[] args)
        {

            //List<Student> students = new List<Student>()
            //{
            //    new Student("Olu", "Ade", 15, Gender.Female),
            //    new Student("Ayo", "Lola", 14, Gender.Male),
            //    new Student("Ola", "Lade", 12, Gender.Female),
            //    new Student("Anu", "Obi", 16, Gender.Female),
            //    new Student("Ada", "Tim", 18, Gender.Male),
            //    new Student("Lola", "Obi", 16, Gender.Male),
            //    new Student("Ama", "Lot", 18, Gender.Male),
            //    new Student("Lara", "Say", 13, Gender.Female),
            //    new Student("Jane", "Man", 18, Gender.Male),
            //    new Student("Tom", "Obi", 14, Gender.Female),
            //};

            //foreach (var person in students)
            //{
            //    Console.WriteLine(person);
            //}

            //PrintBoys(students);
            //PrintAdults(students);
            //PrintStudent("Print All Students", students, FilterAll);



            //FilterDelegate FilterKid = delegate(Student student)
            //{
            //    return student.Age < 18;
            //};
            //PrintStudent("All kid", students, FilterKid);



            //FilterDelegate FilterA = delegate(Student student)
            //{
            //    return student.Name.StartsWith('A');
            //};
            //PrintStudent("All kid", students, FilterA);




            //FilterDelegate FilteEven = delegate(Student student)
            //{
            //    return student.Age % 2 == 0;
            //};
            //PrintStudent("All kid", students, FilteEven);




            //PrintStudent("All odd", students, delegate (Student student)
            // {
            //    return student.Age % 2 != 0;
            //});


            //FilterDelegate filterEven = (Student student) => student.Age % 2 == 0;

            //PrintStudent("All even", students, (Student student) => student.Age % 2 == 0);
            //PrintStudent("All even", students, student => student.Age % 2 == 0);
            //PrintStudent("All girls", students, student => student.Gender.Equals(Gender.Female));

            //Predicate<Student> FilterOddAges = delegate(Student student)
            //{
            //    return student.Age % 2 == 0;
            //};

            //Console.WriteLine(Doubler(5));
            //int a = students.RemoveAll(r => r.Age ==18);
            //PrintStudent("no 18", students, s => true);






            //Console.Write("Enter  first name: ");
            //string first = Console.ReadLine();
            //if (!ValidateFirst(first))
            //{
            //    Console.WriteLine("The first name should have more than five charcters");
            //}



            //Console.Write("Enter  last name: ");
            //string last = Console.ReadLine();
            //if (!ValidateSecond(last))
            //{
            //    Console.WriteLine("The  name should have more than five charcters");
            //}

            //Console.Write("Enter  first age: ");
            //int age =int.Parse(Console.ReadLine()) ;
            //if (!ValidateAge(age))
            //{
            //    Console.WriteLine("You are young");
            //}


            //Console.Write("1.Male.\n2.Female.\nEnter  Gender: ");
            //var gender = int.Parse(Console.ReadLine());
         
            //if (!ValidateGender(gender))
            //{
            //    Console.WriteLine("Gender not Specified");
            //}


            string FName;
            string LName = "";
            int age = 0;
            Gender gender = 0;


            bool continueForm = true;

            FName = GetUserInput("Enter your first name: \n", f => f.Length > 5, "First name must be greater than 5 letters", out continueForm);

            if (continueForm)LName= GetUserInput("Enter your last name: \n", f => f.Length > 5, "last name must be greater than 5 letters", out continueForm);

            if (continueForm)
                age = int.Parse(GetUserInput("Enter your age: \n",
                                              f => int.TryParse(f, out _) && int.Parse(f) >= 18,
                                              "Enter a valid age and age should not be less than 18",
                                              out continueForm) ?? "0");




            if (continueForm) gender = (Gender) int.Parse(GetUserInput("\t1.Male: \n\t2.Female: " , g => int.TryParse(g, out _) && int.Parse(g) <= 2, "Enter a valid value", out continueForm) ?? "0");



            Console.Clear();
            if (continueForm)
            {
                Student student=new Student(FName,LName,age,gender);
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("You have entered a wrong input");
            }















        }


        public static bool ValidateFirst(string name) => name.Length > 5;
        public static bool ValidateSecond (string Lname) => Lname.Length > 5;
        public static bool ValidateAge(int age) => age > 18;
        public static bool ValidateGender (int num) => num !=(int)Gender.Male || num != (int) Gender.Female;


        public static string GetUserInput(string message, Func<string, bool>validation, string errorMessage, out bool value,int numOfRetries = 1)
        {
            int retry = numOfRetries;
            while (retry > 0)
            {
                 Console.Write(message);
                 var input = Console.ReadLine();
                 if (validation(input))
                 {
                     value = true;
                     return input;
                 }
            }

            value = false;
            return null;
        }




        //LamDa;

        static int Doubler(int num) => num % 2 == 0 ? num * 2 : num * 3;









        static bool FilterAll(Student student)
        {
            return true;
        }

        static bool FilterBoys(Student student)
        {
            return student.Gender.Equals(Gender.Male);
        }


        static bool FilterGirls(Student student)
        {
            return student.Gender.Equals(Gender.Female);
        }


        static bool FilterAdults(Student student)
        {
            return student.Age >= 18;
        }



        public static void PrintBoys(List<Student> students)
        {
            Console.WriteLine("-----------Print Boys");
            foreach (var perStudent in students)
            {
                if (FilterBoys(perStudent))
                {
                    Console.WriteLine(perStudent);
                }
            }
        }


        public static void PrintAdults(List<Student> students)
        {
            Console.WriteLine("-----------Print Adults");
            foreach (var perStudent in students)
            {
                if (FilterAdults(perStudent))
                {
                    Console.WriteLine(perStudent);
                }
            }
        }
    }

}









    //public static void Hide()
        //{


        //    //Student st1 = new Student("Ade", 25);
        //    //Student st2=new Student("Ade",25);


        //    //Console.WriteLine(st1 == st2); 
        //    //Console.WriteLine(st1 < st2);
        //    //var st3 = st2 + st1;
        //    //Console.WriteLine($"Name: {st3.Name}   Score:{st3.Score} ");
        //}


       
    

