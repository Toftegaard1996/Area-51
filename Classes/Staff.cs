using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Staff
    {
        public Floor StaffFloor;
        // Spawn Values
        public int SpawnFloor = 0;
        public int ObjectiveFloor = 0;
        public int Health;

        // Random
        public static Random rnd = new Random();
        public Staff (List<Floor> floors)
	    {
            Health = RNG.Range(1, 101);
            Console.WriteLine("Liv: " + Health);
            SpawnFloor = rnd.Next(0, floors.Count);
            switch (SpawnFloor)
            {
                case 0:
                    Console.WriteLine("Du spawner på Lounge");
                    break;
                case 1:
                    Console.WriteLine("Du spawner på B1");
                    break;
                case 2:
                    Console.WriteLine("Du spawner på B2");
                    break;
                case 3:
                    Console.WriteLine("Du spawner på B3");
                    break;
            }
            StaffFloor = floors[SpawnFloor];

            //Objective (Another random floor)
            ObjectiveFloor = rnd.Next(0, floors.Count);
            while (SpawnFloor == ObjectiveFloor)
            {
                ObjectiveFloor = rnd.Next(0, floors.Count);
            }
            switch (ObjectiveFloor)
            {
                case 0:
                    Console.WriteLine("Du skal hen til Lounge");
                    break;
                case 1:
                    Console.WriteLine("Du skal hen til B1");
                    break;
                case 2:
                    Console.WriteLine("Du skal hen til B2");
                    break;
                case 3:
                    Console.WriteLine("Du skal hen til B3");
                    break;
            }
        }

        public int SecurityLevel = rnd.Next(0, 5);
        public void LevelOfClearence(int SecurityLevel)
        {
            switch (SecurityLevel)
            {
                case 0:
                    Console.WriteLine("Ucertificerede! Indtrængende! Dø!");
                    StaffFloor.Turrent.KillRequest(this);
                    break;
                case 1:
                    //KillRequest undtagen ved Lounge
                    //Lounge
                    Console.WriteLine("Du har adgang til " + Floor.floor[0]);
                    break;
                case 2:
                    //Lounge+B1
                    Console.WriteLine("Du har adgang til " + Floor.floor[0] + " og " + Floor.floor[1]);
                    break;
                case 3:
                    //Lounge+B1+B2
                    Console.WriteLine("Du har adgang til " + Floor.floor[0] + ", " + Floor.floor[1] + " og " + Floor.floor[2]);
                    break;
                case 4:
                    //Lounge+B1+B2+B3
                    Console.WriteLine("Du har adgang til " + Floor.floor[0] + ", " + Floor.floor[1] + ", " + Floor.floor[2] + " og " + Floor.floor[3]);
                    break;
            }
        }


        public void Spawn( List<Floor> Buildings)
        {
            //Assign LevelOfClearence
            int ThisSecurityLevel = SecurityLevel;
            LevelOfClearence(ThisSecurityLevel);
            Console.ReadLine();
        }

        public void SwipeCard() 
        {
            //Use Scanner
            Console.WriteLine("Medarbejder swiper sit kort");
            Console.WriteLine("Scanneren læser kortet");
            //Await fate
            Console.ReadLine();
            Console.WriteLine("Spændingen stiger");
            Console.ReadLine();
            //If not dead, use elevator
            StaffFloor.ControlPanel.CallElevator(this);
            StaffFloor.ControlPanel.ExitElevator(this);

        }
    }
}
