using System;

namespace ProyectoFinalUwU
{
    
    class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre 0.");
            }
            return a / b;
        }
    }
}
