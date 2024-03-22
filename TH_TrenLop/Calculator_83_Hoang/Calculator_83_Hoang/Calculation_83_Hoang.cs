using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_83_Hoang
{
    public class Calculation_83_Hoang
    {
        private int a_83_Hoang, b_83_Hoang;
        public Calculation_83_Hoang(int a_83_Hoang, int b_83_Hoang)
        {
            this.a_83_Hoang = a_83_Hoang;
            this.b_83_Hoang = b_83_Hoang;
        }
        public int Execute_83_Hoang(string CalSymbol_83)
        {
            int result_83_Hoang = 0;
            switch (CalSymbol_83)
            {
                case "+":
                    result_83_Hoang = this.a_83_Hoang + this.b_83_Hoang;
                    break;
                case "-":
                    result_83_Hoang = this.a_83_Hoang - this.b_83_Hoang;
                    break;
                case "*":
                    result_83_Hoang = this.a_83_Hoang * this.b_83_Hoang;
                    break;
                case "/":
                    result_83_Hoang = this.a_83_Hoang / this.b_83_Hoang;
                    break;
            }
            return result_83_Hoang;
        }
    }
}
