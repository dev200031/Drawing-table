using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Table
{
    class Scene
    {
        protected float widgt,height,a, b, c, r;
        public float Widht
        {
            get{ return widgt;}
            set{ widgt = value;}
        }
        public float Height
        {
            get{    return height;}
            set{ height = value;}
        }
        public float A
        {
            get { return b; }
            set { b = value; }
        }
        public float B
        {
            get { return b; }
            set { b = value; }
        }
        public float C
        {
            get{   return c;}
            set{ c = value;}
        }
        public float R
        {
            get{ return r;}
            set{ r = value;}
        }
        public virtual double CalculateSurface()
        {
            throw new NotImplementedException();
        }
        public virtual double CircleArea()
        {
            return Math.PI *r*r;
        }
        public virtual double RectangleArea()
        {
            return Widht*Height;
        }
        public virtual double TrianglesArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
