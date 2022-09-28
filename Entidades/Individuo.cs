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
            ValidarCampoString(apellido, out this.apellido);
            ValidarDateTime(fechaDeNacimiento, out this.fechaDeNacimiento);
            ValidarCampoDni(dni, out this.dni);
            ValidarCampoEmail(email, out this.email);
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

        public int Edad => CalcularEdad(this.fechaDeNacimiento);

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

        private void ValidarCampoEmail(string email, out string emailValidado)
        {
            emailValidado = string.Empty;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new Exception("No es un email valido.");
            }
            emailValidado = email;
        }

        private void ValidarCampoDni(int dni, out int dniValidado)
        {
            dniValidado = -1;
            if (dni < 1000000 || dni > 99999999)
            {
                throw new Exception("No es un dni valido.");
            }
            dniValidado = dni;
        }

        private void ValidarDateTime(DateTime fecha, out DateTime fechaValidado)
        {
            fechaValidado = DateTime.MinValue;
            if (CalcularEdad(fecha) < 18)
            {
                throw new Exception("Debe ser mayor de 18 años.");
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
