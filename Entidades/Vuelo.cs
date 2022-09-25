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

    public class Vuelo
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private string id;
        private string destino;
        private string origen;
        private int horaDelVuelo;
        private int minutosDelVuelo;
        private DateTime partida;
        private Aeronave aeronave;
        private List<Pasaje> listaDePasajeros;
        /*private Dictionary<Pasajero,ClaseDePasajero> claseDePasajeros;*///TODO: Implementar

        public Vuelo(Aeronave aeronave, string origen, string destino, DateTime partida)
        {
            this.id = GenerarID();
            this.aeronave = aeronave;
            this.listaDePasajeros = new List<Pasaje>();
            this.destino = destino;
            this.origen = origen;
            this.partida = partida;
            ValidarOrigenDestino(origen, destino);
            ValidarVueloInternacional();
            GenerarDuracionDeVuelos();
        }

        private static void ValidarOrigenDestino(string origen, string destino)
        {
            if (origen == destino)
            {
                throw new Exception("El origen no puede ser igual que el destino");
            }
        }

        private void ValidarVueloInternacional()
        {
            if (DestinoEsInternacional(this.origen, this.destino) == TipoDeVuelo.Internacional &&
                            this.origen != "Buenos Aires" && this.destino != "Buenos Aires")
            {
                throw new Exception("Vuelos internacionales deben partir o arribar en Buenos Aires");
            }
        }

        public string ID
        {
            get => id;
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
        public List<Pasaje> ListaDePasajeros
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

        public int Premium
        {
            get
            {
                return CantidadDeVuelosClase(ClaseDePasajero.Premium);
            }
        }
        public int Tursita
        {
            get
            {
                return CantidadDeVuelosClase(ClaseDePasajero.Tursita);
            }
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

        private int CantidadDeVuelosClase(ClaseDePasajero clase)
        {
            int contador = 0;
            foreach (Pasaje item in this.listaDePasajeros)
            {
                if (item.Clase == clase)
                {
                    contador++;
                }
            }
            return contador;
        }
        public string InformarConPrecioDelPasaje(Pasaje pasaje, out double precioFinal)
        {
            StringBuilder sb = new StringBuilder();
            precioFinal = -1;
            double horasTotales = this.horaDelVuelo + ((double)this.minutosDelVuelo / 60);


            if (DestinoEsInternacional(this.origen, this.destino) == TipoDeVuelo.Nacional)
            {
                precioFinal = PRECIOPORHORANACIONAL * horasTotales;
            }
            else
            {
                precioFinal = PRECIOPORHORAINTERNACIONAL * horasTotales;
            }
            sb.AppendLine($"Registro: {pasaje.IdRegistro}");
            sb.AppendLine($"Precio Bruto: {precioFinal.ToString("0.00")} U$D");

            if (pasaje.Clase == ClaseDePasajero.Premium)
            {
                precioFinal *= 1.25;
                sb.AppendLine($"Impuesto por Premium: {(precioFinal*0.25).ToString("0.00")} U$D");
            }

            if (pasaje.PesoAdicional > 0)
            {
                double precioPeso = pasaje.PesoAdicional * precioFinal *.01;
                precioFinal += precioPeso;
                sb.AppendLine($"Impuesto por Peso Adicional: {precioPeso.ToString("0.00")} U$D");
            }


            return sb.ToString();
        }

        private bool PasajeExisteEnVuelo(Pasaje pasaje)
        {
            foreach (Pasaje item in this.listaDePasajeros)
            {
                if (pasaje.IdRegistro == item.IdRegistro)
                {
                    return true;
                }
            }
            return false;
        }

        public double EspacioDisponibleBodega()
        {
            double acumuladorBodega = 0;
            foreach (Pasaje item in this.listaDePasajeros)
            {
                foreach (double itemDelItem in item.EquipajeDeBodega)
                {
                    acumuladorBodega += itemDelItem;
                }
            }

            return this.aeronave.Bodega - acumuladorBodega;
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

        public static bool operator ==(Vuelo v, Pasaje p)
        {
            foreach (Pasaje item in v.listaDePasajeros)
            {
                if (item == p)
                {
                    return true;
                }
            }
            return false;
        }

       
        public static bool operator !=(Vuelo v, Pasaje p)
        {
            return !(v == p);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Vuelo: {this.id}");
            sb.Append($"Origen: {this.origen}    Destino: {this.destino} - ({this.Tipo})");

            return sb.ToString();
        }

        private string GenerarID()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] idArray = new char[11];
            Random random = new Random();

            for (int i = 0; i < idArray.Length; i++)
            {
                idArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new String(idArray);
        }
    }
}
