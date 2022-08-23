using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Scanner
    {
        //Recieve LevelOfClearence from person
        //Check if LevelOfClearence allows chosen floor
        public Boolean AllowSpawnFloor(SecurityLevels ThisSecurityLevel, Staff staff)
        {
            if (ThisSecurityLevel.SecurityLevel != 0)
            {
                if (ThisSecurityLevel.SecurityLevel <= staff.SpawnFloor)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public Boolean AllowObjectiveFloor(SecurityLevels ThisSecurityLevel, Staff staff)
        {
            if (ThisSecurityLevel.SecurityLevel >= staff.ObjectiveFloor)
            {
                return true;
            }
            return false;
         
        }
    }
}
