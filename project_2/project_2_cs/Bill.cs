using System;
using System.Collections.Generic;

public class Bill {
    private double total = 0;
    private List<Coffee> cList = new List<Coffee>();

    public double totalPrice {
        get { return this.total;}
    }
    
    public void add(params Coffee[] coffees) {

        foreach (var cf in coffees)
        {
            this.cList.Add(cf);
        }
    }
    public void billInfo() {
        Console.WriteLine("BILL INFO");
        Console.WriteLine("*************************");

        foreach (var cof in cList)
        {
            cof.coffee_Info();
            total += cof.coffeePrice;
            Console.WriteLine("______________\n");
        }  
        Console.WriteLine("Total price: " + total + "VND");
    }
}