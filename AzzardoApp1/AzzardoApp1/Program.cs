using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzzardoApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dado mioDado1 = new Dado();
            Dado mioDado2 = new Dado();
            Moneta mioMoneta = new Moneta();

            mioDado1.Lancio();
            mioDado2.Lancio();
            mioDado1.Lancio();
            mioDado2.Lancio();
            mioDado1.Lancio();
            mioMoneta.Lancio();
            mioMoneta.Lancio();
            mioMoneta.Lancio();


            test mioTest1 = new test();
            mioTest1.PopolaArray();
            mioTest1.StampaSomma();




        }
    }
}
