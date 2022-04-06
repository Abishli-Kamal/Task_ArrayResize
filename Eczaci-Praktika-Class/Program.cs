using System;

namespace Eczaci_Praktika_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            drug.Name = "Nimesil";
            drug.Count = 5;
            drug.Price = 3;






            Pharmacy pharmacy = new Pharmacy();
            Console.WriteLine(pharmacy.AddDrug(drug));



            pharmacy.SaleDrug("Nimesil", 5, 3);
            pharmacy.SaleDrug("Nimesil", 4, 2);


        }
    }
}
