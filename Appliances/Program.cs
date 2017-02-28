using System;
using System.Linq;
using Appliances.Appliance;

namespace Appliances
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var electricDevices = new ElecricDevicesInHouse();

            var lamp = new ElectricDevice("Lamp", 10, 30, 220);
            var monitor = new ElectricDevice("Monitor", 20, 20, 220);
            var pc = new ElectricDevice("PC", 40, 15, 220);
            var note = new ElectricDevice("Note", 30, 10, 400);
            var phone = new ElectricDevice("Phone", 12, 100, 400);
            var lamp1 = new ElectricDevice("Lamp1", 17, 95, 220);

            electricDevices.Add(lamp);
            electricDevices.Add(monitor);
            electricDevices.Add(pc);
            electricDevices.Add(note);
            electricDevices.Add(phone);
            electricDevices.Add(lamp1);

            lamp.Display();
            monitor.Display();
            pc.Display();
            lamp.Online();
            lamp.Display();
            monitor.Online();
            monitor.Display();
            pc.Online();
            pc.Display();
            lamp.Offline();
            lamp.Display();

            electricDevices.SortByPower();

            foreach (var item in electricDevices.ElectricDevices)
                item.Display();

            Console.WriteLine("//////////////////\n         Power\n");

            var filter =
                electricDevices.ElectricDevices.Where(
                    electricDevice => electricDevice.Power >= 20 && electricDevice.Power < 90);

            foreach (var item in filter)
                item.Display();

            Console.WriteLine("///////////////////////////\n      Voltage\n");

            filter = electricDevices.ElectricDevices.Where(electricDevice => electricDevice.Voltage == 220);

            foreach (var item in filter)
                item.Display();

            electricDevices.SaveToXml(Environment.CurrentDirectory + "\\XMLDevices.xml");
            Console.WriteLine("Save Done");
            electricDevices.LoadFromXml(Environment.CurrentDirectory + "\\XMLDevices.xml");
            Console.WriteLine("Load Done");

            Console.ReadLine();
        }
    }
}