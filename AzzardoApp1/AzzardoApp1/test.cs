using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzzardoApp1
{
    class test
    {

        private int[] mioArray;
        private int Somma;

        public test()
        {
            mioArray = new int[5];
        }
        public void PopolaArray()
        {
            this.mioArray[0] = 12;
            this.mioArray[1] = 130;
            this.mioArray[2] = 45;
            this.mioArray[3] = 60;
            this.mioArray[4] = 87;
        }

        public void StampaSomma()
        {
            for(int i = 0; i < mioArray.Length; i++)
            {
                Somma += mioArray[i];
            }

            Console.WriteLine("La somma è " + Somma);
        }

        public void StampaSommaWhile()
        {
            int Somma = 0;
            int i = 0;

            while (i < mioArray.Length)
            {
                Somma += mioArray[i];
                i++;
            }

            Console.WriteLine("La somma è " + Somma);
        }


    }
}
