using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab5
{
    public class Canon : printerWindows
    {
        public override void show()
        {
            Console.Write("Canon display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }

        public override void startprint()
        {
            Console.WriteLine("Canon printer printing ....");
        }
    }
}
