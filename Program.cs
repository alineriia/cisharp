using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*Створити абстрактний клас «Figure» з методами обчислення площі та периметра, а також
методом, що виводить інформацію про фігуру на екран. Створити похідні класи: Rectangle
(прямокутник), Circle (коло), Triangle (трикутник) зі своїми методами обчислення площі та периметра.
Створити масив n фігур і вивести повну інформацію про фігури на екран.
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter num of Rectangle");
            n1 = int.Parse(Console.ReadLine());
            Rectangle[] r = new Rectangle[n1];
            for (int i = 0; i < n1; i++)
            {
                r[i] = new Rectangle();
                r[i].Input();
                r[i].Output();
            }
            Console.WriteLine("Enter num of Circle");
            n2 = int.Parse(Console.ReadLine());
            Circle[] c = new Circle[n2];
            for (int i = 0; i < n2; i++)
            {
                c[i] = new Circle();
                c[i].Input();
                c[i].Output();
            }
            Console.WriteLine("Enter num of Rectangle");
            n3 = int.Parse(Console.ReadLine());
            Triangle[] t = new Triangle[n3];
            for (int i = 0; i < n3; i++)
            {
                t[i] = new Triangle();
                t[i].Input();
                t[i].Output();
            }

            Console.ReadKey();
        }
    }
}
