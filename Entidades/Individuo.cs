using System;
using System.Text;

namespace Entidades
{
    public abstract class Individuo
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;
        private string email;

        protected Individuo(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email)
        {
            ValidarCampoString(nombre, out this.nombre);
            //this.nombre = nombre;
            ValidarCampoString(apellido, out this.apellido);
            //this.apellido = apellido;
            //ValidarDateTime(fechaDeNacimiento, out this.fechaDeNacimiento);
            this.fechaDeNacimiento = fechaDeNacimiento;
            ValidarCampoEntero(dni, out this.dni);
            //this.dni = dni;
            ValidarCampoString(email, out this.email);
            //this.email = email;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime Nacimiento
        {
            get => fechaDeNacimiento;
            set => fechaDeNacimiento = value;
        }
        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        public int Edad => CalcularEdad(fechaDeNacimiento);

        public string Email
        {
            get => email;
            set => email = value;
        }

        private static int CalcularEdad(DateTime nacimiento)
        {
            int edad;
            edad = DateTime.Now.Year - nacimiento.Year;
            if (nacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        private void ValidarCampoString(string campo, out string campoValidado)
        {
            campoValidado = string.Empty;
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("No se admiten campos nulos.");
            }
            campoValidado = campo;
        }

        private void ValidarCampoEntero(int campo, out int campoValidado)
        {
            campoValidado = -1;
            if (string.IsNullOrEmpty(campo.ToString()))
            {
                throw new Exception("No se admiten campos nulos.");
            }
            campoValidado = campo;
        }

        private void ValidarDateTime(DateTime fecha, out DateTime fechaValidado)
        {
            //TODO: arreglar validacion de data time
            fechaValidado = DateTime.MaxValue;
            if (fecha > DateTime.MinValue && fecha < DateTime.MaxValue)
            {
                throw new Exception("No se admiten campos nulos.");
            }
            fechaValidado = fecha;
        }

        public static bool operator ==(Individuo p1, Individuo p2)
        {
            bool sonIguales = false;
            if (p1.dni == p2.dni)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool operator !=(Individuo p1, Individuo p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            Individuo p = obj as Individuo;
            return p is not null && this == p;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        public virtual string Mostrar()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Edad: {this.Edad}");

            return sb.ToString();
        }

       
    }
}
