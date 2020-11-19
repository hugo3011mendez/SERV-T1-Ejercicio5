using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    // • Tendrá una propiedad Intervalo que indica en ms cada cuánto se ejecuta una determinada función.
    // • Deberás crear un delegado para poder pasarle una función que será la que ejecute.
    // • El Constructor tendrá como parámetro la función que se le pasa. Se recomienda en este constructor lanzar el hilo de ejecución aunque este entre en espera.
    // • Tendrá un método run el cual inicia la ejecución de la función cada Intervalo ms.
    // • Tendrá un método pause que pausa la ejecución.

    class MyTimer
    {
        public delegate void Delegado();

        int intervalo;

        public void run()
        {

        }

        public void pause()
        {

        }

        public MyTimer()
        {

        }
    }
}
