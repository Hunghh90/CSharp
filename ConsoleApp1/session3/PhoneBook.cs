using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.session3;

namespace ConsoleApp1.session3
{
    public class PhoneBook : Phone
    {
        public PhoneBook() 
        {
            PhoneList = new List<PhoneNumber>();
        }
        public List<PhoneNumber> PhoneList { get; }
        public override void InsertPhone(string name, string phone)
        {
            foreach(PhoneNumber pl in PhoneList)
            {
                if(pl.Name.Equals(name)) 
                {
                    if(pl.Phone.Contains(phone)) 
                    {
                        return;
                    }
                    pl.Phone.Add(phone);
                    return;
                }
            }
            PhoneNumber pn = new PhoneNumber(name, phone);
            PhoneList.Add(pn);
        }

        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber pl in PhoneList)
            {
               if( pl.Name.Equals(name))
                {
                    PhoneList.Remove(pl);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach(PhoneNumber pl in PhoneList)
            {
                if (pl.Name.Equals(name))
                {
                    
                    return pl;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((o1, o2) =>
            {
                return o1.Name.CompareTo(o2.Name);
            });
        }

        public override void UpdatePhone(string name, string oldphone, string newphone)
        {
            foreach (PhoneNumber pl in PhoneList)
            {
                if (pl.Name.Equals(name) && pl.Phone.Contains(oldphone))
                {
                    pl.Phone.Remove(oldphone);
                    pl.Phone.Add(newphone);
                    return;
                }
            }
        }
    }
}
