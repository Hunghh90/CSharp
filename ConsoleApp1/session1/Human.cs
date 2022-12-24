using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session1
{
    internal class Human
    {
        public string name;
        public int age;

        public static int number;
        internal Human()
        { 
        }
        public Human(string s)
        {
            this.name = s;
        }

        public int Id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age ;
            set => age = value;
        }

        public string Email { get; set; }
        internal void Run()
        {
            Console.WriteLine("Running...");
        }
        public void Run(string s)
        {

        }
        public static void Screen()
        { 
        }
        public virtual void Eat() //virtual: cho phép kế thừa, sealed: khong cho phép kế thừa
        {

        }
    }
}
