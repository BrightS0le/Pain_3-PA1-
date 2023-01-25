using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pain_3__PA1_
{
    class animal
    {
        public animal()
        {
            name = "none";
            age = 0;
            weight = 0;
            noise = "none";

        }
        public animal(string Na, int A, int W, string No)
        {
            name = Na;
            age = A;
            weight = W;
            noise = No;
        }
        public void printInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Noise: " + noise);
        }
        public void makeNoise()
        {
            Console.WriteLine("The noise this animal makes is: " + sound);
         //   System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\Cat.wav");
         // player.Play();
        }
        public void ageUP()
        {
            age++;
        }
        protected string name;
        protected int age;
        protected int weight;
        protected string noise;

    }
    class cat : animal
    {
        cat(string Na, int A, int W, string No, bool ta, string br, bool me)
        {
            name = Na;
            age = A;
            weight = W;
            noise = No;
            tail = ta;
            breed = br;
            menace = me;


            }

        public void printInfo()
        {
            this.printInfo();
        }
        private bool tail;
        private string breed;
        private bool menace;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal anim = new animal();
            anim.printInfo();
            Console.ReadKey();
            anim.makeNoise();
            cat Kohaku = new cat();
            cat.printInfo();w
            Console.ReadKey();
        }
    }

}
