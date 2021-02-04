using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzzardoApp1
{
    class Dado:Azzardo
    {
        public override void Lancio ()
        {
        
            //Random random = new Random();
            risultato = (byte)random.Next(1, 7);

            Console.WriteLine("Ho lanciato il dado e il risultato è " + risultato);
            
        }

    }
}
