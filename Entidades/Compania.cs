using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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

    public static class Compania
    {
        private static List<Usuario> usuarios;
        private static List<Aeronave> listaDeAereonaves;
        private static int cantidadMaximaDeAereonaves;
        private static List<Vuelo> listaDeVuelos;


    }
}
