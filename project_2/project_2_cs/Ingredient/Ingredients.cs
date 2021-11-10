using System;

public abstract class Ingredient {
    protected double bPrice;
    protected string name;
    
    //De nhung class ke thua khong can phai khai bao
    protected double extra;
    
    //De nhung class ke thua khong can phai khai bao
    protected double tPrice;

    public string ingredientName {
        get {return this.name;}
        set {this.name = value;}
    }
    public double ingredient_BasePrice {
        get {return this.bPrice;}
        set {this.bPrice = value;}
    }

    public double ingredient_extraFee {
        get {return this.extra;}
        set {this.extra = value;}
    }
    public double TruePrice {
        get { return this.tPrice;}
    }

    public Ingredient() {}

    public Ingredient(string ingredientName, double basePrice) {
        this.name = ingredientName;
        this.bPrice = basePrice;
    }

    public virtual void ingredient_Input() {
        Console.Write("Enter the name of the ingredient: ");
        this.name = Console.ReadLine();
        Console.Write("Enter the base price of the ingredient: ");
        this.bPrice = Convert.ToDouble(Console.ReadLine());
    }

    public void ingredient_Input(string ingredientName, double basePrice) {
        this.name = ingredientName;
        this.bPrice = basePrice;
    }

    public virtual void ingredient_Info() {
        Console.WriteLine("Name:" + this.name);
    }
    ~Ingredient() {}


    public abstract void calculate_IngredientPrice();
}