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
            int f;
            bool ok;

            Console.WriteLine("Введите первую цифру:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("До метода Swap x={0},y={1} ", x, y);
            greater = Utils.Greater(x, y);
            Console.WriteLine("большее число это" + greater);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После метода Swap x={0},y={1} ", x, y);
            Console.WriteLine("Введите число для расчёта факториала:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Факториал введённого числа{0} равен {1}",x, f);
            else
                Console.WriteLine("Невозможно вычислить факториал");

            Console.ReadKey();
        }
    }
}
