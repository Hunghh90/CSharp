using ConsoleApp1.session1;
using ConsoleApp1.session2;

public class Program
{ static void Main(String[] args)
    {
        Human h = new Human();
        h.Run();


        Student s = new Student();
        s[0] = "0123456";
        s[1] = "5641223";


        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world");
        ls.Add("morning");

        for(int i = 0;i<ls.Count;i++) 
        {
            Console.WriteLine(ls[i]); 
        }

        foreach(string l in ls)
        {
            Console.WriteLine(l);   
        }

        Fraction fraction = new Fraction(5, 8);
        fraction.InPhanSo();
        fraction.NghichDao();
        
    }
}