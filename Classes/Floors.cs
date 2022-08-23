using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51.Classes
{
    public class Floors
    {

        public static string[] floor = new string[] { "Lounge", "B1", "B2", "B3" };
        //Have a turrent
        public Turrent Turrent = new Turrent();
        //Have a scanner
        public Scanner Scanner = new Scanner();
        //Have a control panel
        public ControlPanel ControlPanel = new ControlPanel();
    }
}
