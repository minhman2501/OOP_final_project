using System;

public class Milk:Ingredient {

    public Milk(string ingredientName, double basePrice, double extraFee): base(ingredientName, basePrice) {
        this.extra = extraFee;
    }
    public override void ingredient_Input()
    {
        base.ingredient_Input();
        Console.WriteLine("Enter the extra fee for the ingredient:");
        this.extra = Convert.ToDouble(Console.ReadLine());
    }

    public void ingredient_Input(string ingredientName, double basePrice, double extraFee) {
        base.ingredient_Input(ingredientName, basePrice);
        this.extra = extraFee;
    }

    public override void ingredient_Info()
    {
        base.ingredient_Info();
        calculate_IngredientPrice();
        Console.WriteLine("Price" + this.tPrice);
    }


    public override void calculate_IngredientPrice() {
        tPrice = (bPrice + extra)*1000; //ra don vi nghin` VND
    }
}