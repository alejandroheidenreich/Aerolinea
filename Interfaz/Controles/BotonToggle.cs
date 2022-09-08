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
    //BotonToggle hereda de CheckBox
    public class BotonToggle : CheckBox
    {
        //atributos inciales de colores
        private Color encendidoSlideColor = Color.MediumSlateBlue;
        private Color encendidoCirculoColor = Color.WhiteSmoke;
        private Color apagadoSlideColor = Color.Gray;
        private Color apagadoCirculoColor = Color.Gainsboro;

        // construtor
        public BotonToggle()
        {
            //inicializa el tamaño minimo del boton
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
            get { return apagadoSlideColor; }
            set
            {
                apagadoSlideColor = value;
                this.Invalidate();
            }
        }
        public Color ApagadoCirculoColor 
        { 
            get { return apagadoCirculoColor; }
            set { apagadoCirculoColor = value; this.Invalidate(); }
        }

        public override string Text 
        {
            get { return base.Text; }
        }
        private GraphicsPath GetGraphicsPath()
        {
            int tamDelArco = this.Height - 1;
            Rectangle arcoIzq = new Rectangle(0, 0, tamDelArco, tamDelArco);
            Rectangle arcoDer = new Rectangle(this.Width - tamDelArco -2, 0, tamDelArco, tamDelArco);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(arcoIzq, 90, 180);
            path.AddArc(arcoDer, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int tamToggle = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) // encendido
            {
                // dibujar fondo
                pevent.Graphics.FillPath(new SolidBrush(encendidoSlideColor),GetGraphicsPath());
                // dibujar circulo
                pevent.Graphics.FillEllipse(new SolidBrush(encendidoCirculoColor), new Rectangle(this.Width - this.Height + 1, 2, tamToggle, tamToggle));
            }
            else // apagado
            {
                // dibujar fondo
                pevent.Graphics.FillPath(new SolidBrush(apagadoSlideColor), GetGraphicsPath());
                // dibujar circulo
                pevent.Graphics.FillEllipse(new SolidBrush(apagadoCirculoColor), new Rectangle(2, 2, tamToggle, tamToggle));
            }
        }
        
    }
}
