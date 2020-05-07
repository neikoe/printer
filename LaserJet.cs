using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab5
{
    public class LaserJet : printerWindows
    {
        public override void show()
        {
            Console.Write("Laserjet display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }
        public override void startprint()
        {
            Console.WriteLine("LaserJet printer printing ....");
        }
    }
}
