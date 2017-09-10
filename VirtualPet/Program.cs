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
            //VirtualPet class
            //Fields (at least three)
            //Properties(at least three)
            //Methods(at least three)
            //Constructors(at least one)
            //Program class
            //Main method
            //Interactive user interface (see example at bottom of page)
            //Display current status of pet
            //Display options for interacting with pet
            //Ask user what action to take
            //User's selection should trigger an action
            //First, decide what "features" you want to incorporate. 
            //You might be tempted to make this a long list - start small! Think MVP!

            //Next, design a class for the pet.
            //Think of what properties/methods you will need to have for your MVP. 
            //Methods might involve things that happen when a person interacts with the pet.

            //Some ideas for things that a virtual pet should have
            //(along with some ideas for activities that might address them):
            //Hunger (Feed it)
            //Thirst(Water it)
            //Waste(Let it out to the bathroom)
            //Boredom(Play with it)
            //Sickness(Take it to the doctor)

            //Your methods should cause the appropriate properties to update
            //for instance, if you have a Feed() method, it might make Hunger go down, but make Thirst go up.

            //If you play with the pet, perhaps that makes it more tired.Have fun with this part!

            //Also, remember that more features != better.Pick a focus for your pet. Maybe go with a theme.

            //Once you've designed the class, it's time to think about the user interface. 
            //We're using a Console interface for now, 
            //so it will likely involve some sort of loop and a menu showing possible actions, 
            //as well as indicating the state of the pet. 
            //Your user interface should live in the Main method of the Program class. 
            //You should also have a VirtualPet class in a separate file.

            TeacupPig tidbits = new TeacupPig("Pineapple Tidbits");

            Console.WriteLine("Hello. I'm " + tidbits.Name + ", and I'm a Teacup Pig. \nI'm your friend and companion, but I also need your love and attention \nto grow and thrive. I'll need food, water, sleep, playtime, and every once \nin awhile I have to go outside to do my business. If you ever want to know \nhow I'm doing, simply ask, 'How are you?'");
            Console.WriteLine("I'll be completely happy when all my needs are met. \nThat means that all my needs should be a 10 or more \nand I don't have to go outside.");
            tidbits.TidbitsNeeds();
            Console.WriteLine("If you need help taking care of Tidbits, please enter 'Help'.");
            while (tidbits.FeedMe > 0)
            {
                string feedTidbits = "1";
                string waterTidbits = "2";
                string playWithTidbits = "3";
                string letNap = "4";
                string letTidbitsOut = "5";
                string doNothing = "6";
                string askStatus = "How are you";
                string askHelp = "help";
                string quit = "I don't have time for this.";
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
                else if (tidbits.FeedMe >= 10 && tidbits.PlayTime >= 10 && tidbits.NapTime >= 10 && tidbits.WaterMe >= 10 && tidbits.GoOutside == "no")
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
                else
                {
                    Console.WriteLine("Tidbits needs his space sometimes, too.  Just don't forget about him.");
                }
            }
        }
    }
}
