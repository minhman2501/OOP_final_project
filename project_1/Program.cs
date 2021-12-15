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

            Line ln1 = new Line(pt1, pt2, "Blue");
            // ln1.getInput();
            Triangle tr1 = new Triangle(pt2, pt3, "Red", 4.5, 6);
            // tr1.getInput();
            Rectangle rec1 = new Rectangle(pt3, pt1, "Yellow", 4, 5);
            // rec1.getInput();
            Circle cr1 = new Circle(pt3, pt4, "White", 6.7);
            // cr1.getInput();

            Graphic.add_Shape(ln1, tr1, rec1, cr1);
            Graphic.graphicInfo();
            Graphic.changeColor__AllShape();
            Graphic.showColor__Graphic();
            Graphic.changeColor__EachShape();
            Graphic.showColor__EachShape();
            Graphic.remove_Shape();
            
            
            

        }   
    }

}
