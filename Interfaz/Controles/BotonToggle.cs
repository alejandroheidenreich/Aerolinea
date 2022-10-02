using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Security.Permissions;

namespace Interfaz.Controles
{
    public class BotonToggle : CheckBox
    {
        private Color encendidoSlideColor = Color.MediumSlateBlue;
        private Color encendidoCirculoColor = Color.WhiteSmoke;
        private Color apagadoSlideColor = Color.Gray;
        private Color apagadoCirculoColor = Color.Gainsboro;

        // construtor
        public BotonToggle()
        {
            this.MinimumSize = new Size(45,22);
        }
        public Color EncendidoSlideColor 
        { 
            get 
            { 
                return encendidoSlideColor; 
            }
            set 
            { 
                encendidoSlideColor = value;
                this.Invalidate();//Invalida toda la superficie del control y hace que se vuelva a dibujar el mismo
            }
        }
        public Color EncendidoCirculoColor 
        { 
            get 
            { 
                return encendidoCirculoColor; 
            }
            set 
            {
                encendidoCirculoColor = value; 
                this.Invalidate(); 
            }
        }
        public Color ApagadoSlideColor 
        { 
            get 
            { 
                return apagadoSlideColor; 
            }
            set
            {
                apagadoSlideColor = value;
                this.Invalidate();
            }
        }
        public Color ApagadoCirculoColor 
        { 
            get 
            { 
                return apagadoCirculoColor; 
            }
            set 
            { 
                apagadoCirculoColor = value; this.Invalidate(); 
            }
        }

        public override string Text 
        {
            get 
            { 
                return base.Text; 
            }
        }
        /// <summary>
        /// Clase para poder dibujar figuras, compuestas por lineas y curvas
        /// Este metodo crea las caracteristicas del ciruclo para el control
        /// </summary>
        /// <returns></returns>
        private GraphicsPath ObtenerFormatoGrafico()
        {
            int tamDelArco = this.Height - 1;
            Rectangle arcoIzq = new Rectangle(0, 0, tamDelArco, tamDelArco);
            Rectangle arcoDer = new Rectangle(this.Width - tamDelArco -2, 0, tamDelArco, tamDelArco);

            GraphicsPath forma = new GraphicsPath();
            forma.StartFigure();
            forma.AddArc(arcoIzq, 90, 180);
            forma.AddArc(arcoDer, 270, 180);
            forma.CloseFigure();

            return forma;
        }

        /// <summary>
        /// Sobrecarga del metodo OnPaint para actualizar la forma que se pintara el checkbox dentro de formulario cada vez que es interactuado
        /// PaintEventArgs es una clase para dibujar rectangulos en el formulario
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int tamToggle = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)//encendido
            {
                // dibujar fondo
                pevent.Graphics.FillPath(new SolidBrush(encendidoSlideColor), ObtenerFormatoGrafico());
                // dibujar circulo
                pevent.Graphics.FillEllipse(new SolidBrush(encendidoCirculoColor), new Rectangle(this.Width - this.Height + 1, 2, tamToggle, tamToggle));
            }
            else // apagado
            {
                // dibujar fondo
                pevent.Graphics.FillPath(new SolidBrush(apagadoSlideColor), ObtenerFormatoGrafico());
                // dibujar circulo
                pevent.Graphics.FillEllipse(new SolidBrush(apagadoCirculoColor), new Rectangle(2, 2, tamToggle, tamToggle));
            }
        }
        
    }
}
