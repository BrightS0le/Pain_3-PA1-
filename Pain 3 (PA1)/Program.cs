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
            Console.WriteLine("The noise this animal makes is: ");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\Cat_Sound.wav");
            player.Play();
        }
        public void ageUP()
        {
            age++;
        }
        private string name;
        private int age;
        private int weight;
        private string noise;

    }
    class Program
    {
        static void Main(string[] args)
        {
            animal anim = new animal();
            anim.printInfo();
            Console.ReadKey();
            anim.makeNoise();
            Console.ReadKey();
        }
    }

}
