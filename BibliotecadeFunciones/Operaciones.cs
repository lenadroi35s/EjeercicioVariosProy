﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecadeFunciones
{
    public class Operaciones
    {
        public double suma(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double factorial(double num)
        {
            double fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }
            return fac;
        }

    }
}
