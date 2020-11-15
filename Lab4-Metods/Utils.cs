using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Metods
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out long answer)
        {
            int k; //счётчик
            long f;//промежуточное значение
            bool ok = true;//проверка 
            if (n < 0)//n-количество членов в цикле
                ok = false;
            try 
            {
                checked
                { 
                    f = 1;
                    for (k = 2; k <= n; ++k ) 
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
                Console.Write("Переполнение\n\n");
            }
            answer = f;
            return ok;
        }
    }
}
