using System;
using System.Collections.Generic;

namespace project_2_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CaPheSua a = new CaPheSua(new Columbia(50));
            // a.coffee_Info();
            // a.recipe();
            CaPheDen b = new CaPheDen();
            BacXiu x = new BacXiu();


            // Bill bill1 = new Bill();
            // bill1.billInput();
            // bill1.billInfo();
            Bill bill2 = new Bill();
            CaPheSua c = new CaPheSua();
            CaPheDen d = new CaPheDen(new Columbia(30));
            BacXiu e = new BacXiu();
            bill2.add(c, d, e);

            CoffeeStore.drinksRecipe();
            CoffeeStore.orderCoffee();
            // CoffeeStore.add_Bill(bill2);
            // CoffeeStore.info();

            // CoffeeStore.info();

            // CoffeeStore.drinksRecipe();


        }
    }
}
