using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InventoryPackTask.InventoryClass;

namespace InventoryPackTask
{
    
    internal class PackClass
    {

        public class Package
        {
            
            private int _maxweight;
            private int _maxvolume;
            private int _maxquantity;
            private readonly List<InventoryItems> _items = new();
           


            public int itemCount { get; private set; }
            public double currentWeight { get; private set; }
            public double currentVolume { get; private set; }

            public int Maxweight
            {
                get => _maxweight;
                private init => _maxweight = value is >= 1 and <= 10 ? value : throw new ArgumentException("The weight must be between 1 and 10");
            }
            public int Maxvolume
            {
                get => _maxvolume;
                private init => _maxvolume = value is >= 1 and <= 12 ? value : throw new ArgumentException("The volume must be between 1 and 12 characters");
            }
            public int Maxquantity
            {
                get => _maxquantity;
                private init => _maxquantity = value is >= 1 and <= 10 ? value : throw new ArgumentException("The quantity must be between 1 and 10 characters");
            }


            public Package(int userInputWeight, int userInputVolume, int userInputQuantity)

            {
                Maxweight = userInputWeight;
                Maxvolume = userInputVolume;
                Maxquantity = userInputQuantity;


            }
            public void PackInfo()
            {
                Console.WriteLine("Your package weight is {0}, volume is {1}, quantity is {2}", _maxweight, _maxvolume, _maxquantity);
            }
            public void ReportInfo()
            {
                Console.WriteLine($"Your package weight is {currentWeight.ToString(CultureInfo.InvariantCulture)}, volume is {currentVolume.ToString(CultureInfo.InvariantCulture)}, quantity is {itemCount}");
            }
            public void AddItem(InventoryItems item)
            {
                if (itemCount >= Maxquantity || currentWeight >= Maxweight || currentVolume >= Maxvolume)
                { 
                    throw new Exception("The package is full");

                }
                string stringItem = item.ToString().ToLower();
                if (stringItem != "reports")
                {
                    _items.Add(item);
                }
               
                itemCount = _items.Count;
                
                switch (stringItem)
                {
                    case "arrow":
                        Arrow arrow = new Arrow();
                        currentWeight += arrow.Weight;
                        currentVolume += arrow.Volume;
                        
                        break;
                    case "bow":
                        Bow bow = new Bow();
                        currentWeight += bow.Weight;
                        currentVolume += bow.Volume;
                        
                        break;
                    case "rope":
                        Rope rope = new Rope(1, 1.5);
                        currentWeight += rope.Weight;
                        currentVolume += rope.Volume;
                        
                        break;
                    case "water":
                        Water water = new Water();
                        currentWeight += water.Weight;
                        currentVolume += water.Volume;
                       
                        break;
                    case "food":
                        Food food = new Food();
                        currentWeight += food.Weight;
                        currentVolume += food.Volume;
                       
                        break;
                    case "sword":
                        Sword sword = new Sword();
                        currentWeight += sword.Weight;
                        currentVolume += sword.Volume;
                        
                        break;
                    case "reports":
                        ReportInfo();
                        break;
                       
                }
                if (stringItem != "reports")
                { Console.WriteLine($"You have successfully added {stringItem} in your Package"); }
               
                
                



            }

        }

      
        

    }
}
