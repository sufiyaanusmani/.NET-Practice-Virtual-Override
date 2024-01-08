using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {
        public string name;
        public int age;
        public bool isHungry;

        public Animal(string name, int age, bool isHungry = true)
        {
            this.name = name;
            this.age = age;
            this.isHungry = isHungry;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        public bool IsHungry
        {
            set { this.isHungry = value; }
            get { return this.isHungry; }
        }

        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine($"{name} is eating");
            }
            else
            {
                Console.WriteLine($"{name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{name} is playing");
        }
    }
}
