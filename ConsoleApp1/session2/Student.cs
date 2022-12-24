using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.session1;

namespace ConsoleApp1.session2
{
    internal class Student : Human
    {
        private string[] telephone = new string[3];
        internal Student()
        {
        }
        public Student(string s,int a): base(s)
        {
            this.age= a;
        }
        public void Study()  //base: dùng của lớp cha, this: dùng của lớp chính nó
        {
            base.Run();
            this.Run();
        }
        public new void Run()
        {

        }
        public override void Eat() // override: kế thừa
        {
            
        }
        public string this[int index] //indexer
        {
            get => telephone[index];
            set=> telephone[index] = value; 
        }
    }
}
