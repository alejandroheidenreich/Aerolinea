using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public static class Sistema
    {
        public static int VerificarUsuarioContrasenia(string nombreDeUsuario, string contrasenia)
        {
            foreach (Usuario item in BaseDeDatos.usuarios)
            {
                if (item.NombreDeUsuario == nombreDeUsuario && item.VerificarContrasenia(contrasenia))
                {
                    return BaseDeDatos.usuarios.IndexOf(item);
                }
            }
            return -1;
        }
        public static void VerificarUsuarioNoRepetido(string nuevoUsuario, int dni)
        {
            foreach (Usuario item in BaseDeDatos.usuarios)
            {
                if (item.NombreDeUsuario == nuevoUsuario && item.GetHashCode() != dni)
                {
                    throw new Exception("El usuario ya existe");
                }
            }
        }

        public static bool EditarUsuario(Usuario usuarioEditado)
        {
            for (int i = 0; i < BaseDeDatos.usuarios.Count; i++)
            {
                if (BaseDeDatos.usuarios[i].GetHashCode() == usuarioEditado.GetHashCode())
                {
                    BaseDeDatos.usuarios[i] = usuarioEditado;
                    return true;
                }
            }
            return false;
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
            bool huboFallo = false;
            List<Pasaje> fallos = new List<Pasaje>();
            if (vuelo.Disponibilidad == "COMPLETO")
            {
                throw new Exception("No se puede agregar pasajeros a un vuelo COMPLETO");
            }
            else
            {
                huboFallo = AgregarPasajeroListaDeVuelo(pasajerosAAgregar, vuelo, fallos);
            }
            if (huboFallo)
            {
                string mensaje = string.Empty;
                foreach (Pasaje item in fallos)
                {
                    mensaje += item.ToString();
                }
                throw new Exception($"Los siguientes pasajeros alcanzaron el limite de pasaje por vuelo{Environment.NewLine}{mensaje}");
            }
        }

        private static bool AgregarPasajeroListaDeVuelo(List<Pasaje> pasajerosAAgregar, Vuelo vuelo, List<Pasaje> fallos)
        {
            bool huboFallo = false;
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
            return huboFallo;
        }

        /// <summary>
        /// Verifica que el cliente no supere la cantidad maxima (5) de pasajes por vuelo
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajero"></param>
        /// <returns></returns>
        public static bool VerificarCantidadDePasajesPorCliente(Vuelo vuelo, Pasaje pasajero)
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
        /// <summary>
        /// Verifica que el cliente no supere la cantidad maxima (5) de pasajes por vuelo, sumando los que tiene ya en el carrito actualmente
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajero"></param>
        /// <param name="pasajerosParaAgregar"></param>
        /// <returns></returns>
        public static bool VerificarCantidadDePasajesPorCliente(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajerosParaAgregar)
        {
            bool puedeComprar = false;
            int contadorDePasajes = CalcularCantidadDelMismoPasajeEnListaPasajes(pasajero, pasajerosParaAgregar);
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
        
        /// <summary>
        /// Valida la cantidad de pasajeros de cierta clase con un lista que se encuentra en el carrito de compras actual
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajero"></param>
        /// <param name="pasajesAComprar"></param>
        /// <exception cref="Exception"></exception>
        public static void ValidarCompraDeClase(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajesAComprar)
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

        private static int CalcularCantidadDelMismoPasajeEnListaPasajes(Pasaje pasajero, List<Pasaje> pasajerosParaAgregar)
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
                BaseDeDatos.vuelosActivos.Add(vueloAAgregar);
            }
        }

        public static void BajaDeVuelo(Vuelo vueloAEliminar)
        {
            if (vueloAEliminar is not null)
            {
                BaseDeDatos.vuelosActivos.Remove(vueloAEliminar);
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

        public static Pasaje BuscarPasajePorCliente(Vuelo vuelo, Cliente cliente)
        {
            foreach (Pasaje item in vuelo.ListaDePasajeros)
            {
                if (item.Cliente.Equals(cliente))
                {
                    return item;
                }
            }
            return null;
        }

        public static DateTime FechaAleatoria()
        {
            Random rand = new Random();
            int año = rand.Next(1950, DateTime.Now.Year - 18);
            int mes = rand.Next(1, 12);
            int dia = rand.Next(1, 28);

            return new DateTime(año, mes, dia);
        }

        public static void InicializarListasDeVuelos()
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
        public static void ActualizarListaDeVuelos()
        {
            for (int i = 0; i < BaseDeDatos.vuelosActivos.Count; i++)
            {
                if (BaseDeDatos.vuelosActivos[i].Disponibilidad == "FINALIZADO")
                {
                    BaseDeDatos.vuelosHistorial.Add(BaseDeDatos.vuelosActivos[i]);
                    BaseDeDatos.vuelosActivos.RemoveAt(i);
                    i--;
                }
            }
        }
        public static Dictionary<string, string> CargarDiccionarioHistorialDeVuelosPorFacturacion()
        {
            Dictionary<string, double> destinoFacturadosDouble = new Dictionary<string, double>();
            foreach (string item in BaseDeDatos.localidades)
            {
                destinoFacturadosDouble.Add(item, 0);
            }
            AcumularValoresDeGanacia(destinoFacturadosDouble);
            return ConvertirConOrdenamientoDeStringDoubleAStringString(destinoFacturadosDouble);
        }
        private static void AcumularValoresDeGanacia(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                dic[item.Destino] += item.GananciaTotal();
            }
        }
        /// <summary>
        /// Recibe un diccionario lo ordena pasandolo a lista por facturacion ascendente y los convierte el double a string con formato de dinero
        /// mediante ConvertirDiccionarioPasarDoubleAString y OrdenarDiccionarioStringDoublePorValorAscendente
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private static Dictionary<string, string> ConvertirConOrdenamientoDeStringDoubleAStringString(Dictionary<string, double> dic)
        {
            List<KeyValuePair<string, double>> lista;

            lista = dic.ToList();
            lista.Sort(OrdenarDiccionarioStringDoublePorValorAscendente);
            return ConvertirDiccionarioPasarDoubleAString(lista);
        }
        /// <summary>
        /// Recibe una Lista(KeyValuePair) String Double y devuelve un diccionario String String con formato de dinero
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        private static Dictionary<string, string> ConvertirDiccionarioPasarDoubleAString(List<KeyValuePair<string, double>> lista)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> item in lista)
            {
                diccionario[item.Key] = $"$ {item.Value.ToString("0.00")} USD";
            }
            return diccionario;
        }

        private static int OrdenarDiccionarioStringDoublePorValorAscendente(KeyValuePair<string, double> p1, KeyValuePair<string, double> p2)
        {
            return (int)(p2.Value - p1.Value);
        }

        public static Dictionary<string, int> CargarDiccionarioClientesPorCantidadDeVuelos()
        {
            Dictionary<string, int> clientesCantidadVuelos = new Dictionary<string, int>();
            foreach (Cliente item in BaseDeDatos.clientes)
            {
                clientesCantidadVuelos.Add(item.ToString(), 0);
            }
            ContarPasajesPorCliente(clientesCantidadVuelos);
            return ConvertirConOrdenamientoDeStringIntAStringString(clientesCantidadVuelos);

        }
        private static void ContarPasajesPorCliente(Dictionary<string, int> clientesCantidadVuelos)
        {
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                foreach (Pasaje itemDelItem in item.ListaDePasajeros)
                {
                    clientesCantidadVuelos[itemDelItem.Cliente.ToString()]++;
                }
            }
        }
        /// <summary>
        /// Ordena un diccionario pasandolo a lista ascendente por valor que recibe por parametro y devuelve el diccionario alterado
        /// </summary>
        /// <param name="clientesCantidadVuelos"></param>
        /// <returns></returns>
        private static Dictionary<string, int> ConvertirConOrdenamientoDeStringIntAStringString(Dictionary<string, int> clientesCantidadVuelos)
        {
            List<KeyValuePair<string, int>> lista;

            lista = clientesCantidadVuelos.ToList();
            lista.Sort(OrdenarDiccionarioStringIntPorValorAscendente);
            return CargarDiccionarioStringInt(lista);
        }
        /// <summary>
        /// Recibe una lista (KeyValuePair) y lo convierte en diccionario
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        private static Dictionary<string, int> CargarDiccionarioStringInt(List<KeyValuePair<string, int>> lista)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in lista)
            {
                diccionario[item.Key] = item.Value;
            }
            return diccionario;
        }
        private static int OrdenarDiccionarioStringIntPorValorAscendente(KeyValuePair<string, int> p1, KeyValuePair<string, int> p2)
        {
            return p2.Value - p1.Value;
        }
        public static string BuscarDestinoFavorito()
        {
            string favorito = "Ninguno";
            int cantidadMayor = -1;
            bool primero = true;
            Dictionary<string, int> destinoFavorito = new Dictionary<string, int>();

            InicializarDestinosFavorito(destinoFavorito);
            ContarVuelosPorDesitno(destinoFavorito);
            foreach (KeyValuePair<string, int> item in destinoFavorito)
            {
                if (primero || cantidadMayor < item.Value)
                {
                    cantidadMayor = item.Value;
                    favorito = item.Key;
                    primero = false;
                }
            }
            return favorito;
        }
        private static void InicializarDestinosFavorito(Dictionary<string, int> destinoFavorito)
        {
            foreach (string item in BaseDeDatos.localidades)
            {
                destinoFavorito.Add(item, 0);
            }
        }
        private static void ContarVuelosPorDesitno(Dictionary<string, int> destinoFavorito)
        {
            foreach (Vuelo item in BaseDeDatos.vuelosTotales)
            {
                destinoFavorito[item.Destino]++;
            }
        }
        public static Dictionary<string, string> CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas()
        {
            Dictionary<string, double> horasDeAeronaves = new Dictionary<string, double>();
            foreach (Aeronave item in BaseDeDatos.aeronaves)
            {
                horasDeAeronaves.Add(item.Matricula, 0);
            }
            ContarHorasMinutos(horasDeAeronaves);
            return ConvertirDiccionarioYCalcularHorarioParaInformar(horasDeAeronaves);
        }
        private static void ContarHorasMinutos(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                dic[item.Aeronave.Matricula] += item.HoraDelVuelo + (double)item.MinutosDelVuelo / 60;
            }
        }
        private static Dictionary<string, string> ConvertirDiccionarioYCalcularHorarioParaInformar(Dictionary<string, double> horaAeronave)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string minutos;
            foreach (KeyValuePair<string, double> item in horaAeronave)
            {
                minutos = ((int)((item.Value - (int)item.Value) * 60)).ToString();
                if ((int)((item.Value - (int)item.Value) * 60) < 10)
                {
                    minutos = $"0{(int)((item.Value - (int)item.Value) * 60)}";
                }
                dict[item.Key] = $"{((int)item.Value)}:{minutos}";
            }
            return dict;
        }
        public static string InformarGananciaTotalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                ganancia += item.GananciaTotal();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        public static string InformarGananciaCabotajeDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                ganancia += item.GananciaCabotaje();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        public static string InformarGananciaInternacionalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in BaseDeDatos.vuelosHistorial)
            {
                ganancia += item.GananciaInternacional();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
    }
}
