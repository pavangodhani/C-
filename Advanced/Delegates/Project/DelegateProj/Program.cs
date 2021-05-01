using System;
using MulticastDelegate;

namespace DelegateProj
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Program
    {
        public void AddNum(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }

        static void Main(string[] args)
        {
            // Program P = new Program();
            // P.AddNum(10, 90);

            // string str = Program.SayHello("Pavan");
            // System.Console.WriteLine(str);

            // AddDelegate ad = new AddDelegate(P.AddNum);
            // // ad(100, 100);
            // ad.Invoke(100, 100);

            // SayDelegate sd = new SayDelegate(SayHello); //direct pass the method bcz it's a static method...
            // string str1 = sd("Marshal");
            // System.Console.WriteLine(str1);


            //Multicast Delegates...
            /*
            Rectangle Rect = new Rectangle();
            // Rect.GetArea(10, 20);
            // Rect.GetPerimeter(10, 20);

            // RectDelegate reactDelegateObj = new RectDelegate(Rect.GetArea);
            RectDelegate reactDelegateObj = Rect.GetArea;
            reactDelegateObj += Rect.GetPerimeter;

            reactDelegateObj.Invoke(10, 20);
            System.Console.WriteLine();
            reactDelegateObj.Invoke(100, 100); // we call once but it's invoke with both method which pointed by this delegate... 
            */


            //Anonymous Methods...
            /*
            AnonymousMethods obj = new AnonymousMethods();
            GreetingDelegate delObj = new GreetingDelegate(obj.Greetings);
            System.Console.WriteLine(delObj("pavan"));

            GreetingDelegate greetingDelegate = delegate(string name) //Anonymous Methods...
            {
                return $"Hello {name} this is Anonymous Method....A method with out a name....it's contains only body and method define by using 'delegate' keyword....and no need to declair specifiers, return type....use this type of method declaration when code volume is lesser....";
            };
            System.Console.WriteLine(greetingDelegate(" "));
            */


            //Lambda Expression...
            LambdaExpression lambdaObj = new LambdaExpression();
            GreetingDelegate greetingDel = new GreetingDelegate(lambdaObj.Greetings);
            System.Console.WriteLine(greetingDel("Marshal"));

            GreetingDelegate greetingDel1 = (name) => { return $"Hello, {name}...You called Lambda Expression"; };
            System.Console.WriteLine(greetingDel1("Marshal"));


        }
    }
}
