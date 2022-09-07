using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compania
    {
        public enum DestinosNacionales
        {
            Santa_Rosa,
            Bariloche,
            Corrientes,
            Córdoba,
            Jujuy,
            Mendoza,
            Neuquén,
            Posadas,
            Iguazú,
            Salta,
            Santiago_del_Estero,
            Trelew,
            Tucumán,
            Puerto_Madryn,
            Ushuaia
        }

        public enum DestinosInternacionales
        {
            Recife_Brasil,
            Roma_Italia,
            Acapulco_México,
            Miami_EEUU,
        }

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Aeronave> listaDeAereonaves;
        private int cantidadMaximaDeAereonaves;
    }
}
