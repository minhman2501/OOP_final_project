using System;

public abstract class CoffeeBeans:Ingredient {
    
    protected int _price;

    public int price {
        get {
            return _price;
        }
    }
    public CoffeeBeans(double ingredient_Amount): base("",ingredient_Amount, "g") {
    }
}

public class Robusta:CoffeeBeans{
//SingleTon design pattern
    private string _type = "Robusta Bean";
    public Robusta(double ingredient_Amount): base(ingredient_Amount) {
        this._price = 3000;
        this.name = type();
    }
    protected override string type() {
        return _type;
    }
}

public class Columbia: CoffeeBeans {
    private string _type = "Columbia Bean";
    public Columbia(double ingredient_Amount): base(ingredient_Amount) {
        this._price = 5000;
        this.name = type();
    }
    protected override string type() {
        return _type;
    }
}