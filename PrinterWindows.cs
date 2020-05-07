using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab5
{
    public class printerWindows
    {
        public string name { get; set; }
        public virtual void show()
        {
            Console.WriteLine("Input Error");
        }
        public virtual void startprint()
        {
            //Console.WriteLine("Input Error");
        }
    }
}
