using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Moto
    {
        public string Marca {  get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabrica  { get; private set; }


        public Moto(string marca, int modelo, double valorFabrica)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabrica = valorFabrica;
        }


        public double CalcularDrepreciacionLineal(int anoCalcular, int vidaUtil)
        {
            double depreLineal = 0;
            int anoDeUso = anoCalcular - Modelo;

            depreLineal = ValorFabrica - ( ValorFabrica * ((double)anoDeUso / vidaUtil) ); // me da cero, al mostrar, debe ser que no me esta tomando los decimales, por eso quedan iguales y se restan


            return depreLineal;
        }

        public double CalcularDrepeciacionAnual( int anoCalcular, double tasaDepre)
        {
            double depreAnual = 0;
            int anoDeUso = anoCalcular - Modelo;

            depreAnual = ValorFabrica * (Math.Pow((1-tasaDepre), anoDeUso) );

            return depreAnual;
        }

        public string VerDescripcion()
        {
            return $"Marca: {Marca}, Modelo {Modelo}. Valor de Fabrica: {ValorFabrica:c}";
        }


    }
}
