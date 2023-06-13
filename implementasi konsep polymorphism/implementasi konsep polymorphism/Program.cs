using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: 9.5x12");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing...");
        }
    }

    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension: 10x11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }

    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5x12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension: 12x12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
