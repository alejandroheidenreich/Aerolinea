using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Vuelo
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private string id;
        private string destino;
        private string origen;
        private TipoDeVuelo tipo;
        private int horaDelVuelo;
        private int minutosDelVuelo;
        private string duracion;
        private DateTime partida;
        private Aeronave aeronave;
        private List<Pasaje> listaDePasajeros;
        private bool wifii;
        private bool comida;
        private bool menuVegano;
        private bool menuPremium;
        private bool bebidasSinAlcohol;
        private bool bebidasAlcoholicas;
        private Vuelo()
        {
            this.listaDePasajeros = new List<Pasaje>();
            this.id = GenerarID();
        }
        public Vuelo(Aeronave aeronave, string origen, string destino, DateTime partida, bool wifii, bool comida, bool menuVegano, bool menuPremium, bool bebidasSinAlcohol, bool bebidasAlcoholicas):this()
        {
            this.origen = origen;
            this.destino = destino;
            ValidarOrigenDestino(origen, destino);
            ValidarVueloInternacional();
            this.tipo = DestinoEsInternacional(this.origen, this.destino);
            this.partida = partida;
            GenerarDuracionDeVuelos();
            this.duracion = new DateTime(1, 1, 1, this.horaDelVuelo, this.minutosDelVuelo, 0).ToString("HH:mm");
            this.wifii = wifii;
            this.comida = comida;
            ValidarMenu(menuVegano, out this.menuVegano);
            ValidarMenu(menuPremium, out this.menuPremium);
            this.bebidasSinAlcohol = bebidasSinAlcohol;
            this.bebidasAlcoholicas = bebidasAlcoholicas;
            this.aeronave = aeronave;
            this.aeronave.AgregarVueloAPlanDeVuelos(this.partida);
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
            get => this.tipo;
        }
        public string Duracion
        {
            get => this.duracion;
        }
        public string Disponibilidad
        {
            get
            {
                return ActualizarDisponibilidad();
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
            get => horaDelVuelo;
            set => horaDelVuelo = value;
        }
        public int MinutosDelVuelo
        {
            get => minutosDelVuelo;
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
                return CantidadDeVuelosPorClase(ClaseDePasajero.Premium);
            }
        }
        public int Tursita
        {
            get
            {
                return CantidadDeVuelosPorClase(ClaseDePasajero.Tursita);
            }
        }
        public bool Wifii
        {
            get => wifii;
            set => wifii = value;
        }
        public bool Comida
        {
            get => comida;
            set => comida = value;
        }
        public bool MenuVegano
        {
            get => menuVegano;
            set => menuVegano = value;
        }
        public bool MenuPremium
        {
            get => menuPremium;
            set => menuPremium = value;
        }
        public bool SinAlcohol
        {
            get => bebidasSinAlcohol;
            set => bebidasSinAlcohol = value;
        }
        public bool Alcoholicas
        {
            get => bebidasAlcoholicas;
            set => bebidasAlcoholicas = value;
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
        private void ValidarMenu(bool menu, out bool menuValidado)
        {
            if (!this.comida && menu)
            {
                throw new Exception("Si el vuelo no provee comida, no puede tener un menu");
            }
            menuValidado = menu;
        }
        private string ActualizarDisponibilidad()
        {
            string vuelo = ActualizarEstadoDelVuelo();
            if (!string.IsNullOrEmpty(vuelo))
            {
                return vuelo;
            }
            else if (this.listaDePasajeros.Count == this.aeronave.AsientosTotales)
            {
                return "COMPLETO";
            }
            return $"{this.listaDePasajeros.Count}/ {this.aeronave.AsientosTotales}";
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

        public double GananciaTotal()
        {
            double ganancia = 0;
            double precioPasaje;
            foreach (Pasaje item in this.listaDePasajeros)
            {
                InformarTarifasYPrecioDelPasaje(item, out precioPasaje);
                ganancia += precioPasaje;
            }
            return ganancia;
        }

        public double GananciaPesoAdicional()
        {
            double gananciaPesoAdicional = 0;

            double horas = CalcularHorasTotales();
            double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
            foreach (Pasaje item in this.listaDePasajeros)
            {
                gananciaPesoAdicional += item.PesoAdicional * precioBase * .01;
            }
            return gananciaPesoAdicional;
        }
        public double GananciaPremiumAdicional()
        {
            double gananciaPremiumAdicional = 0;

            double horas = CalcularHorasTotales();
            double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
            foreach (Pasaje item in this.listaDePasajeros)
            {
                if (item.Clase == ClaseDePasajero.Premium)
                {

                    gananciaPremiumAdicional += precioBase * .15;
                }
            }
            return gananciaPremiumAdicional;
        }
        public double GananciaCabotaje()
        {
            double gananciaCabotaje = 0;
            if (DestinoEsInternacional(this.origen, this.destino) == TipoDeVuelo.Nacional)
            {
                double horas = CalcularHorasTotales();
                double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
                foreach (Pasaje item in this.listaDePasajeros)
                {
                    gananciaCabotaje += precioBase;
                }
            }
            return gananciaCabotaje;
        }
        public double GananciaInternacional()
        {
            double gananciaInternacional = 0;
            if (DestinoEsInternacional(this.origen, this.destino) == TipoDeVuelo.Internacional)
            {
                double horas = CalcularHorasTotales();
                double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
                for (int i = 0; i < this.listaDePasajeros.Count; i++)
                {
                    gananciaInternacional += precioBase;
                }
            }
            return gananciaInternacional;
        }

        private string ActualizarEstadoDelVuelo()
        {
            string estado = string.Empty;
            if (MedirHorarioDeLlegada() > DateTime.Now && this.partida < DateTime.Now)
            {
                estado = "EN VUELO";
            }
            else if (this.partida < DateTime.Now)
            {
                estado = "FINALIZADO";
            }
            return estado;
        }
        private DateTime MedirHorarioDeLlegada()
        {
            DateTime llegada;

            llegada = this.partida.AddHours(this.horaDelVuelo);
            llegada = this.partida.AddMinutes(this.minutosDelVuelo);

            return llegada;

        }
        private int CantidadDeVuelosPorClase(ClaseDePasajero clase)
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
        public string InformarTarifasYPrecioDelPasaje(Pasaje pasaje, out double precioFinal)
        {
            StringBuilder sb = new StringBuilder();
            double precioBase = CalcularPrecioSegunTipoDeVuelo(CalcularHorasTotales());
            precioFinal = precioBase;
            sb.AppendLine($"Registro: {pasaje.IdRegistro}");
            sb.AppendLine($"Precio Bruto: {precioBase.ToString("0.00")} U$D");

            if (pasaje.Clase == ClaseDePasajero.Premium)
            {
                double precioPreium = CalcularAdicionalPremium(precioBase);
                precioFinal += precioPreium;
                sb.AppendLine($"Impuesto por Premium: $ {(precioPreium).ToString("0.00")} U$D");
            }
            if (pasaje.PesoAdicional > 0)
            {
                double precioPeso = CalcularAdicionalPeso(precioBase, pasaje.PesoAdicional);
                precioFinal += precioPeso;
                sb.AppendLine($"Impuesto por Peso Adicional: $ {precioPeso.ToString("0.00")} U$D");
            }
            return sb.ToString();
        }

        public double CalcularAdicionalPremium(double precioBase)
        {
            return precioBase * 0.15;
        }

        public double CalcularAdicionalPeso(double precioBase, double pesoAdicional)
        {
            return precioBase * 0.01 * pesoAdicional;
        }
        public double CalcularHorasTotales()
        {
            return this.horaDelVuelo + ((double)this.minutosDelVuelo / 60);
        }
        public double CalcularPrecioSegunTipoDeVuelo(double horasTotales)
        {
            double precioFinal;
            if (DestinoEsInternacional(this.origen, this.destino) == TipoDeVuelo.Nacional)
            {
                precioFinal = PRECIOPORHORANACIONAL * horasTotales;
            }
            else
            {
                precioFinal = PRECIOPORHORAINTERNACIONAL * horasTotales;
            }

            return precioFinal;
        }

        public double CalcularEspacioDisponibleBodega()
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
