using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Hoang_Calculator
{
    internal class _83_Calculation
    {
    }
    public class Calculation_83 
    {
        private int a_83, b_83;
        public Calculation_83(int a_83, int b_83) 
        {
            this.a_83 = a_83;
            this.b_83 = b_83;
        }
        public int Execute_83(string CalSymbol_83)
        {
            int result_83 = 0;
            switch (CalSymbol_83) 
            {
                case "+":
                    result_83 = this.a_83 + this.b_83;
                    break;
                case "-":
                    result_83 = this.a_83 - this.b_83;
                    break;
                case "*":
                    result_83 = this.a_83 * this.b_83;
                    break;
                case "/":
                    result_83 = this.a_83 / this.b_83;
                    break;
            }
            return result_83;
        }
    }
}