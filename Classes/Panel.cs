using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Panel
    {
        Elevator Elevator;
        public Panel(Elevator elevator)
        {
            Elevator = elevator;
        }
        public void RideElevator(Staff staff) 
        {
            Console.WriteLine("Input the desired destination");
            Console.ReadLine();
            Console.WriteLine("Your desired floor is " + staff.ObjectiveFloor);
            Elevator.MoveToObjectiveFloor(staff);
            Console.WriteLine("The elevator has arrived");
        }
    }
}
