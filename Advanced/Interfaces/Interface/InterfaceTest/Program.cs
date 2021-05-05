using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main()
        {
            ImplementInterfaces Ab = new ImplementInterfaces();
            // Ab.show();
            // Ab.Test();

            InterfaceTwo I2 = Ab;
            InterfaceOne I1 = Ab;

            I1.Test();
            I2.Test();
            I2.show();

            // I2.show();
            
        }
    }
}
