using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzzardoApp1
{
    class Moneta:Azzardo
    {
        private static Random random = new Random();
        private String ValoreMoneta;
        public override void Lancio()
        {
            //Random random = new Random();
            risultato = (byte)random.Next(1, 3);

            if (risultato == 1)
            {
                ValoreMoneta = "TESTA";
            }
            else
            {

                ValoreMoneta = "CROCE";
            }

            Console.WriteLine("Ho lanciato la moneta : " + ValoreMoneta);

        }
    }
}
