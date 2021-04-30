using System;

namespace DelegateExplain
{
    class Program
    {
        public delegate void SomeMethodPtr();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SomeMethodPtr obj = new SomeMethodPtr(SomeMethod);
            obj.Invoke();

            Myclass myClssobj = new Myclass();
            myClssobj.LongRunning(CallBackMethod);

            Program programClassObj = new Program();
            programClassObj.CallingA1andA2(programClassObj.A1); //call back function...
            programClassObj.CallingA1andA2(programClassObj.A2); //call back function...
        }

        public static void SomeMethod()
        {
            System.Console.WriteLine("Some Method called sucessfully...");
        }

        public class Myclass
        {
            public delegate void CallBack(int i);

            public void LongRunning(CallBack obj)
            {
                for (int i = 1; i <= 10000; i++)
                {
                    obj(i);
                }
            }
        }

        public static void CallBackMethod(int i)
        {
            System.Console.WriteLine(i);
        }

        public void A1()
        {
            System.Console.WriteLine("You are in A1...");
        }
        
        public void A2()
        {
            System.Console.WriteLine("You are in A2...");
        }

        public void CallingA1andA2(SomeMethodPtr ptr)
        {
            ptr.Invoke();
        }

    }
}
