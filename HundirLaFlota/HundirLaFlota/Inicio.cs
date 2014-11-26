using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace HundirLaFlota
{
    class Inicio
    {
        static void Main(string[] args)
        {

            switch ((char)Dibujar.Menu()) //redirecciono segun la opcion elegida
            {
                case 'A': //Colocar barcos manualmente
                    Console.WriteLine(" es a");
                    break;

                case 'B': //comenzar la partida
                   
                    // creo los barcos

                    Barco porta = new Barco();
                    
                  
                    break;

                
            }
          

           Console.ReadKey();
        }
    }
}
