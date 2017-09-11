using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacupPig tidbits = new TeacupPig("Pineapple Tidbits");

            tidbits.Introduction();
            tidbits.HowToPlay();
            tidbits.TidbitsNeeds();
            Console.WriteLine("If you need help taking care of Tidbits, please enter 'Help'.");
            while (tidbits.FeedMe > 0 && tidbits.WaterMe > 0 && tidbits.PlayTime > 0 && tidbits.NapTime > 0)
            {
                string feedTidbits = "1";
                string waterTidbits = "2";
                string playWithTidbits = "3";
                string letNap = "4";
                string letTidbitsOut = "5";
                string doNothing = "6";
                string askStatus = "How are you";
                string askHelp = "help";
                string quit = "I don't have time for this";
                string doSomething = Console.ReadLine();
                if (askHelp.ToLower() == doSomething.ToLower())
                {
                    tidbits.TidbitsNeeds();
                }
                else if (askStatus.ToLower() == doSomething.ToLower())
                {
                    tidbits.Status();
                }
                else if (quit.ToLower() == doSomething.ToLower())
                {
                    tidbits.Quit();
                }
                else if (tidbits.FeedMe >= 50 && tidbits.PlayTime >= 50 && tidbits.NapTime >= 50 && tidbits.WaterMe >= 50 && tidbits.GoOutside == "no")
                {
                    tidbits.AllGood();
                }
                else if (feedTidbits == doSomething)
                {
                    Console.WriteLine("You fed Tidbits.");
                    tidbits.Hungry();
                }
                else if (waterTidbits == doSomething)
                {
                    Console.WriteLine("You gave Tidbits water.");
                    tidbits.Thirsty();
                }
                else if (playWithTidbits == doSomething)
                {
                    Console.WriteLine("You played with Tidbits.");
                    tidbits.Happiness();
                }
                else if (letNap == doSomething)
                {
                    Console.WriteLine("Tidbits is taking a nap.");
                    tidbits.Tired();
                }
                else if (letTidbitsOut == doSomething)
                {
                    Console.WriteLine("You took Tidbits outside.");
                    tidbits.Potty();
                }
                else if (doNothing == doSomething)
                {
                    Console.WriteLine("Are you sure Tidbits doesn't need anything?");
                    tidbits.Status();
                }
            }
            Console.WriteLine("It doesn't seem like you're ready for the responsibility of having a pet.");
        }
    }
}
