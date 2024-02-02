using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string printerName { get; set; }
        public string displayDimention { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("{0} display dimension: {1}", printerName, displayDimention);
        }

        public virtual void Print()
        {
            Console.WriteLine("{0} printer printing....", printerName);
        }
    }

    public class Epson : PrinterWindows
    {
        public Epson()
        {
            printerName = "Epson";
            displayDimention = "10*11";
        }
    }

    public class Canon : PrinterWindows
    {
        public Canon()
        {
            printerName = "Canon";
            displayDimention = "9.5*12";
        }
    }

    public class LaserJet : PrinterWindows
    {
        public LaserJet()
        {
            printerName = "LaserJet";
            displayDimention = "12*12";
        }
    }
}
