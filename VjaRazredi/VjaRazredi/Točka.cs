using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjaRazredi
{
    internal class Točka
    {
       private double x;
       private double y;
       private double r;
       private int fi;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }
        public int Fi { get => fi; set => fi = value; }

        public void PretvoriVPolarne()
        {
            //x,y poznam, računam r in fi
            r = Math.Sqrt(x * x + y * y);
            fi = (int)(Math.Atan(y / x)*180/Math.PI);
        }
        public void PretvoriVKartezične()
        {
            //r in fi poznam, računam x in y
            x = r*Math.Cos(fi * Math.PI / 180);
            y =Math.Round( r * Math.Sin(fi * Math.PI / 180),2);
        }
        //konstruktorji
        public Točka(double x1,double y1)
        {
            x = x1;y = y1;
            PretvoriVPolarne();
        }
        public Točka(double r1,int fi1)
        {
            r = r1;fi = fi1;
            PretvoriVKartezične();
        }
        public void Izpis()
        {
            Console.WriteLine("Kartezične ("+x+", "+y+")");
            Console.WriteLine("Polarne    (" + r + ", " + fi + "°)");
        }
    }
}
