using System;
using System.Collections.Generic;
using Area_51.Classes;

namespace Area_51
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Floor lounge = new Floor();
            Floor B1 = new Floor();
            Floor B2 = new Floor();
            Floor B3 = new Floor();

            List<Floor> Building = new List<Floor>() { lounge, B1, B2, B3 };


            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Velkommen til medarbejder nr " + i);
                Staff Person = new Staff(Building);
                Person.Spawn(Building);
                if (Person.Health > 0)
                {
                    Person.SwipeCard();
                    Console.ReadLine();

                }
            }
        }
    }
}
