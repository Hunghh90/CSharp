using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    public abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);

        public abstract void RemovePhone(String name);

        public abstract void UpdatePhone(String name,string oldphone, String newphone);

        public abstract PhoneNumber SearchPhone(String name);

        public abstract void Sort();
    }
}
