using System.Text;

namespace Entidades
{
    public class Pasajero
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private string nombreCompleto;
        private int dni;
        private int edad;
        private bool equipajeDeMano;
        private double equipajeDeBodega;

        public Pasajero(string nombreCompleto, int dni, int edad)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.edad = edad;
        }
        public bool EquipajeDeMano
        {
            get => equipajeDeMano;
            set => equipajeDeMano = value;
        }
        public double EquipajeDeBodega
        {
            get => equipajeDeBodega;
            set => equipajeDeBodega = value;
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
