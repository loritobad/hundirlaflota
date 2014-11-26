using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Barco
    {
        private int _portaaviones;
        private int _destructor;
        private int _acorazados;
        private int _lancha;


        public  Barco()
        {
            //amplitud de los barcos por defecto
            _portaaviones = 6;
            _destructor = 5;
            _acorazados = 3;
            _lancha = 1;
        }
        
       
        //propiedades de acceso

        public int Portaaviones
        {
            get { return _portaaviones;  } //lectura
            //set { } //escritura
        }

        public int Destructor
        {
            get { return _destructor;  }
            //set { }
        }

        public int Acorazado
        {
            get { return _acorazados; }
            //set { }
        }

        public int Lancha
        {
            get { return _lancha; }
            //set { }
        }

    }
}
