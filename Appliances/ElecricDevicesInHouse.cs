using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Appliances.Appliance;

namespace Appliances
{
    public class ElecricDevicesInHouse
    {
        public List<ElectricDevice> ElectricDevices { get; } = new List<ElectricDevice>();

        public void Add(ElectricDevice item)
        {
            ElectricDevices.Add(item);
        }

        public void SortByPower()
        {
            ElectricDevices.Sort();
        }

        public void SaveToXml(string fullFileName)
        {
            var formatter = new XmlSerializer(typeof(List<ElectricDevice>));

            using (var fs = new FileStream(fullFileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ElectricDevices);
            }
        }

        public void LoadFromXml(string fullFileName)
        {
            var formatter = new XmlSerializer(typeof(List<ElectricDevice>));

            using (var fs = new FileStream(fullFileName, FileMode.OpenOrCreate))
            {
                var readDevices = (List<ElectricDevice>) formatter.Deserialize(fs);

                foreach (var p in readDevices)
                    Console.WriteLine("Имя: {0} --- Мощность: {1} --- Напряжение: {2}", p.Name, p.Power, p.Voltage);
            }
        }

        public void LoadFromXml(FileStream stream)
        {
            var formatter = new XmlSerializer(typeof(List<ElectricDevice>));

            using (stream)
            {
                var readDevices = (List<ElectricDevice>) formatter.Deserialize(stream);

                foreach (var p in readDevices)
                    Console.WriteLine("Имя: {0} --- Мощность: {1} --- Напряжение: {2}", p.Name, p.Power, p.Voltage);
            }
        }
    }
}