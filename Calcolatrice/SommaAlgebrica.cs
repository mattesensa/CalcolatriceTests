using System;

namespace Calcolatrice
{
    public class SommaAlgebrica
    {
        public SommaAlgebrica()
        {

        }

        public int Add(int add1, int add2)
        {
            //throw new NotImplementedException();
            return add1 + add2;
        }

        public int Add(int[] addendi)
        {
            //throw new NotImplementedException();
            if(addendi == null || addendi.Length == 0)
            {
                throw new ArgumentException();
            }
            int somma = 0;
            foreach (int a in addendi)
            {
                somma += a; 
            }
            return somma;
        }

        public double AddDouble(double[] addendi)
        {
            //throw new NotImplementedException();
            if (addendi == null || addendi.Length == 0)
            {
                throw new ArgumentException();
            }
            double somma = 0;
            foreach (double a in addendi)
            {
                somma += a;
            }
            return Math.Round(somma,7);
        }
    }
}