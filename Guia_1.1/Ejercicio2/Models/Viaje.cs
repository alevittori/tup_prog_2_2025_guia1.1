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
        
        public int CantParadas { get; private set; }


        public TimeSpan HoraSalida {get; private set; }

        public Viaje(int asientos)
        {
           HoraSalida = DateTime.Now.TimeOfDay;

            this.Asientos = asientos;
            this.CantParadas = 0;

        }

        public void RealizarParada( int asciende, int descienden)
        {
            var inicioParada = DateTime.Now.Hour;

            CantParadas++;

        }
        public void FinalizarViaje()
        {

        }
    }
}


/* 
 *          CALCULAR DURACION ENTRE DOS HORAS
 * // Hora de salida y llegada
        TimeSpan horaSalida = TimeSpan.Parse("08:30");
        TimeSpan horaLlegada = TimeSpan.Parse("12:45");

        // Calcular duración del recorrido
        TimeSpan duracion = horaLlegada - horaSalida;

        Console.WriteLine($"Duración del recorrido: {duracion.Hours} horas y {duracion.Minutes} minutos");
    
            SUMAR DEMORAS EN PARADAS

        TimeSpan demoraTotal = TimeSpan.Zero;

        // Demoras en cada parada
        int[] demoras = { 5, 3, 7 }; // minutos

        foreach (int minutos in demoras)
        {
            demoraTotal += TimeSpan.FromMinutes(minutos);
        }

        Console.WriteLine($"Demora total: {demoraTotal.Hours} horas y {demoraTotal.Minutes} minutos");


        public TimeSpan HoraSalida { get; private set; }
            public TimeSpan HoraLlegada { get; private set; }
            public TimeSpan DemoraTotal { get; private set; } = TimeSpan.Zero;
            public int Paradas { get; private set; } = 0;

            public void IniciarViaje(string hora)
            {
                HoraSalida = TimeSpan.Parse(hora);
            }

            public void RegistrarParada(int demoraMinutos)
            {
                DemoraTotal += TimeSpan.FromMinutes(demoraMinutos);
                Paradas++;
            }

            public void FinalizarViaje(string hora)
            {
                HoraLlegada = TimeSpan.Parse(hora);
                TimeSpan duracion = HoraLlegada - HoraSalida;

                Console.WriteLine($"Duración del recorrido: {duracion.Hours}h {duracion.Minutes}m");
                Console.WriteLine($"Demora total: {DemoraTotal.Hours}h {DemoraTotal.Minutes}m");
                Console.WriteLine($"Cantidad de paradas: {Paradas}");
            }





*/