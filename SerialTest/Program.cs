using System;
using System.IO.Ports;

namespace SerialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serial ports available:");
            Console.WriteLine("-----------------------");
            foreach (var portName in SerialPort.GetPortNames())
            {
                Console.WriteLine(portName);
            }
            Console.ReadLine();
        }
    }
}
