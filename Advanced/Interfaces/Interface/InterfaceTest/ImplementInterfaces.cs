namespace InterfaceTest
{
    public class ImplementInterfaces : InterfaceOne, InterfaceTwo
    {
        public void show()
        {
            System.Console.WriteLine("Show method interface two..");
        }

        public void Test()
        {
            System.Console.WriteLine("Implemented Interface one here...");
        }

        void InterfaceTwo.Test()
        {
            System.Console.WriteLine("Implemented Interface Two here...");
        }

        // void InterfaceTwo.show()
        // {
        //     System.Console.WriteLine("class's show method...");
        // }
    
    }
}