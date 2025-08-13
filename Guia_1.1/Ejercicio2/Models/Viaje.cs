using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Viaje
    {
        public int Transportados { get; private set; }
        public int Asientos { get; private set; }
        public int HDemora { get; private set; }

        public int MDemora { get; private set;}

        public int CantParadas { get; private set; }

        public int HDuracionViaje { get; private set; } 

        public int MDuracionViaje { get; private set; }

        public int HInicio { get; private set; }
        public int MInicio { get; private set; }
        DateTime horaSalida;

        public Viaje(int asientos)
        {
           horaSalida = DateTime.Now;

            this.Asientos = asientos;

        }

        public void RealizarParada(int hLlegadaParada,int mLlegadaParada, int hSalidaParada, int mSalidaParada, int asciende, int descienden)
        {

            CantParadas++;

        }
        public void FinalizarViaje()
        {

        }
    }
}
