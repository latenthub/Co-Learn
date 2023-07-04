using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutor.Animal
{
    public class Dog
    {
        private int legs;

        //Getter & Setter Method
        public int Leg
        {
            get { return legs; }
            set { legs = value * 2; }
        }
    }


    public class Goat
    {
        public Goat()
        {
            Dog dog = new();
            dog.Leg = 100;
            Console.WriteLine(dog.Leg);
        }
    }
}
