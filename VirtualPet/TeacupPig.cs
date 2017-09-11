using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class TeacupPig
    {
        private int feedMe;
        private int playTime;
        private int napTime;
        private int waterMe;
        private string goOutside;
        private string name;

        public int FeedMe
        {
            get { return this.feedMe; }
            set { this.feedMe = value; }
        }
        public int PlayTime
        {
            get { return this.playTime; }
            set { this.playTime = value; }
        }
        public int NapTime
        {
            get { return this.napTime; }
            set { this.napTime = value; }
        }
        public int WaterMe
        {
            get { return this.waterMe; }
            set { this.waterMe = value; }
        }
        public string GoOutside
        {
            get { return this.goOutside; }
            set { this.goOutside = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //public TeacupPig(string name)
        //{
        //    this.name = name;
        //}
        public TeacupPig(string name)
        {
            this.feedMe = 30;
            this.playTime = 4;
            this.napTime = 27;
            this.waterMe = 11;
            this.goOutside = "yes";
            this.name = "Pineapple Tidbits";
        }
        public void Hungry()
        {
            if (this.feedMe >= 50)
            {
                Console.WriteLine("I'm not hungry. What else is there to do?");
            }
            else if (this.feedMe > 45)
            {
                Console.WriteLine("I'm so full. I need something to drink.");
                feedMe += 2;
            }
            else
            {
                Console.WriteLine("I'm starving. What's for dinner?");
                feedMe += 15;
            }
        }

        public void Happiness()
        {
            if (this.playTime >= 50)
            {
                Console.WriteLine("We've already played so much today!");
            }
            else if (this.playTime < 45 && this.playTime > 40)
            {
                playTime += 2;
            }
            else
            {
                Console.WriteLine("That was so much fun. I'm tuckered out.");
                playTime += 12;
                napTime -= 15;
            }
        }

        public void Tired()
        {
            if (this.napTime >= 50)
            {
                Console.WriteLine("I've slept enough today!");
            }
            else if (this.napTime < 25)
            {
                Console.WriteLine("I think I need a nap.");
                napTime += 5; feedMe -= 10;
            }
            else
            {
                Console.WriteLine("That was a great nap. I think I could use a snack.");
                napTime += 10;
                feedMe -= 5;
                waterMe -= 3;
            }
        }
        public void Thirsty()
        {
            if (this.waterMe >= 50)
            {
                Console.WriteLine("I'm not too thirsty.");
            }
            else if (this.waterMe < 49 && this.waterMe > 30)
            {
                Console.WriteLine("Too much to drink, I should go outside.");
                waterMe += 5;
                playTime -= 8;
                goOutside = "yes";
            }
            else
            {
                Console.WriteLine("I'm thirsty!");
                waterMe += 12;
                goOutside = "no";
            }
        }
        public void Potty()
        {
            if (goOutside == "yes")
            {
                Console.WriteLine("Thanks, I feel better. Now let's play!");
                goOutside = "no";
            }
            else if (goOutside == "no")
            {
                Console.WriteLine("I have to go outside!");
                goOutside = "yes";
            }
            else
            {
                Console.WriteLine("Let's go play outside anyway.");
            }
        }
        public void Introduction()
        {
            Console.WriteLine("Hello. I'm Pineapple Tidbits, and I'm a Teacup Pig. \nI'm your friend and companion, but I also need your love and attention \nto grow and thrive. I'll need food, water, sleep, playtime, and every once \nin awhile I have to go outside to do my business. If you ever want to know \nhow I'm doing, simply ask, 'How are you'");
        }
        public void HowToPlay()
        {
            Console.WriteLine("I'll be completely happy when all my needs are met. \nThat means that all my needs should be a 50 or more \nand I don't have to go outside. \nIf you can no longer take care of Pineapple Tidbits, simpley enter, \n'I don't have time for this'.");
        }
        public void Status()
        {
            Console.WriteLine("Here is Pineapple Tidbit's status: \n{0} = Hunger \n{1} = Happiness \n{2} = Thirst \n{3} = Sleepiness \n{4}= Potty", feedMe, playTime, waterMe, napTime, goOutside);
        }
        public void TidbitsNeeds()
        {
            Console.WriteLine("So what should we do today? \n1. Feed Tidbits \n2. Water Tidbits \n3. Play with Tidbits \n4. Let Tidbits take a nap \n5. Take Tidbits outside \n6. Do Nothing");
        }
        public void AllGood()
        {
            Console.WriteLine("You're a great friend to Tidbits. He's very happy!...for now.");
        }
        public void Quit()
        {
            Console.WriteLine("A good friend of yours has adopted Tidbits and he has a great home now.");
        }
    }
}
