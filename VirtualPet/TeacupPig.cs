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
        public TeacupPig()
        {
            this.feedMe = feedMe;
            this.playTime = playTime;
            this.napTime = napTime;
            this.waterMe = waterMe;
            this.goOutside = goOutside;
        }
        public TeacupPig(string name)
        {
            this.feedMe = 3;
            this.playTime = 6;
            this.napTime = 9;
            this.waterMe = 7;
            this.goOutside = " ";
            this.name = "Pineapple Tidbits";
        }
        public void Hungry()
        {
            if (this.feedMe > 9)
            {
                Console.WriteLine("I'm so full. I think I need a nap.");
                napTime -= 2;
            }
            else if (this.feedMe >=5 && this.feedMe <=8)
            {
                Console.WriteLine("I could use a little snack");
                feedMe += 1;
            }
            else
            {
                Console.WriteLine("I'm starving. What's for dinner?");
                feedMe += 5;
            }
        }

        public void Happiness()
        {
            if (this.playTime > 8)
            {
                Console.WriteLine("I don't feel like playing. I think I could use a nap.");
                napTime -= 4;
            }
            else
            {
                Console.WriteLine("I'm bored. Let's play!");
                playTime += 4;
            }
        }

        public void Tired()
        {
            if (this.napTime < 5)
            {
                Console.WriteLine("I think I need a nap.");
            }
            else
            {
                Console.WriteLine("I'm not very tired.");
            }
        }
        public void Thirsty()
        {
            if (this.waterMe < 8)
            {
                Console.WriteLine("I could use a drink");
                waterMe += 3;
            }
            else
            {
                Console.WriteLine("I have to go outside.");
                goOutside = "yes";
            }
        }
        public void Potty()
        {
            if (goOutside == "no")
            {
                Console.WriteLine("No, let's play instead.");
                playTime -= 3;
            }
            else
            {
                Console.WriteLine("I have to go outside!");
            }
        }
        public void Status()
        {
            Console.WriteLine("Here is Pineapple Tidbit's status: \n{0} = Hunger \n{0} = Happiness \n{0} = Thirst \n{0} = Sleepiness \n{0}= Potty", feedMe, playTime, waterMe, napTime, goOutside);
        }
        public void TidbitsNeeds()
        {
            Console.WriteLine("So what should we do today? \n1. Feed Tidbits \n2. Water Tidbits \n3. Play with Tidbits \n4. Let Tidbits take a nap \n5. Take Tidbits outside \n6. Do Nothing");
        }
    }
}
