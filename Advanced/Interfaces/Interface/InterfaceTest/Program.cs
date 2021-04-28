using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main()
        {
            ImplementInterfaces Ab = new ImplementInterfaces();
            // Ab.show();
            Ab.Test();

            InterfaceTwo I2 = Ab;
            I2.Test();

            I2.show();
            
        }
    }
}
