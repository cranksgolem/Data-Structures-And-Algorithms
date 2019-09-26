using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementations;
using System.ComponentModel;

namespace MExer05
{
    public static class HanoiStep
    {
        public static string PrintStep(Disk disk, Peg from, Peg to)
        {
            return "Move Disk " + disk.Number + " from " + from.Name + " to " + to.Name;
        }

        public static string PrintStep2(Disk disk, Peg from, Peg to)
        {
            return disk.Number + " " + from.Name + " "+ to.Name;
        }
    }

    public class Peg : INotifyPropertyChanged
    {
        private string _name;
        public int Index;
        public StackUsingLinkedList<Disk> PegStack = new StackUsingLinkedList<Disk>();

        public string Name
        {
            get { return _name; }
            set { _name = value;
            OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        public Peg()
        {

        }

        public Peg(string name)
        {
            Name = name;
        }

        public Peg(string name, int index)
        {
            Name = name;
            Index = index;
        }

        public override string ToString()
        {
            return Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, e);
            }
        }
    }

    public class Disk
    {
        public int Number;

        public Disk(int num)
        {
            Number = num;
        }
    }
}
