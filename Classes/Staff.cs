using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Staff
    {
        public Floors staffFloor = new Floors();
        public Staff (Floors Floor)
	    {
            staffFloor = Floor;
	    }
        public Staff()
        {

        }


        // Spawn Values
        public int SpawnFloor = 0;
        public int ObjectiveFloor = 0;
        public int Health = 100;

        // Random
        public static Random rnd = new Random();

        public void Spawn( List<Floors> Buildings)
        {
            Console.WriteLine("Liv: " + Health);
            //Spawn place (Random floor)
            SpawnFloor = rnd.Next(0, Buildings.Count);
            Console.WriteLine(SpawnFloor);

            //Objective (Another random floor)
            ObjectiveFloor = rnd.Next(0, Buildings.Count);
            while (SpawnFloor == ObjectiveFloor)
            {
                ObjectiveFloor = rnd.Next(0, Buildings.Count);
            }
            Console.WriteLine(ObjectiveFloor);
            SwipeCard();
        }

        public void SwipeCard() 
        {
            //Use Scanner
            Console.WriteLine("Medarbejder swiper sit kort");
            Console.WriteLine("Scanneren læser kortet");
            //Await fate
            Console.WriteLine("Spændingen stiger");
            //Assign LevelOfClearence
            SecurityLevels securityLevels = new SecurityLevels();
            int ThisSecurityLevel = securityLevels.SecurityLevel;
            SecurityLevels.LevelOfClearence(ThisSecurityLevel);
            //If not dead, use elevator
        }
    }
}
