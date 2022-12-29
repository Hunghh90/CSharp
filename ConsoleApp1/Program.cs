using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session3;
using ConsoleApp1.session4;

public class Program
{
    static void Main(string[] args)
    {
        Fetch();
        
    }

    static async void Fetch()
    {
        CallApi ca = new CallApi();
        Product s = await ca.FetchData();
        Console.WriteLine(s.ToString());

    }
    static void Main6(string[] args)
    {
        //Thread t1 = new Thread(ThreadRun);
        //Thread t2 = new Thread(ThreadRunParam);
        //Thread t3 = new Thread(ThreadRunParam);
        //t1.Start();
        //t2.Start("Hello");
        //t3.Start(1);
        Number num = new Number() { X =0, Y = 0 };
        Thread n1 = new Thread(ThreadLock);
        Thread n2 = new Thread(ThreadLock);
        n1.Start(num);
        n2.Start(num);
    }

    static void ThreadRun()
    {
        for(int i=0; i<10; i++) 
        {

            Console.WriteLine("i=" + i);
                try 
            { 
                Thread.Sleep(1000);
            }catch(Exception e)
            { 
            }
        }
    }
    static void ThreadRunParam(object msg)
    {
        for(int i=0; i<15; i++) 
        {

            Console.WriteLine("i=" + i + "Msg =" + msg);
                try 
            { 
                Thread.Sleep(1000);
            }catch(Exception e)
            { 
            }
        }
    }
    static void Main5(string[] args)
    {
        StringToVoid smgs = new StringToVoid(ShowMessage);
        StringToVoid smgs2 = new StringToVoid(DemoDelegate.SayHello);
        StringToVoid smgs3 = new StringToVoid(new DemoDelegate().ShowInfo);

        DemoEvent de = new DemoEvent();
        de.Invoke();
    }
    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static void ThreadLock(object obj)
    {
        Number n = (Number)obj;
        for(int i =0;i<20;i++)
        {
            lock (n) 
            {
                n.ChangeXY();
                n.PrintXY();
            }
           
            try
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }
    }

    
    

    
    static void Main4(String[] args) 
    { 
        PhoneBook pb = new PhoneBook();
        pb.InsertPhone("Hung", "0328473280");
        pb.InsertPhone("Hung1", "032813473280");
        pb.InsertPhone("Hung2", "032847232133280");
        pb.InsertPhone("Hung2", "0328472321332832330");
        foreach(PhoneNumber pl in pb.PhoneList)
        {
            Console.WriteLine(pl.ToString());
        }
    }
    static void Main2(String[] args)
    {
        try 
        {
            int x = 10;
            int y = 5;
            if(y == 0) 
            {
                throw new Exception("Y bang 0 mat roi");
            }else
            {
                float z = x / y;
                Console.WriteLine("z =" + z);
            }
            
           
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally 
        {

        }
    }
    static void Main3(String[] args)
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