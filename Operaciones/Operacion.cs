using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Operacion
    {
        //Atrinbutos
        public int numero1;
        public int numero2;

        //Metodos
        // modificador + retorno + nombre + parametros + llaves
        public void Suma()
        {
            Console.WriteLine("La suma es: " + (numero1+numero2));
        }

        public int Resta(int numero1m, int numero2m)
        {
            int resta = numero1m - numero2m;
            return resta;
        }
    }
}
