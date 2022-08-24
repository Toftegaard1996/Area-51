using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Elevator
    {
        Panel Panel;
        public Elevator()
        {
            Panel = new Panel(this);
        }

        public void MoveToSpawnFloor(Staff staff) 
        {
            Console.WriteLine("Elevator going to floor " + staff.SpawnFloor);
            for (int i = 5; i > staff.SpawnFloor; i--)
            {
                Console.WriteLine("Waiting for the elevator");
                Console.ReadLine();
            }
            Console.WriteLine("Elevator has arrived, please enter");
            Panel.RideElevator(staff);
        }

        public void MoveToObjectiveFloor(Staff staff) 
        {
            Console.WriteLine("Elevator going to floor " + staff.ObjectiveFloor);
            for (int i = 5; i > staff.SpawnFloor; i--)
            {
                Console.WriteLine("Waiting for the elevator");
                Console.ReadLine();
            }
        }
    }
}
