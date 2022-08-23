using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    class Elevator
    {
        public void MoveToSpawnFloor(Staff staff) 
        {
            Console.WriteLine("Elevator going to floor " + staff.SpawnFloor);
        }

        public void MoveToObjectiveFloor(Staff staff) 
        {
            Console.WriteLine("Elevator going to floor " + staff.ObjectiveFloor);
        }
        public Elevator()
        {

        }

    }
}
