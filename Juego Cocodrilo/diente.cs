using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Cocodrilo
{
    public class Diente
    {
        private Button boton;
        private int numeroBoton;

        public Diente(Button boton, int numeroBoton)
        {
            this.boton = boton;
            this.numeroBoton = numeroBoton;
        }

        public void Comprobar(int botonPeligroso)
        {
            if (numeroBoton != botonPeligroso)
            {
                MessageBox.Show($"!Estas a salvo! ", "Cocodrilo Dentista",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                boton.BackColor = Color.Green;
                boton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Haz sido eliminado!", "Cocodrilo Dentista",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boton.BackColor = Color.Red;
                boton.Enabled = false;
            }
        }
    }
}

