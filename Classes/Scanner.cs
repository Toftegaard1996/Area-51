using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    class Scanner
    {
        //Recieve LevelOfClearence from person
        //Check if LevelOfClearence allows chosen floor
        public Boolean AllowFloor(SecurityLevels ThisSecurityLevel, Staff ObjectiveFloor, Staff SpawnFloor)
        {
            if (ThisSecurityLevel.SecurityLevel > SpawnFloor.SpawnFloors)
            {
                if (ThisSecurityLevel.SecurityLevel > ObjectiveFloor.ObjectiveFloor)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
