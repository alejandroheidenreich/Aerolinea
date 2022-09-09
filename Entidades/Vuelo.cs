using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Entidades
{
    public enum TipoDeVuelo
    {
        Nacional,
        Internacional
    }

    public enum ClaseDePasajero
    {
        Tursita,
        Premium
    }

    public class Vuelo
    {
        
        private string destino;
        private int duracionDelVuelo;
        private Aeronave aeronave;
        private List<Pasajero> listaDePasajeros;

        public Vuelo(int duracionDelVuelo, Aeronave aeronave, string destino)
        {
            this.duracionDelVuelo = duracionDelVuelo;
            this.aeronave = aeronave;
            this.listaDePasajeros = new List<Pasajero>();
            this.destino = destino;
        }

        public string Destino
        {
            get => destino;
            set => destino = value;
        }
        public TipoDeVuelo Tipo
        {
            get
            {
                return DestinoEsInternacional(this.destino);
            }
        }

        public int DuracionDelVuelo
        {
            get => duracionDelVuelo;
            set => duracionDelVuelo = value;
        }
        public string EstadoVueloActual
        {
            get 
            {
                if (this.listaDePasajeros.Count == this.aeronave.CantidadDeAsientosTotales)
                    return "COMPLETO";
                return $"{this.listaDePasajeros.Count}/ {this.aeronave.CantidadDeAsientosTotales}";
            }
        }
        public Aeronave Aeronave
        {
            get => aeronave;
            set => aeronave = value;
        }
        public List<Pasajero> ListaDePasajeros
        {
            get => listaDePasajeros;
            set => listaDePasajeros = value;
        }

        private static TipoDeVuelo DestinoEsInternacional(string destino)
        {
            if (destino == "Acapulco(México)" ||
                        destino == "Miami(EEUU)" ||
                        destino == "Recife(Brasil)" ||
                        destino == "Roma(Italia)")
            {
                return TipoDeVuelo.Internacional;
            }
            return TipoDeVuelo.Nacional;
        }

        public static bool operator ==(Vuelo v, Pasajero p)
        {
            foreach (Pasajero item in v.listaDePasajeros)
            {
                if (item == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Vuelo v, Pasajero p)
        {
            return !(v == p);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Destino: {this.destino} - {this.Tipo}");
            sb.Append("Disponibilidad: ");
            sb.AppendLine(this.EstadoVueloActual);
     

            return base.ToString();
        }
    }
}
