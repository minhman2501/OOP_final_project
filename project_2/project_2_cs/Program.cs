using System;
using System.Collections.Generic;

namespace project_2_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CaPheSua a = new CaPheSua(new Columbia(50));
            CaPheDen b = new CaPheDen();
            BacXiu x = new BacXiu();


            Bill bill1 = new Bill();
            bill1.add(a, b, x);

            Bill bill2 = new Bill();
            CaPheSua c = new CaPheSua();
            CaPheDen d = new CaPheDen(new Columbia(30));
            BacXiu e = new BacXiu();
            bill2.add(c, d, e);

            CoffeeStore.add_Bill(bill1, bill2);

            // CoffeeStore.info();

            CoffeeStore.drinksRecipe();


        }
    }
}
