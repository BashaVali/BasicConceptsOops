using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptsOops
{
    public class MethodOverLoading
    {
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double Add(double a, double b, double c)

        {
            double sum = a + b + c;
            return sum;
        }
    }
}
