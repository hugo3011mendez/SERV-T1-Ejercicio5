using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio5
{
    // • Tendrá una propiedad Intervalo que indica en ms cada cuánto se ejecuta una determinada función.
    // • Deberás crear un delegado para poder pasarle una función que será la que ejecute.
    // • El Constructor tendrá como parámetro la función que se le pasa. Se recomienda en este constructor lanzar el hilo de ejecución aunque este entre en espera.
    // • Tendrá un método run el cual inicia la ejecución de la función cada Intervalo ms.
    // • Tendrá un método pause que pausa la ejecución.

    public delegate void Delegado();
    class MyTimer
    {

        static bool flag = false; // Creo y declaro el flag
        static readonly object l = new object(); // Creo el objeto del lock, porque los hilos están usando recursos iguales


        public int intervalo;

        static bool parar = true;
        public void run(Delegado accion)
        {

            while (!parar)
            {
                lock (l)
                {
                    if (!parar)
                    {
                        Thread.Sleep(intervalo);
                        accion();
                        parar = true;
                    }
                }
            }
        }

        public void pause(Delegado accion)
        {
            parar = true;
        }

        public MyTimer(Delegado accion)
        {
            Thread hilo = new Thread(run); // Así empieza en espera
            hilo.Start(accion);
        }
    }
}
