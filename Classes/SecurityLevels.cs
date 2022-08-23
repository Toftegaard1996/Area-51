using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class SecurityLevels
    {
        public static Random rnd = new Random();
        public int SecurityLevel = rnd.Next(0, 6);

        public static void LevelOfClearence(int SecurityLevel)
        {
            switch (SecurityLevel) 
            {
                case 0:
                    Console.WriteLine("Ucertificerede! Indtrængende! Dø!");
                    //KillWorker();
                    //Ingen adgang
                    //KillRequest
                    break;
                case 1:
                    //KillRequest undtagen ved Lounge
                    //Lounge
                    Console.WriteLine("Du har adgang til " + Floors.floor[0]);
                    break;
                case 2:
                    //Lounge+B1
                    Console.WriteLine("Du har adgang til " + Floors.floor[0] + " og " + Floors.floor[1]);
                    break;
                case 3:
                    //Lounge+B1+B2
                    Console.WriteLine("Du har adgang til " + Floors.floor[0] + ", " + Floors.floor[1] + " og " + Floors.floor[2]);
                    break;
                case 4:
                    //Lounge+B1+B2+B3
                    Console.WriteLine("Du har adgang til " + Floors.floor[0] + ", " + Floors.floor[1] + ", " + Floors.floor[2] + " og " + Floors.floor[3]);
                    break;
                case 5:
                    //VIP elevator
                    Console.WriteLine("Du har adgang til "+ Floors.floor[0] + ", " + Floors.floor[1] + ", " + Floors.floor[2] + " og " + Floors.floor[3]);
                    //ChooseElevator
                    break;
            }
        }
    }
}
