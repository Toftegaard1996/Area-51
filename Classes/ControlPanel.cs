using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class ControlPanel
    {
        Scanner Scanner;
        Turret Turrent;
        Elevator Elevator;
        public ControlPanel(Scanner scanner, Turret turrent, Elevator elevator)
        {
            Scanner = scanner;
            Turrent = turrent;
            Elevator = elevator;
        }
        public void CallElevator(Staff staff)
        {
            //If Allowfloor is true, request elevator
            if (Scanner.AllowSpawnFloor(staff) == true)
            {
                Console.WriteLine("Congrats, you can now call the elevator, press to continue");
                Elevator.MoveToSpawnFloor(staff);
            }
            else 
            {
                //If it's not, send kill request
                Turrent.KillRequest(staff); 
            }
        }
        public void ExitElevator(Staff staff)
        {
            //If Allowfloor is true, request elevator
            if (Scanner.AllowObjectiveFloor(staff) == true)
            {
                Console.WriteLine("You are allowed on this floor, please proceed with your work!");
            }
            else
            {
                //If it's not, send kill request
                Turrent.KillRequest(staff);
            }
        }
    }
}
