using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Metods
{
    public class Test
    {
        static void Main(string[] args)
        {
            int x; 
            int y; 
            int greater;

            Console.WriteLine("Введите первую цифру:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("До метода Swap: " + x + "," + y);
            greater = Utils.Greater(x, y);
            Console.WriteLine("большее число это" + greater);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После метода Swap: " + x + "," + y);
            Console.ReadKey();
        }
    }
}
