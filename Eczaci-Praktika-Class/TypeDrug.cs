using System;
using System.Collections.Generic;
using System.Text;

namespace Eczaci_Praktika_Class
{
    internal class TypeDrug
    {
        public TypeDrug DrugProp { get; set; }

        public string  Typename { get { return Typename; } }
        public int ID;
        public static int num=0;

        public TypeDrug()
        {
            num++;
            ID = num;
        }
        public override string ToString()
        {
            return $"TypeName:{Typename}";
        }

    }
}
