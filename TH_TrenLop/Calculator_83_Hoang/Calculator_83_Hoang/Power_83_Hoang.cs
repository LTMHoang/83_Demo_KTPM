using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_83_Hoang
{
    public class Power_83_Hoang
    {
        public static double Power_83(double x_83_Hoang, int n_83_Hoang)
        {
            if (n_83_Hoang == 0)
                return 1.0;
            else if (n_83_Hoang > 0)
                return x_83_Hoang * Power_83(x_83_Hoang, n_83_Hoang - 1);
            else
                return Power_83(x_83_Hoang, n_83_Hoang + 1) / x_83_Hoang;
        }
    }
}
