using System;

public class CoffeeBeans:Ingredient {
    
    private string [] types = {"Thuong", "Cao Cap"};
    private string type;
    
    public string beanType {
        get {return this.type;}
    }
    public CoffeeBeans() {}
    public CoffeeBeans(string ingredientName, double basePrice, int choose): base(ingredientName, basePrice) {
        switch(choose) {
            case 1:
                type = types[0];
                break;
            case 2:
                type = types[1];
                break;
            default:
                Console.WriteLine("invalid number so the default type is: " + types[0]);
                type = types[0];
                return;
        }
    }
    public override void ingredient_Input()
    {
        base.ingredient_Input();
        chooseCoffeeType();     
    }
    public void chooseCoffeeType() {
        Console.WriteLine("Choose the type of the Coffee Beans in number: 1." + this.types[0] + " or 2." + this.types[1]);
        int choose = Convert.ToInt32(Console.ReadLine());
        switch(choose) {
            case 1:
                type = types[0];
                break;
            case 2:
                type = types[1];
                break;
            default:
                Console.WriteLine("invalid number so the default type is: " + types[0]);
                type = types[0];
                return;
        }
    }
    public void ingredient_Input(string ingredientName, double basePrice, double extraFee) {
        base.ingredient_Input(ingredientName, basePrice);
    }

    public override void ingredient_Info()
    {
        base.ingredient_Info();
        calculate_IngredientPrice();
        Console.WriteLine("Price: " + this.tPrice +" VND");
    }


    public override void calculate_IngredientPrice() {
        if(type == types[0]) extra = 2;
        else extra = 5;

        tPrice = (bPrice + extra)*1000; //ra don vi nghin` VND
    }
}