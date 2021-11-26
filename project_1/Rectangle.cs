using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle:Shape {
    private double lenght;
    private double width;

    private double area;
    public Rectangle():base() {}
    public Rectangle(Point pt1, Point pt2, double recLenght, double recWidth) :base(pt1, pt2) { 
        this.lenght = recLenght;
        this.width = recWidth;
        this.name = "Rectangle";
    }
    public Rectangle(Point pt1, Point pt2, string shapeColor, double recLenght, double recWidth) :base(pt1, pt2, shapeColor) { 
        this.lenght = recLenght;
        this.width = recWidth;
        this.name = "Rectangle";
    }

    ~ Rectangle() {}

    public override void getInput() {
        this.name = "Rectangle";
        base.getInput();
        Console.Write("Value of lenght:");
        this.lenght = Convert.ToDouble(Console.ReadLine());
        Console.Write("Value of width:");
        this.width = Convert.ToDouble(Console.ReadLine());
    }
    public void getInput(Point pt1, Point pt2, double recLenght, double recWidth) {
        this.name = "Rectangle";
        base.getInput(pt1, pt2);
        this.lenght = recLenght;
        this.width = recWidth;
    }
    public void getInput(Point pt1, Point pt2, string shapeColor, double recLenght, double recWidth) {
        this.name = "Rectangle";
        base.getInput(pt1, pt2, shapeColor);
        this.lenght = recLenght;
        this.width = recWidth;
    }


    public override void showInfo() {
        base.showInfo();
        Console.WriteLine("Lenght: " + this.lenght + " and width: " + this.width);
        Console.WriteLine("The Area of the Rectangle:" + this.area);
        this.draw();
    }

    public override void calculate() {
        this.area = (this.lenght * this.width);
    }
}