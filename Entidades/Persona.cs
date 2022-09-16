using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;
        private string email;

        protected Persona(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
            this.email = email;
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
        public DateTime FechaDeNacimiento
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

        public static bool operator ==(Persona p1, Persona p2)
        {
            bool sonIguales = false;
            if (p1.dni == p2.dni)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            Persona p = obj as Persona;
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
