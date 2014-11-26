using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Tablero
    {
        //el tablero de juego consiste en un array bidimensional

        public int[,] _tablero;

        //constructor por defecto 10x10

        public Tablero()
        {
            _tablero = new int[10, 10];
        }

        ////propiedades de acceso a tablero

        //public int[,] Tablero
        //{
        //    get { }
        //}
    }
}
