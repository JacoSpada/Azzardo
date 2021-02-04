using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzzardoApp1
{
    abstract class Azzardo
    {
        private static Random random = new Random();
        protected byte risultato;
        abstract public void Lancio();

    }
}
