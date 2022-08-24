using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Scanner
    {
        //Recieve LevelOfClearence from person
        //Check if LevelOfClearence allows chosen floor
        public Boolean AllowSpawnFloor(Staff staff)
        {
            if (staff.SecurityLevel != 0)
            {
                if (staff.SecurityLevel > staff.SpawnFloor)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public Boolean AllowObjectiveFloor( Staff staff)
        {
            if (staff.SecurityLevel > staff.ObjectiveFloor)
            {
                return true;
            }
            return false;
         
        }
    }
}
