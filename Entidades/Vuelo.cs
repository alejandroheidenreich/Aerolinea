using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private int duracionDelVuelo;
        private Aeronave aeronave;
        private bool esInternacional;
        private List<Pasajero> listaDePasajeros;

        public Vuelo(int duracionDelVuelo, Aeronave aeronave)
        {
            this.duracionDelVuelo = duracionDelVuelo;
            this.aeronave = aeronave;
            this.listaDePasajeros = new List<Pasajero>();
        }

        public bool VueloCompleto
        {
            get
            {
                return this.listaDePasajeros.Count == this.aeronave.CantidadDeAsientos;
            }
        }

        public int DuracionDelVuelo { get => duracionDelVuelo; }
        public Aeronave Aeronave { get => aeronave; }
        public bool TipoDeVuelo { get => esInternacional; }
        private double CostoDelPasaje
        {
            set 
            {
                if (this.esInternacional)
                {

                }
            }
        }

        public static bool operator ==(Vuelo v, Pasajero c)
        {
            bool pertenece = false; 
            foreach (Pasajero item in v.listaDePasajeros)
            {
                if (item == c)
                {
                    pertenece = true;
                    break;
                }
            }
            return pertenece;
        }

        public static bool operator !=(Vuelo v, Pasajero c)
        {
            return !(v == c);
        }
    }
}
