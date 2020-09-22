using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public interface Cal
    {
        double Calcu();
    }
    abstract class GeometricFigure
    {
        public abstract void Judge();
    }
    class Tri: GeometricFigure,Cal
    {
        public double line1 { get; set; }
        public double line2 { get; set; }
        public double line3 { get; set; }
        public double Calcu()
        {
            double p = (this.line1 + this.line2 + this.line3) / 2;
            double a = this.line1;double b = this.line2;double c = this.line3;
            return Math.Pow(p*(p-a)*(p-b)*(p-c), 0.5);
        }
        public override void Judge()
        {
            if (((this.line1+this.line2)>this.line3)&&((this.line2+this.line3)>this.line1)&&((this.line1+this.line3)>this.line2)) Console.WriteLine("is a triangle");
            else Console.WriteLine("not a triangle");
        }
    }
    class Rec : GeometricFigure, Cal
    {
        public double loLine { get; set; }
        public double shLine { get; set; }
        public override void Judge()
        {
            if (this.loLine > 0 && this.shLine > 0) Console.WriteLine("is a rectangle");
            else Console.WriteLine("not a rectangle");
        }
        public double Calcu()
        {
            return this.loLine * this.shLine;
        }
    }
    class Squ : GeometricFigure, Cal
    {
        public double line { get; set; }
        public override void Judge()
        {
            if (this.line > 0) Console.WriteLine("is a square");
            else Console.WriteLine("not a square");
        }
        public double Calcu()
        {
            return Math.Pow(line, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tri tri = new Tri
            {
                line1 = 3,
                line2 = 4,
                line3 = 5
            };
            tri.Judge();
            Console.WriteLine("area="+tri.Calcu());
            Rec rec = new Rec
            {
                loLine = 3,
                shLine = 4
            };
            rec.Judge();
            Console.WriteLine("area=" + rec.Calcu());
            Squ squ = new Squ
            {
                line=10
            };
            squ.Judge();
            Console.WriteLine("area=" + squ.Calcu());
        }
    }
}
