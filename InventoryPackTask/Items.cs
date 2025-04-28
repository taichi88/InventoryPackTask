using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InventoryPackTask.PackClass;


namespace InventoryPackTask
{
//es aris swori gza rom shevmqna klasi gadavce inheritansi da base klass gadavce parametrebi

    class Arrow : InventoryClass 
    {
        public Arrow() : base(0.1, 0.05)
        {
             
            
        }
    }

    class Bow : InventoryClass
    { 
    public Bow() : base(1, 4)
        {
            
        }
    }
    // es aris custom midgoma da am shemtxvevashi parametrebs vuwert ushualod klasis obieqtis inicializaciisas

    class Rope(double weight, double volume) : InventoryClass(weight, volume);
    class Water() : InventoryClass(2, 3);
    class Food() : InventoryClass(1, 0.5);
    class Sword() : InventoryClass(5, 3);

}
