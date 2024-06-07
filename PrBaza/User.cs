using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrBaza
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private int age;
        public string Name { get => name; set {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            } }

        public int Age { get => age; set {
                if (age != value) {
                age = value;
                    OnPropertyChanged();
                }
            } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
