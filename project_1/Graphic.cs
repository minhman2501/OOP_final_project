using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Graphic{
    private static List<Shape> shList = new List<Shape>();
    private static int amount;
    private static int item;

    public static void add_Shape(params Shape[] shapes) {
        foreach (var shape in shapes)
        {
            shList.Add(shape);
        }
    }
    public static void graphicInput() {
        Console.WriteLine("How many shape you want to creat:");
        amount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Choose your shape: \n1.Circle\t 2.Triangle\t 3.Line \t 4.Rectangle");
            item = Convert.ToInt32(Console.ReadLine());
            switch (item) {
                case 1:
                    Circle cr = new Circle();
                    cr.getInput();
                    break;
                case 2:
                    Triangle tr = new Triangle();
                    tr.getInput();
                    break;
                case 3:
                    Line ln = new Line();
                    ln.getInput();
                    break;
                case 4:
                    Rectangle rec = new Rectangle();
                    rec.getInput();
                    break;
            }
            Console.WriteLine("\n________________");
        }
    }

    public static void graphicInfo() {
        Console.WriteLine("All of the shape details");
        foreach (Shape sp in shList)
        {
            sp.showInfo();
            Console.WriteLine("_________________\n");
        }
    }
    public static void changeColor__AllShape() {
        Console.WriteLine("Which color do you want to change into:");
        string color = Console.ReadLine();
        foreach (var shape in shList)
        {
            shape.colorShape = color;
        }
    }
    public static void changeColor__EachShape() {
        Console.WriteLine("Change color for each shape in the graphic...");
        foreach (var shape in shList)
        {
            shape.colorChange();
            Console.WriteLine("\n_________________");
        }
    }
    public static void remove_Shape() {
        Console.WriteLine("Remove the last shape in the graphic:");
        shList.Remove(shList.Last());
    }
}