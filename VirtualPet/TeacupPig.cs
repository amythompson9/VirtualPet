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
        private bool goOutside;
        private string name;

        public int FeedMe
        {
            get { return this.feedMe; }
        }
        public int PlayTime
        {
            get { return this.playTime; }
        }
        public int NapTime
        {
            get { return this.napTime; }
        }
        public int WaterMe
        {
            get { return this.waterMe; }
        }
        public bool GoOutside
        {
            get { return this.goOutside; }
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
            this.name = name;
        }
        public TeacupPig(string name)
        {
            this.feedMe = 10;
            this.playTime = 10;
            this.napTime = 10;
            this.waterMe = 10;
            this.goOutside = true;
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
            }
            else
            {
                Console.WriteLine("I'm starving. What's for dinner?");
            }
        }

        public void Bored()
        {
            if (this.playTime > 8)
            {
                Console.WriteLine("I don't feel like playing. I think I could use a nap.");
                napTime -= 3;
            }
            else
            {
                Console.WriteLine("I'm bored. Let's play!");
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
            }
        }
    }
}
