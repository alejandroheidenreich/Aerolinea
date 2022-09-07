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
        private bool internacional;
        private List<Pasajero> listaDePasajeros;

        public Vuelo(int duracionDelVuelo, Aeronave aeronave)
        {
            this.duracionDelVuelo = duracionDelVuelo;
            this.aeronave = aeronave;
            this.listaDePasajeros = new List<Pasajero>();
        }

        public int DuracionDelVuelo { get => duracionDelVuelo; }
        public Aeronave Aeronave { get => aeronave; }
        public bool TipoDeVuelo { get => internacional; }
        private double CostoDelPasaje
        {
            set 
            {
                if (this.internacional)
                {

                }
            }
        }
    }
}
