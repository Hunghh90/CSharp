using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session1
{
    internal class Fraction
    {
       public int Tuso { get; set; } 
       public int Mauso { get; set; } 

       public Fraction (int Tuso, int Mauso)
        { this.Tuso = Tuso;
        this.Mauso = Mauso;
        }

        public void InPhanSo()
        {
            Console.WriteLine(Tuso + "/" + Mauso);
        }
        public void NghichDao()
        {
            int temp = Tuso;
            Tuso = Mauso;
            Mauso = temp;
            InPhanSo();
        }
        public void RutGon()
        {
           
        }
    }
}
