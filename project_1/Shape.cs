using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape {
    protected string name;
    protected Point a;
    protected Point b;

    protected string color;
    public string colorShape {
        get { return this.color;}
        set { this.color = value;}
    }
    public Shape() {}
    public Shape(Point pt1, Point pt2) {
        this.a = pt1;
        this.b = pt2;
    }
    public Shape(Point pt1, Point pt2, string shapeColor) {
        this.a = pt1;
        this.b = pt2;
        this.color = shapeColor;
    }

    ~ Shape() {}

    public virtual void getInput() {
        Console.WriteLine("\n****Get information for a " + this.name + "****");
        Console.WriteLine("Enter the first point");
        Point pt1 = new Point();
        pt1.pointInput();
        this.a = pt1;

        Console.WriteLine("Enter the second point");
        Point pt2 = new Point();
        pt2.pointInput();
        this.b = pt2;
        Console.WriteLine("Color:");
        this.color = Console.ReadLine();
    }

    public void getInput(Point pt1, Point pt2) {
        this.a = pt1;
        this.b = pt2;
        
    }
     public void getInput(Point pt1, Point pt2, string shapeColor) {
        this.a = pt1;
        this.b = pt2;
        this.color = shapeColor;
    }

    protected void draw() {
        Console.WriteLine("Draw " + this.name);
    }
    public virtual void showInfo() {
        Console.WriteLine("****" + this.name + " value****");
        Console.Write("Point 1:");
        this.a.pointInfo();
        Console.Write("Point 2:");
        this.b.pointInfo();
        Console.WriteLine("Color:" + this.color);
    }

    public abstract void calculate(); 
    public void colorChange() {
        Console.Write("Enter the color that you want to add: ");
        this.color = Console.ReadLine();
    }
    public void Move()
        {
            Console.Write("Enter the new point's coordinate");
            Point pointNew = new Point();
            pointNew.pointInput();

            double differenceX = Math.Abs(a.X - b.X);
            double differenceY = Math.Abs(a.Y - b.Y);

            
            this.a = pointNew;
            this.b.X = pointNew.X - differenceX;
            this.b.Y = pointNew.Y - differenceY;
        }
}