using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle:Shape {
    private double bEdge;
    private double height;
    private double area;

    public Triangle():base() {
        this.name = "Triangle";
    }
    public Triangle(Point pt1, Point pt2, double bottomEdge, double triHeight) :base(pt1, pt2) { 
        this.bEdge = bottomEdge;
        this.height = triHeight;
        this.name = "Triangle";
    }
    public Triangle(Point pt1, Point pt2, string shapeColor, double bottomEdge, double triHeight) :base(pt1, pt2, shapeColor) { 
        this.bEdge = bottomEdge;
        this.height = triHeight;
        this.name = "Triangle";
    }

    ~ Triangle() {}

    public override void getInput() {
        this.name = "Triangle";
        base.getInput();
        Console.Write("Bottom edge value:");
        this.bEdge = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height value:");
        this.height = Convert.ToDouble(Console.ReadLine());
    }
    public void getInput(Point pt1, Point pt2, double bottomEdge, double triHeight) {
        this.name = "Triangle";
        base.getInput(pt1, pt2);
        this.bEdge = bottomEdge;
        this.height = triHeight;
    }
    public void getInput(Point pt1, Point pt2, string shapeColor, double bottomEdge, double triHeight) {
        this.name = "Triangle";
        base.getInput(pt1, pt2, shapeColor);
        this.bEdge = bottomEdge;
        this.height = triHeight;
    }


    public override void showInfo() {
        base.showInfo();
        Console.WriteLine("Bottom edge: " + this.bEdge + " and height: " + this.height);
        Console.WriteLine("The Area of the Triangle:" + this.area);
        this.draw();
    }

    public override void calculate() {
        this.area = (this.bEdge * this.height)/2;
    }
}