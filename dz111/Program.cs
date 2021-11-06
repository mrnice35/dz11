using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz111
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation { k =34, b = 28 };
            equation.Root();
            Console.ReadKey();
        }
        struct Equation
        {
            public double k;
            public double b;
            public double K
            {
                set
                {
                    if (value != 0)
                    {
                        k = value;
                    }
                    else
                    {
                        Console.WriteLine("на ноль делить нельзя");
                    }
                }
                get
                {
                    return k;
                }
            }
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("решение уровнения 0=kx+b с данными параметрами равно {0}",x);
            }

        }
    }
}
