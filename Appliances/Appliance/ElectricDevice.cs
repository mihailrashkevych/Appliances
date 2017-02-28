using System;

namespace Appliances.Appliance
{
    [Serializable]
    public class ElectricDevice : Device, IComparable<ElectricDevice>
    {
        public static int OnlinePow;
        private int _power;
        private int _voltage;

        public ElectricDevice()
        {
        }

        public ElectricDevice(string name, int weight, int power, int voltage) : base(name, weight)
        {
            Power = power;
            Voltage = voltage;
        }

        public int Power
        {
            get { return _power; }
            set
            {
                _power = value;
                OnPropertyChanged();
            }
        }

        public int Voltage
        {
            get { return _voltage; }
            set
            {
                _voltage = value;
                OnPropertyChanged();
            }
        }

        public int CompareTo(ElectricDevice other)
        {
            return other == null ? 1 : Power.CompareTo(other.Power);
        }

        public void Online()
        {
            OnlinePow += Power;
        }

        public void Offline()
        {
            OnlinePow -= Power;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return Name + "--> Power" + Power + "  Online " + OnlinePow;
        }
    }
}