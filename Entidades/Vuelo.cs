using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
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
        private string origen;
        private int horaDelVuelo;
        private int minutosDelVuelo;
        private DateTime partida;
        private Aeronave aeronave;
        private List<Pasajero> listaDePasajeros;
        //private Dictionary<Pasajero,ClaseDePasajero> claseDePasajeros;//TODO: Implementar

        public Vuelo(Aeronave aeronave,  string origen, string destino, DateTime partida)
        {
            this.aeronave = aeronave;
            this.listaDePasajeros = new List<Pasajero>();
            this.destino = destino;
            this.origen = origen;
            this.partida = partida;
            GenerarDuracionDeVuelos();
        }

        public string Origen
        {
            get => origen;
            set => origen = value;
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
                return DestinoEsInternacional(this.origen, this.destino);
            }
        }

        public string Duracion
        {
            get => new DateTime(1,1,1,this.horaDelVuelo, this.minutosDelVuelo,0).ToString("HH:mm");
        }
        public string Disponibilidad
        {
            get
            {
                if (this.listaDePasajeros.Count == this.aeronave.AsientosTotales)
                    return "COMPLETO";
                return $"{this.listaDePasajeros.Count}/ {this.aeronave.AsientosTotales}";
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
        public int HoraDelVuelo
        {
            set => horaDelVuelo = value;
        }
        public int MinutosDelVuelo
        {
            set => minutosDelVuelo = value;
        }
        public DateTime Partida
        {
            get => partida;
            set => partida = value;
        }

        private void GenerarDuracionDeVuelos()
        {
            Random rnd = new Random();
            if (this.Tipo == TipoDeVuelo.Internacional)
            {
                this.horaDelVuelo = rnd.Next(8, 12);
                this.minutosDelVuelo = rnd.Next(0, 55);
                if (this.horaDelVuelo == 12)
                {
                    this.minutosDelVuelo = 0;
                }
            }
            else
            {
                this.horaDelVuelo = rnd.Next(2, 4);
                this.minutosDelVuelo = rnd.Next(0, 55);
                if (this.horaDelVuelo == 4)
                {
                    this.minutosDelVuelo = 0;
                }
            }
        }
        private static TipoDeVuelo DestinoEsInternacional(string origen, string destino)
        {
            if (origen == "Acapulco(México)" ||
                origen == "Miami(EEUU)" ||
                origen == "Recife(Brasil)" ||
                origen == "Roma(Italia)" ||
                destino == "Acapulco(México)" ||
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

        public static bool operator +(Vuelo v, Pasajero p)
        {
            //TODO: Implementar y posible refactorizacion
            if (v.listaDePasajeros.Count < v.aeronave.AsientosTotales)
            {
                foreach (Pasajero item in v.listaDePasajeros)
                {
                    if (item == p)
                    {
                        return false;
                    }
                }
                v.listaDePasajeros.Add(p);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Destino: {this.destino} - {this.Tipo}");
            sb.Append("Disponibilidad: ");
            sb.AppendLine(this.Disponibilidad);


            return base.ToString();
        }
    }
}
