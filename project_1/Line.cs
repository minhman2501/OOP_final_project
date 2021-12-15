using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Line:Shape {
    private double length;
    public double line_Lenght {
        get {return this.length;}
    }
    public Line():base() {
        this.name = "Line";
    }
    public Line(Point pt1, Point pt2) :base(pt1, pt2) {
        this.name = "Line";
    }
    public Line(Point pt1, Point pt2, string shapeColor) :base(pt1, pt2, shapeColor) {
        this.name = "Line";
    }

    ~ Line() {}

    public override void getInput() {
        this.name = "Line";
        base.getInput();
    }
    public void getInput(Point pt1, Point pt2, string shapeColor) {
        this.name = "Line";
        base.getInput(pt1, pt2, shapeColor);
    }

    public override void showInfo() {
        base.showInfo();
        Console.WriteLine("Line lenght:" + this.length);
        this.draw();
    }

    public override void calculate() {
        this.length = Math.Sqrt(Math.Pow(this.b.X - this.a.X, 2) + Math.Pow(this.b.Y - this.a.Y, 2));
    }
}