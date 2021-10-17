using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHomeWork
{
    public delegate void game();
    public class Shape
    {
        public static void Hit()
        {
            Console.WriteLine("Outch you hit the wall");
        }
        public static void Miss()
        {
            Console.WriteLine("You surived! ");
        }


        public virtual int Loaction { get; set; }
        public static bool shapeChecker(Shape shape, int PointLoaction)
        {
            if (shape is square)
            {
                if (shape.Loaction >= PointLoaction)
                {
                    Outch = Hit;
                    Outch();
                    return true;
                }
            }
            else
            {
                if (shape.Loaction == PointLoaction)
                {
                    Outch = Hit;
                    Outch();

                    return true;
                }
            }

            Outch = Miss;
            Outch();
            return false;
        }


        public static event game ?Outch;
    }
    public class Pinpoint : Shape
    {
        public override int Loaction { get; set; }

        public Pinpoint(int pointLoaction)
        {
            Loaction = pointLoaction;
        }

        

    }
    public class square : Shape
    {
        public override int Loaction { get; set; }
        public square( int LengthandWidth)
        {
            Loaction = LengthandWidth * LengthandWidth;
            
        }

         


    }

  

}
