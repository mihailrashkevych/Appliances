using System.ComponentModel;
using System.Runtime.CompilerServices;
using Appliances.Annotations;

namespace Appliances.Appliance
{
    public abstract class Device : INotifyPropertyChanged
    {
        private string _name;
        private int _weight;

        public Device()
        {
        }

        public Device(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public override string ToString()
        {
            return Name + "  Weight: " + Weight;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}