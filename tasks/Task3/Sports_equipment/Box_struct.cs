using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Sports_equipment
{
    public struct Box : IPrint
    {
        private double _length;
        private double _height;
        
        // Implementing the Proerties for the struct
        public double Lenght
        {
            get { return _length; }
            set { _length = value;  }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value;  }
        }
    
        // Constructor of the struct Box
        public Box (double newLength, double newHeight)
        {
            _length = newLength;
            _height = newHeight;
        }
       
        public void printItem()
        {
            Console.WriteLine($"Box - Struct - lenght: {Lenght}");
            Console.WriteLine($"Box - Struct - height: {Height}");
        }
    }
    
   
}