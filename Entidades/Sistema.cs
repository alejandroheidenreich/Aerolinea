using System;
using System.Collections.Generic;
using System.Net;

namespace Entidades
{
    public static class Sistema
    {
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
                if (item.Cliente == pasajero.Cliente)
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

        public static bool VerificarCarritoDecompras(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajerosParaAgregar)
        {
            //TODO: Refactorizar
            int contadorDePasajes = CaclucarCantidadDelMismoPasajeEnLista(pasajero, pasajerosParaAgregar);
            bool puedeComprar = false;
            foreach (Pasaje item in vuelo.ListaDePasajeros)
            {
                if (item.Cliente == pasajero.Cliente)
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
            if (vueloAAgregar is not null)
            {
                BaseDeDatos.vuelos.Add(vueloAAgregar);
            }
        }

        public static void BajaDeVuelo(Vuelo vueloAEliminar)
        {
            if (vueloAEliminar is not null)
            {
                BaseDeDatos.vuelos.Remove(vueloAEliminar);
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
            int año = rand.Next(1950, 2010);
            int mes = rand.Next(1, 12);
            int dia = rand.Next(1, 28);

            return new DateTime(año, mes, dia);
        }


    }
}
