using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var sarah = new PlayerCharacter(new DiamondSkinDefence());
            sarah.Name = "Sarah";

            var amrit = new PlayerCharacter(new IronBornDefence())
            {
                Name = "Amrit"
            };

            var gentry = new PlayerCharacter(new NullDefence());
            gentry.Name = "Gentry";

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            
            #nullable enable
            string? test = null;
            string test1 = null;

            #nullable disable

            string test2 = null;
            System.Console.WriteLine(test);
        }
    }
}

