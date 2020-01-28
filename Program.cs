using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class927
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer;
            myComputer = new Computer();
            myComputer.name = "my computer";
            myComputer.memory = 64;

            myComputer.meabed = new Meabed();
            myComputer.meabed.name = "i5";
            myComputer.meabed.speed = 60;
            myComputer.sapak = new Sapak();
            
            myComputer.sapak.name = "my sapak";
            myComputer.sapak.volt = 4;

            print(myComputer);            
        }

        static void print(Computer Coputer)
        {
            Console.WriteLine("the model is " + Coputer.name);
            print(Coputer.meabed);
            print(Coputer.sapak);
        }
        static void print(Meabed meabed)
        {
            Console.WriteLine("my computer proccessor is " + meabed.name + " it has " + meabed.speed + " speed");
        }
        static void print(Sapak sapak)
        {
            Console.WriteLine("the sapak of my computer is " + sapak.name);
        }
    }
    class Sapak
    {
        public string name;
        public int volt;
    }
    class Meabed
    {
        public string name;
        public int speed;
    }
    class Computer
    {
        public string name;
        public int memory;
        public Meabed meabed;
        public Sapak sapak;
    }
}
