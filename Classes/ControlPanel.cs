using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class ControlPanel
    {
        public void RequestElevator(Scanner scanner, SecurityLevels ThisSecurityLevel, Staff staff) 
        {
            //If Allowfloor is true, request elevator
            if (scanner.AllowSpawnFloor(ThisSecurityLevel, staff) == true)
            {
                Console.WriteLine("Congrats, you can now call the elevator, press to continue");
            }
            else 
            {
                //If it's not, send kill request
                Turrent turret = new Turrent();
                turret.KillRequest(staff); 
            }
        }
        public ControlPanel()
        {

        }
    }
}
