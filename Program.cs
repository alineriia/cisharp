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
            Rectangle R1 = new Rectangle();
            R1.Input();
            R1.Output();
            Circle C1 = new Circle();
            C1.Input();
            C1.Output();
            Triangle T1 = new Triangle();
            T1.Input();
            T1.Output();

            Console.ReadKey();
        }
    }
}