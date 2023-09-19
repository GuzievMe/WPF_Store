using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6_Store
{
    internal class Product : INotifyPropertyChanged
    {
        public string Name { get { return Name;  }
            set { 
                Name = value;
                ISeePropChange();
                }
        }
        public double  Amount
        {
            get { return Amount; }
            set
            {
                Amount = value;
                ISeePropChange();
            }
        }
        public string Url
        {
            get { return Url; }
            set
            {
                Url = value;
                ISeePropChange();
            }
        }
        public int Size
        {
            get { return Size ; }
            set
            {
                Size  = value;
                ISeePropChange();
            }
        }
        public string Gender
        {
            get { return Gender ; }
            set
            {
                Gender  = value;  
                ISeePropChange();
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        public void ISeePropChange([CallerMemberName ] string name = null  )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    
}
