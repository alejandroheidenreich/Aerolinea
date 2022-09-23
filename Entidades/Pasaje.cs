using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum ClaseDePasajero
    {
        Tursita,
        Premium
    }
    public class Pasaje
    {
        private string idRegistro;
        private Cliente cliente;
        private Vuelo vuelo;
        private ClaseDePasajero claseDePasajero;
        private bool equipajeDeMano;
        private List<double> equipajeDeBodega;
        private int equipajesMaximos;
        private double pesoAdicional;

        // equipaje pesaje o bultos? validarlo se puede pasar de mas y cobrar adicional

        // un cliente se puede comprar todos los pasajes? se lo puede comprar

        public Pasaje(Cliente cliente, ClaseDePasajero claseDePasajero)
        {
            this.idRegistro = GenerarRegsitro();
            this.cliente = cliente;
            this.claseDePasajero = claseDePasajero;
            this.equipajesMaximos = 4;
            this.pesoAdicional = 0;
        }

        public string IdRegistro
        {
            get => idRegistro;
            set => idRegistro = value;
        }

        public ClaseDePasajero Clase
        {
            get => claseDePasajero;
            set => claseDePasajero = value;
        }
        public Cliente Cliente
        {
            get => cliente;
            set => cliente = value;
        }
        public bool EquipajeDeMano
        {
            get => equipajeDeMano;
            set => equipajeDeMano = value;
        }
        public double PesoAdicional
        {
            get
            {
                CalcularPesoEquipajeAdicional();
                return pesoAdicional;
            }
        }

        public void AgregarEquipaje(double pesoValija)
        {
            if (equipajeDeBodega.Count == equipajesMaximos)
            {
                equipajeDeBodega.Add(pesoValija);
            }
            else
            {
                throw new Exception("Llego al maximo de equipajes en bodega");
            }
        }

        private void CalcularPesoEquipajeAdicional()
        {
            if (this.claseDePasajero == ClaseDePasajero.Tursita && this.equipajeDeBodega.Count > 1)
            {
                for (int i = 1; i < this.equipajeDeBodega.Count; i++)
                {
                    this.pesoAdicional += this.equipajeDeBodega[i];
                }
            }
            else if (this.claseDePasajero == ClaseDePasajero.Premium && this.equipajeDeBodega.Count > 2)
            {
                for (int i = 1; i < this.equipajeDeBodega.Count; i++)
                {
                    this.pesoAdicional += this.equipajeDeBodega[i];
                }
            }
        }

        private string GenerarRegsitro()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] matriculaArray = new char[6];
            Random random = new Random();

            for (int i = 0; i < matriculaArray.Length; i++)
            {
                matriculaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new String(matriculaArray);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Registro: {this.idRegistro} - ");
            sb.AppendLine(this.claseDePasajero.ToString());
            sb.AppendLine(this.cliente.ToString());

            return sb.ToString();
        }

    }
}
