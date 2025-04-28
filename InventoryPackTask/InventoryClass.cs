using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryPackTask
{
    public class InventoryClass
    {
        public double _volume;
        public double _weight;


        public double Volume
        { get => _volume;
            private set => _volume = value is >= 0 ? value : throw new ArgumentException("The volume must be greater than 0 ");
        }
        public double Weight
        {
            get => _weight;
            private set => _weight = value is >= 0 ? value : throw new ArgumentException("The weight must be greater than 0 ");
        }

        public InventoryClass(double weight, double volume)
        {
            Volume = volume;
            Weight = weight;
            

        }
          
        internal enum InventoryItems
        {
            Arrow = 1,
            Bow,
            Rope,
            Water,
            Food,
            Sword,
            Reports
        }
    }
}
