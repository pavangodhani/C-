// using System;

// namespace GameConsole
// {
//     class PlayerDisplayer
//     {
//         public static void Write(PlayerCharacter player)
//         {
//             System.Console.WriteLine(player.Name);

//             if(String.IsNullOrWhiteSpace(player.Name))
//                 System.Console.WriteLine("Name is null or empty");

//             // if (player.DaysScienceLastLogin.HasValue)
//             //     System.Console.WriteLine(player.DaysScienceLastLogin);
//             // else
//             //     System.Console.WriteLine("No Value for DaysScienceLastLogin");

//             // int days = player.DaysSinceLastLogin.GetValueOrDefault(-1); // its return -1 if dayssince will null otherwise return its Original Value 

//             // int days  = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1 ;

//             // int days = player.DaysSinceLastLogin ?? -1; //left side object and right side default value a

//             int days = player ?.DaysSinceLastLogin ?? -1;
//             System.Console.WriteLine(days);


//             if (player.DateOfBirth == null)
//             {
//                 System.Console.WriteLine("No date of birth specified");
//             }
//             else
//             {
//                 System.Console.WriteLine(player.DateOfBirth);
//             }

//             if (player.IsNoob == null)
//             {
//                 System.Console.WriteLine("Player status is unknown");
//             }
//             else if (player.IsNoob == true)
//             {
//                 System.Console.WriteLine("Player is a newbie");
//             }
//             else
//             {
//                 System.Console.WriteLine("Player is experienced");
//             }


//         }
//     }
// }