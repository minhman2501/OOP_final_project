using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(4 ,5);
            Point pt2 = new Point(5 ,4);
            Point pt3 = new Point(9 ,5);
            Point pt4 = new Point(4 ,4);

            // Rectangle rec1 = new Rectangle(pt1, pt2, 3, 4);
            // rec1.colorShape = "Red";
            // rec1.Move();
            // rec1.calculate();
            // rec1.showInfo();
            Circle cr1 = new Circle(pt1, pt3, 3.5);
            Triangle tr1 = new Triangle(pt2, pt1, 6.6, 5);
            Rectangle rec1 = new Rectangle(pt4, pt3, 3.5, 4);
            Line ln1 = new Line(pt2, pt4, "Red");
            Graphic.add_Shape(cr1, tr1, ln1, rec1);
            ln1.getInput(pt3, pt1, "Yellow");
            Graphic.graphicInfo();
            // rec1.calculate();
            
            

        }   
    }

}
