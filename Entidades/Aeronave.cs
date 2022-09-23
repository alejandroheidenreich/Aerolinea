using System;
using System.Text;

namespace Entidades
{
    public class Aeronave
    {
        private string matricula;
        private int cantidadDeAsientosTotales;
        private int cantidadDeBanios;
        private double capacidadDeBodega;

        public Aeronave(int cantidadDeAsientos, int cantidadDeBanios, double capacidadDeBodega)
        {
            this.matricula = GenerarMatricula();
            this.cantidadDeAsientosTotales = cantidadDeAsientos;
            this.cantidadDeBanios = cantidadDeBanios;
            this.capacidadDeBodega = capacidadDeBodega;
        }

        //20% asientos premium

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public int Premium
        {
            get 
            { 
                return (int)(cantidadDeAsientosTotales * 0.20); 
            }
        }
        public int Tursita
        {
            get
            {
                return this.cantidadDeAsientosTotales-this.Premium;
            }
        }

        public int AsientosTotales
        {
            get => cantidadDeAsientosTotales;
            set => cantidadDeAsientosTotales = value;
        }
        public int Baños
        {
            get => cantidadDeBanios;
            set => cantidadDeBanios = value;
        }
        public double Bodega
        {
            get => capacidadDeBodega;
            set => capacidadDeBodega = value;
        }
        private string GenerarMatricula()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] matriculaArray = new char[8];
            Random random = new Random();

            for (int i = 0; i < matriculaArray.Length; i++)
            {
                matriculaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new String(matriculaArray);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Cantidad de Asientos Totales: {this.cantidadDeAsientosTotales}");
            sb.AppendLine($"Cantidad de Asientos Premium: {this.Premium}");
            sb.AppendLine($"Cantidad de Asientos Tursitas: {this.Tursita}");
            sb.AppendLine($"Cantidad de Baños: {this.cantidadDeBanios}");
            sb.AppendLine($"Capacidad de Bodega: {this.capacidadDeBodega.ToString("0.##")} KG.");

            return sb.ToString();
        }
    }
}
