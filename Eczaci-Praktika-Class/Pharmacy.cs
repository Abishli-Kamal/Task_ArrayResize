using System;
using System.Collections.Generic;
using System.Text;

namespace Eczaci_Praktika_Class
{
    internal class Pharmacy
    {
        public string Name { get; set; }
        public int ID { get; set; }

        Drug[] Drugs = new Drug[0];

        public override string ToString()
        {
            return $"ID:{ID}  Name:{Name}";
        }

        public Drug AddDrug(Drug dr)
        {
           
                Array.Resize(ref Drugs, Drugs.Length + 1);
                Drugs[Drugs.Length - 1] = dr;
                
            
            return dr;
        }

        public void DrugList(Drug drugs)
        {
            foreach (var item in Drugs)
            {
                Console.WriteLine($"Name:{item.Name}  Count:{item.Count}  Price:{item.Price} ID:{item.ID} Type:{item.Type}");
            }
        }

        public  void SaleDrug(string Name, int Count, double Money)
        {
            foreach (var item in Drugs)
            {
                if (item.Name == Name && item.Count ==Count && item.Price ==Money && Count > 0)
                {
                    item.Count--;
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Get Vizqirt Kasib");
                }
            }
           
           
        }
    }
}
