using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        private string nombreCompleto;
        private int dni;
        private int edad;
        public bool equipajeDeMano;
        public double equipajeDeBodega;

        public Pasajero(string nombreCompleto, int dni, int edad, bool equipajeDeMano, double equipajeDeBodega)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.edad = edad;
            this.equipajeDeMano = equipajeDeMano;
            this.equipajeDeBodega = equipajeDeBodega;
        }

        public static bool operator ==(Pasajero c1, Pasajero c2)
        {
            bool sonIguales = false;
            if (c1.dni == c2.dni)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool operator !=(Pasajero c1, Pasajero c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Pasajero auto = obj as Pasajero;
            return auto is not null && this == auto;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre Completo: {this.nombreCompleto}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.Append("Equipaje de Mano: ");
            if (this.equipajeDeMano)
            {
                sb.AppendLine("Si");
            }
            else
            {
                sb.AppendLine("No");
            }
            sb.AppendLine($"Equipaje de Bodega: {this.equipajeDeBodega.ToString("0.##")} KG.");

            return base.ToString();
        }
    }
}
