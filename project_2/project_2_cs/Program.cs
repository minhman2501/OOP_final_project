using System;
using System.Collections.Generic;

namespace project_2_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk mk1 = new Milk("Vinamilk", 5, 4);
            CoffeeBeans cf1 = new CoffeeBeans("lmao", 5, 3);
            cf1.ingredient_Info();

        }
    }
}
