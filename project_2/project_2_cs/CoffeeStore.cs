using System;
using System.Collections.Generic;

public static class CoffeeStore {
    private static double total;
    private static List<Bill> bList = new List<Bill>();

    private static List<Coffee> cList = new List<Coffee>();

    public static void add_Bill(params Bill[] bills) {

        foreach (var bill in bills)
        {
            bList.Add(bill);
        }
    }
    private static void add_Drinks(params Coffee[] drinks) {
        foreach (var drink in drinks)
        {
            cList.Add(drink);
        }
    }
    public static void info() {
        Console.WriteLine("Coffee Store INFO");
        Console.WriteLine("*************************");

        for (int i = 0; i < bList.Count; i++)
        {
            Console.WriteLine("Bill #" + (i+1) + ":\n");
            bList[i].billInfo();
            total += bList[i].totalPrice;
            Console.WriteLine("______________\n");
        }

        Console.WriteLine("Total Income: " + total + "VND");
    }
    public static void drinksRecipe() {
        Console.WriteLine("DRINKS RECIPES:");
        Console.WriteLine("**************");
        add_Drinks(new CaPheDen(), new CaPheSua(), new BacXiu());
        foreach (var drink in cList) {
            drink.recipe();
            Console.WriteLine("_____________");
        }

    }
}