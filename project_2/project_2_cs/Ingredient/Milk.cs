using System;

public class Milk:Ingredient {

    public Milk(double ingredient_Amount): base("Vinamilk", ingredient_Amount, "ml") {

    }

    public override void ingredient_Info()
    {
        base.ingredient_Info();
    }

    protected override string type(){
        return "Milk";
    } 
   
}