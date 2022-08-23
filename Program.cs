using System;
using System.Collections.Generic;
using Area_51.Classes;

namespace Area_51
{
    class Program
    {
        public static void Main(string[] args)
        {
            Floors lounge = new Floors();
            Floors B1 = new Floors();
            Floors B2 = new Floors();
            Floors B3 = new Floors();

            List<Floors> Building = new List<Floors>() { lounge, B1, B2, B3 };


            for (int i = 0; i < 21; i++)
            {
                Staff Person = new Staff();
                Console.WriteLine("Velkommen til person nr " + i);
                Person.Spawn(Building);
                Console.ReadLine();
            }
        }
    }
}
