using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk
{
    public class Intros
    {
        public void PlaneIsekaiIntro()
        {
            while (true)
            {
                Console.WriteLine("press E to experience the intro or press R to skip?");
                ConsoleKeyInfo ClickKey = Console.ReadKey(true);
                if (ClickKey.Key == ConsoleKey.R)
                {
                    Console.WriteLine("\nI mean... That's fine I worked really hard on it but ok ;^;");
                    break;
                }
                else if (ClickKey.Key == ConsoleKey.E)
                {
                    Console.WriteLine("You are sitting on a plane looking out the window.");
                    Console.ReadKey();

                    Console.WriteLine("\nIt's a sunny day, yesturday your partner proposed over videochat too excited to wait for you to get home from the buisness trip");
                    Console.Write("But the good news dosent end there! Today you finally got that promotion. You will get a raise and afford a fancy wedding. Life is perfect");
                    Console.ReadKey();

                    Console.WriteLine("\nAn excited man sits down next to you");
                    Console.WriteLine("\n'I JUST HAVE TO TELL SOMEBODY' the man said facing you 'I JUST DISCOVERED A CURE FOR CANCER!'");
                    Console.ReadKey();


                    Console.WriteLine("\nyour blood runs cold as the engine of the plane starts");
                    Console.ReadKey();

                    Console.WriteLine("\nYou have to get off, you have a good life YOU CAN'T DIE NOW!");
                    Console.ReadKey();

                    Console.WriteLine("\nbut it's to late, as you stand up ready to jump out of the plane you see a black car driving towards the plane.");
                    Console.Write("A masked man leans out the window takes out a rocket launcher and BANG!");
                    Console.ReadKey();

                    Console.WriteLine("\nDarkness....");
                    Console.ReadKey();

                    Console.WriteLine("\nWAKE UP WAKE UP WAKE UP WAKE UP");
                    Console.ReadKey();

                    Console.WriteLine("\nYou open your eyes and see an annoying looking girl slapping your face. 'if you dont get up right now you are going to die!'");
                    Console.Write("Please create your character");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou had one job dude");
                }
            }
        }
    }
}