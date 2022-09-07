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
    }
}
