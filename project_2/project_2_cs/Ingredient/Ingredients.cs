using System;

public abstract class Ingredient {
    protected string name;

    protected string unit;
    
    protected double amount;
    public string ingredient_BrandName {
        get {return this.name;}
        set {this.name = value;}
    }
    ~Ingredient() {}

    public Ingredient(string ingredient_BrandName, double ingredient_Amount, string ingredient_Unit) {
        this.name = ingredient_BrandName;
        this.amount = ingredient_Amount;
        this.unit = ingredient_Unit;
    }
    public virtual void ingredient_Info() {
        Console.WriteLine("Name:" + this.name);
    }
    public void adding() {
        Console.WriteLine(this.type() + ": " + this.amount + this.unit);
    }

    protected abstract string type();
}