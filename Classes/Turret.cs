using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Turret
    {
        //Receive kill command
        public void KillRequest(Staff staff)
        {
            Console.WriteLine("Inge Turretet skyder! Inge stopper aldrig >:D");
            while (staff.Health > 0)
            {
                Console.WriteLine("Bang");
                staff.Health-= 25;
            }
            Console.WriteLine("Hm, de prøvede at komme hen hvor de ikke måtte. Next in line!");

        }
    }
}
