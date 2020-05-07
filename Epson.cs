using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab5
{
    public class Epson : printerWindows
    {
        public override void show()
        {
            Console.Write("Epson display dimension : ");
            string nomorPrinter = Console.ReadLine();
        }
        public override void startprint()
        {
            Console.WriteLine("Epson printer printing ....");
        }
    }
}
