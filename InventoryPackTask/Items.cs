using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InventoryPackTask.PackClass;


namespace InventoryPackTask
{
     class Arrow : InventoryClass 
    {
        public Arrow() : base(0.1, 0.05)
        {
             
            
        }
    }
    
    class Bow() : InventoryClass(1, 4);
    class Rope() : InventoryClass(1, 1.5);
    class Water() : InventoryClass(2, 3);
    class Food() : InventoryClass(1, 0.5);
    class Sword() : InventoryClass(5, 3);

}
