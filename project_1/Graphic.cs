using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Graphic{
    private static List<Shape> shList;

    public static void graphicInput(List<Shape> shapeList) {
        shList = shapeList;
    }

    public static void graphicInfo() {
        Console.WriteLine("The list of shapes");
        foreach (Shape sp in shList)
        {
            sp.showInfo();
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
}