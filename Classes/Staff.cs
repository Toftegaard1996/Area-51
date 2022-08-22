using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Area_51.Classes
{
    class Staff
    {

        // Spawn Values
        public int SpawnFloors = 0;
        public int ObjectiveFloor = 0;

        // SpawnTime Values
        public static Random rnd = new Random();
        public int SpawnTimer = rnd.Next(1000, 2000);

        public void SpawnTime()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(Spawn);
            aTimer.Interval = SpawnTimer;
            aTimer.Enabled = true;
            aTimer.AutoReset = false;

        }

        public void Spawn(object source, ElapsedEventArgs e)
        {
            int Health = 100;
            Console.WriteLine("Liv: " + Health);
            //Spawn place (Random floor)
            SpawnFloors = rnd.Next(0, 4);
            string A = Floors.floor[SpawnFloors];
            Console.WriteLine(A);

            //Objective (Another random floor)
            ObjectiveFloor = rnd.Next(0, 4);
            string B = Floors.floor[ObjectiveFloor];
            while (A == B)
            {
                ObjectiveFloor = rnd.Next(0, 4);
                B = Floors.floor[ObjectiveFloor];
            }
            Console.WriteLine(B);

            //Assign LevelOfClearence
            SecurityLevels securityLevels = new SecurityLevels();
            int ThisSecurityLevel = securityLevels.SecurityLevel;
            SecurityLevels.LevelOfClearence(ThisSecurityLevel);
        }

        public void SwipeCard() 
        {
            //Use Scanner
            //Await fate
            //If not dead, use elevator
        }
    }
}
