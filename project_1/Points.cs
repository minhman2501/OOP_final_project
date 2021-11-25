using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point {
    private double x;
    private double y;

    public double X {
        get { return this.x;}
        set { this.x = value;}
    }
    public double Y {
        get { return this.y;}
        set { this.y = value;}
    }
    public Point() {}
    public Point(double a, double b) {
        this.x = a;
        this.y = b;
    }

    ~ Point() {}
    
    public void pointInput() {
        Console.WriteLine("Enter x, y for a point:");
        Console.Write("X:");
        this.x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y:");
        this.y = Convert.ToInt32(Console.ReadLine());
    }

    public void pointInput(double a, double b) {
        this.x = a;
        this.y = b;
    }

    public void pointInfo() {
        Console.WriteLine("[" + this.x + "," + this.y +"]");
    }

}