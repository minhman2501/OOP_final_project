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
    public void billInput() {
        Console.WriteLine("How many drinks you want to order:");
        int amount = Convert.ToInt32(Console.ReadLine());
        int bean;
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Choose your drink: \n1.Den Da\t 2.Nau Da\t 3.Bac Xiu");
            int order = Convert.ToInt32(Console.ReadLine());
            switch (order) {
                case 1:
                    Console.WriteLine("CoffeBeans:\n 1.Robusta\t 2.Columbia");
                    bean = Convert.ToInt32(Console.ReadLine());
                    if (bean == 2) {
                        this.add(new CaPheDen(new Columbia(20)));
                    }
                    else this.add(new CaPheDen()); 
                    break;
                case 2:
                    Console.WriteLine("CoffeBeans:\n 1.Robusta\t 2.Columbia");
                    bean = Convert.ToInt32(Console.ReadLine());
                    if (bean == 2) {
                        this.add(new CaPheSua(new Columbia(20)));
                    }
                    else this.add(new CaPheSua()); 
                    break;
                case 3:
                    Console.WriteLine("CoffeBeans:\n 1.Robusta\t 2.Columbia");
                    bean = Convert.ToInt32(Console.ReadLine());
                    if (bean == 2) {
                        this.add(new BacXiu(new Columbia(10)));
                    }
                    else this.add(new BacXiu()); 
                    break;
            }
            Console.WriteLine("\n________________");



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