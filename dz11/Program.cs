using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation(56, 28);
            equation.Root();          
            Console.ReadKey();
        }
    }
    public struct Equation
    {
        int k;
        int B { get; set; }

        public int K
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
        public Equation(int k, int b)
        {
            K = k;
           
        }
        public void Root()
        {
            int x = -B / k;
            Console.WriteLine("решение уровнения x= {0}", x);
        }
    

    }

}
