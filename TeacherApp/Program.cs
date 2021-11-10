using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace TeacherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrUsers = new Users[]
            {
              //new Users("Ajayi Oluwapamilerin","ajayipami1@gmail.com",07051865705,"SS2","pammy")
            };

            var arrStudents = new Students[]
            {
                //new Students("John Kehnde","ss2","Mathematics",25,60,75)
            };

        Start:
            Console.WriteLine("For Login press 1 for Registeration press 2");
            var input = Console.ReadLine();



            bool successfull = false;
            while (!successfull)
            {

                if (input == "1")
                {
                    Console.WriteLine("Write your email:");
                    var email = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();


                    foreach (Users user in arrUsers)
                    {
                        if (email == user.Email && password == user.Password)
                        {
                            Console.WriteLine("You have successfully logged in !!!");
                            Console.WriteLine("Enter Students Name: ");
                            var name = Console.ReadLine();
                            Console.WriteLine("Class: ");
                            var Class = Console.ReadLine();
                            Console.WriteLine("Subject: ");
                            var Subject = Console.ReadLine();
                            Console.WriteLine("Ca: ");
                            int Ca = int.Parse(Console.ReadLine());
                            Console.WriteLine("Exam: ");
                            int Exam = int.Parse(Console.ReadLine());
                            Console.WriteLine("Average: ");
                            int Average = int.Parse(Console.ReadLine());

                            Array.Resize(ref arrStudents, arrStudents.Length + 1);
                            arrStudents[arrStudents.Length - 1] = new Students(name, Class, Subject, Ca, Exam, Average);

                            if (Average >= 80)
                            {
                                Console.WriteLine("Very Good Student!!!");
                            }
                            else if(Average <80)
                            {
                                Console.WriteLine("not bad but put more effort!!!");
                            }
                        }
                    }

                    if (!successfull)
                    {
                        Console.WriteLine("Your email or password is incorect, try again !!!");
                        goto Start;
                    }

                }

                else if (input == "2")
                {

                    Console.WriteLine("Enter your Name:");
                    var Name = Console.ReadLine();

                    Console.WriteLine("Enter your Email:");
                    var Email = Console.ReadLine();

                    Console.WriteLine("Enter your Phone Number:");
                    long PhoneNumber = long.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your Class:");
                    string Class = (Console.ReadLine());

                    Console.WriteLine("Enter your Password:");
                    string Password = (Console.ReadLine());


                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(Name, Email, PhoneNumber, Class, Password);
                    successfull = true;
                    goto Start; 

                }
                else
                {
                    Console.WriteLine("Try again !!!");
                    break;


                }

            }

        }
    }

    public class Users
    {
        public string Name;
        public string Email;
        public string Password;
        public string Class;
        public long PhoneNumber;

        public Users(string Name, string Email, long PhoneNumber, string Class, string Password)
        {
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Class = Class;
            this.Password = Password;
        }
    }

    public class Students
    {
        public string Name;
        public string Class;
        public string Subject;
        public int Ca;
        public int Exam;
        public int Average;

        public Students(string name, string Class, string Subject, int Ca, int Exam, int Average)
        {
            this.Name = name;
            this.Class = Class;
            this.Subject = Subject;
            this.Ca = Ca;
            this.Exam = Exam;
            this.Average = Average;
        }
    }
}