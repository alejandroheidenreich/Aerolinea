using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Entidades
{
    public static class Sistema
    {
        public static SortedDictionary<string, double> destinosFacturados;

        static Sistema()
        {
            destinosFacturados = new SortedDictionary<string, double>();

            HistorialDeVuelosPorFacturacion();
        }
        public static Usuario VerificarUsuarioContrasenia(string nombreDeUsuario, string contrasenia)
        {
            foreach (Usuario item in BaseDeDatos.usuarios)
            {
                if (item.NombreDeUsuario == nombreDeUsuario && item.VerificarContrasenia(contrasenia))
                {
                    return item;
                }
            }
            return null;    
        }

        public static void VerificarUsuarioNoRepetido(string nuevoUsuario)
        {
            foreach (Usuario item in BaseDeDatos.usuarios)
            {
                if (item.NombreDeUsuario == nuevoUsuario)
                {
                    throw new Exception("El usuario ya existe");
                }
            }
        }

        public static void AltaDeCliente(Cliente clienteAAgregar)
        {
            if (clienteAAgregar is not null)
            {
                BaseDeDatos.clientes.Add(clienteAAgregar);
            }
        }

        public static void AltaDePasajero(List<Pasaje> pasajerosAAgregar, Vuelo vuelo)
        {
            //TODO: Refactorizar
            bool huboFallo = false;
            List<Pasaje> fallos = new List<Pasaje>();
            if (vuelo.Disponibilidad == "COMPLETO")
            {
                throw new Exception("No se puede agregar pasajeros a un vuelo COMPLETO");
            }
            else
            {
                foreach (Pasaje item in pasajerosAAgregar)
                {
                    if (VerificarCantidadDePasajesPorCliente(vuelo, item))
                    {
                        vuelo.ListaDePasajeros.Add(item);
                    }
                    else
                    {
                        huboFallo = true;
                        fallos.Add(item);
                    }
                }
            }

            if (huboFallo)
            {
                //TODO: Refactorizar
                string mensaje = string.Empty;
                foreach (Pasaje item in fallos)
                {
                    mensaje += item.ToString();
                }
                throw new Exception($"Los siguientes pasajeros alcanzaron el limite de pasaje por vuelo{Environment.NewLine}{mensaje}");
            }
        }

        public static bool VerificarCantidadDePasajesPorCliente(Vuelo vuelo, Pasaje pasajero)
        {
            //TODO: Refactorizar
            int contadorDePasajes = 0;
            bool puedeComprar = false;
            foreach (Pasaje item in vuelo.ListaDePasajeros)
            {
                if (item.Equals(pasajero.Cliente))
                {
                    contadorDePasajes++;
                }
            }
            if (contadorDePasajes < 5 )
            {
                puedeComprar = true;
            }
            return puedeComprar;
        }

        public static bool VerificarPasajeComprar(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajerosParaAgregar)
        {
            //TODO: Refactorizar
            bool puedeComprar = false;
            int contadorDePasajes = CaclucarCantidadDelMismoPasajeEnLista(pasajero, pasajerosParaAgregar);
            foreach (Pasaje item in vuelo.ListaDePasajeros)
            {
                if (item.Equals(pasajero.Cliente))
                {
                    contadorDePasajes++;
                }
            }
            if (contadorDePasajes < 5 )
            {
                puedeComprar = true;
            }
            return puedeComprar;
        }

        public static bool VerificarPasajeComprar(Vuelo vuelo, Pasaje pasajero)
        {
            int contadorDePasajes = 0;
            bool puedeComprar = false;
            foreach (Pasaje item in vuelo.ListaDePasajeros)
            {
                if (item.Equals(pasajero.Cliente))
                {
                    contadorDePasajes++;
                }
            }
            if (contadorDePasajes < 5)
            {

                puedeComprar = true;
            }
            return puedeComprar;
        }

        public static void ValidadCompraDeClase(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajesAComprar)
        {
            int contadorPremium = 0;
            int contadorTurista = 0;
            foreach (Pasaje item in pasajesAComprar)
            {
                if (item.Clase == ClaseDePasajero.Premium)
                {
                    contadorPremium++;
                }
                else
                {
                    contadorTurista++;
                }
            }
            if ((pasajero.Clase == ClaseDePasajero.Tursita && vuelo.Tursita + contadorTurista + 1 > vuelo.Aeronave.Tursita) ||
                pasajero.Clase == ClaseDePasajero.Premium && vuelo.Premium + contadorPremium + 1 > vuelo.Aeronave.Premium)
            {
                throw new Exception($"Ya no hay disponibilidad para Pasajeros {pasajero.Clase} en este vuelo");
            }
        }

        private static int CaclucarCantidadDelMismoPasajeEnLista(Pasaje pasajero, List<Pasaje> pasajerosParaAgregar)
        {
            int contador = 0;
            foreach (Pasaje item in pasajerosParaAgregar)
            {
                if (item.Cliente == pasajero.Cliente)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static void AltaDeVuelo(Vuelo vueloAAgregar)
        {
            if (vueloAAgregar is not null && vueloAAgregar.Partida >= DateTime.Now)
            {
                BaseDeDatos.vuelosTotales.Add(vueloAAgregar);
            }
            else
            {
                throw new Exception("La Partida del vuelo no es valida.");
            }
        }

        public static void BajaDeVuelo(Vuelo vueloAEliminar)
        {
            if (vueloAEliminar is not null)
            {
                BaseDeDatos.vuelosTotales.Remove(vueloAEliminar);
            }
        }

        public static void BajaDeCliente(Cliente clienteBaja)
        {
            if (clienteBaja is not null)
            {
                BaseDeDatos.clientes.Remove(clienteBaja);
            }
        }

        public static Aeronave BuscarAeronavePorMatricula(string matricula)
        {
            foreach (Aeronave item in BaseDeDatos.aeronaves)
            {
                if (item.Matricula == matricula)
                {
                    return item;
                }
            }
            return null;
        }

        public static DateTime FechaAleatoria()
        {
            Random rand = new Random();
            int año = rand.Next(1950, DateTime.Now.Year-18);
            int mes = rand.Next(1, 12);
            int dia = rand.Next(1, 28);

            return new DateTime(año, mes, dia);
        }

        public static void ActualizarVuelos()
        {
            foreach (Vuelo item in BaseDeDatos.vuelosTotales)
            {
                if (item.Disponibilidad == "FINALIZADO")
                {
                    BaseDeDatos.vuelosHistorial.Add(item);
                }
                else
                {
                    BaseDeDatos.vuelosActivos.Add(item);
                }
            }
        }

        
        public static void HistorialDeVuelosPorFacturacion()
        {
            foreach (string item in BaseDeDatos.localidades)
            {
                destinosFacturados.Add(item, 0);
            }
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                destinosFacturados[item.Destino]+=item.GananciaTotal;
            }          
        }

        private static void OrdenarDiccionario(Dictionary<string, double> aux)
        {

        }
    }
}
