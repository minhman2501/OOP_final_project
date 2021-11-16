using System;
using System.Collections.Generic;

public abstract class Coffee {
    protected double cPrice;
    
    protected string name ;
    public double coffeePrice {
        get { return this.cPrice;}
    }
    protected List<Ingredient> iList = new List<Ingredient>();

    public Coffee() {}
    
    public virtual void coffee_Input() {
        Console.Write("Enter the coffee price:");
        this.cPrice = Convert.ToDouble(Console.ReadLine());
        
    }
    public virtual void coffee_Info() {
        Console.WriteLine("Price is: " + this.cPrice.ToString() + "VND");
    }
    
    protected void addIngredients(Ingredient ing)
    {
        iList.Add(ing);
    }
    protected abstract void addDefault();
    protected void CalcPrice()
    {
        foreach(var ing in iList)
        {
            if (ing is CoffeeBeans)
            {
                CoffeeBeans bean = (CoffeeBeans)ing;
                cPrice += bean.price;
            }
        }
    }
    public virtual void recipe() {
        Console.WriteLine("The Recipe of " + name + ":");
        foreach(var ing in iList) {
            ing.adding();
        }
    }
}

public class CaPheSua: Coffee {


    public CaPheSua():base()
    {
        name = "Nau Da";
        this.addDefault();
        cPrice = 15000;
        this.CalcPrice();
    }
    protected override void addDefault(){
        this.addIngredients(new Robusta(20));
        this.addIngredients(new Milk(20));
    }
    public CaPheSua(params CoffeeBeans[] ingredients):base(){
        name = "Nau Da";
        foreach(var i in ingredients)
        {
            this.addIngredients(i);
        }
        this.addIngredients(new Milk(30));
        cPrice = 15000;
        this.CalcPrice();
    }
    public override void coffee_Info() {
        Console.WriteLine("Name: "+ name);
        base.coffee_Info();
    }
    public override void recipe() {
        base.recipe();
    }
    
    
}
public class CaPheDen: Coffee {

    public CaPheDen():base()
    {
        name = "Den Da";
        this.addDefault();
        cPrice = 12000;
        this.CalcPrice();
    }
    protected override void addDefault(){
        this.addIngredients(new Robusta(30));
    }
    public CaPheDen(params CoffeeBeans[] ingredients):base(){
        name = "Den Da";
        foreach(var i in ingredients)
        {
            this.addIngredients(i);
        }
        cPrice = 12000;
        this.CalcPrice();
    }
    public override void coffee_Info() {
        
        Console.WriteLine("Name: "+ name);
        base.coffee_Info();
    }
    public override void recipe() {
        base.recipe();
    }
    
    
}
public class BacXiu: Coffee {

    public BacXiu():base()
    {
        name = "Bac Xiu";
        this.addDefault();
        cPrice = 18000;
        this.CalcPrice();
    }
    protected override void addDefault(){
        this.addIngredients(new Robusta(10));
        this.addIngredients(new Milk(40));
    }
    public BacXiu(params CoffeeBeans[] ingredients):base(){
        name = "Bac Xiu";
        foreach(var i in ingredients)
        {
            this.addIngredients(i);
        }
        cPrice = 18000;
        this.CalcPrice();
    }
    public override void coffee_Info() {
        
        Console.WriteLine("Name: "+ name);
        base.coffee_Info();
    }
    public override void recipe() {
        base.recipe();
    }
}

