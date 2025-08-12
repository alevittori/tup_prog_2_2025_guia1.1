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

        public int HDuracionViaje { get; private set; } // supongo que por el uml debo usar estas variables como hora de inicio en el sonctructor

        public int MDuracionViaje { get; private set; }


        public Viaje(int hInicio, int mInicio , int asientos)
        {
            this.HDuracionViaje = hInicio;
            this.MDuracionViaje = mInicio;

            this.Asientos = asientos;

        }

        public void RealizarParada(int hLlegadaParada,int mLlegadaParada, int hSalidaParada, int mSalidaParada, int asciende, int descienden)
        {

        }
        public void FinalizarViaje(int hFinal, int mFinal)
        {

        }
    }
}
