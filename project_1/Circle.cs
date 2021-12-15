using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Circle : Shape
{
    private double rad;
    private double area;
    public double CircleArea {
        get { return this.area;}
    }

    public Circle() :base()
    {
        this.name = "Circle";
    }
    public Circle(Point pt1, Point pt2, double circleRadius) :base(pt1, pt2) { 
        this.name = "Circle";
        this.rad = circleRadius;
    }
    public Circle(Point pt1, Point pt2, string shapeColor, double circleRadius) :base(pt1, pt2, shapeColor) { 
        this.name = "Circle";
        this.rad = circleRadius;
    }
    ~ Circle()
    {
    }
    public override void getInput()
    {
        this.name = "Circle";
        base.getInput();
        Console.WriteLine("Enter the Radius:");
        this.rad = Convert.ToDouble(Console.ReadLine());
    }
    public void getInput(Point pt1, Point pt2, double circleRadius) { 
        base.getInput(pt1, pt2);
        this.name = "Circle";
        this.rad = circleRadius;
    }
    public override void showInfo()
    {
        base.showInfo();
        Console.WriteLine("Area: " + Math.Round(this.area, 3));
        this.draw();
    }
    public override void calculate()
    {
        this.area = Math.Pow(rad, 2) * Math.PI;
    }
}