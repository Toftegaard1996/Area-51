using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Floor
    {

        public static string[] floor = new string[] { "Lounge", "B1", "B2", "B3" };
        //Have a turrent
        public Turret Turrent;
        //Have a scanner
        public Scanner Scanner;
        //Have a control panel
        public ControlPanel ControlPanel;
        //Have an elevator

        public Floor()
        {
            Turrent = new Turret();
            Scanner = new Scanner();
            Elevator Elevator = new Elevator();
            ControlPanel = new ControlPanel(Scanner, Turrent, Elevator);
        }
        
    }
}
