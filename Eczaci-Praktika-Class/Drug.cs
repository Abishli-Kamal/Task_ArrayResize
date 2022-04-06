using System;
using System.Collections.Generic;
using System.Text;

namespace Eczaci_Praktika_Class
{
    internal class Drug
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public TypeDrug Type { get; set; } 
        public int Price { get; set; }
        public int Count { get; set; }

        public static int nums=0;

        public Drug()
        {
            nums++;
            ID = nums;

        }

        public override string ToString()
        {
            return $"Id:{ID}    Name:{Name}   Count:{Count} Price:{Price}";
        }


    }
}
