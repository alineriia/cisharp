using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Circle : Figure
    {
        protected float r;
        public Circle() { }
        public override void Input()
        {
            using (StreamReader MyFile = new StreamReader("circ.txt"))
            {

                r = float.Parse(MyFile.ReadLine());
            }
        }
        public override double Sq()
        {
            return Math.PI*r*r;
        }
        public override double Pr()
        {
            return 2*Math.PI*r;
        }
        public override void Output()
        {
            Console.WriteLine("r = {0} ", r);
            Console.WriteLine("Square of circle is {0:f2} \nLength of circle is {1:f2}", Sq(), Pr());
        }

    }
}
