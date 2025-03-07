using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Cocodrilo
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int botonPeligroso;
        Jugador Jugador1 = new Jugador();
        Jugador Jugador2 = new Jugador();
        Jugador Jugador3 = new Jugador();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // numero random que va del 1 al 7 que coicide con los tag de los botones
            botonPeligroso = random.Next(1, 8);

            // Imagen
            picImagen.Image = Image.FromFile(@"C:\Users\ericb\OneDrive\Imágenes\Descargas\crocodile-dentist.jpg");
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnDiente1_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente1.Tag.ToString());
            Diente diente = new Diente(btnDiente1, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente2_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente2.Tag.ToString());
            Diente diente = new Diente(btnDiente2, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente3_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente3.Tag.ToString());
            Diente diente = new Diente(btnDiente3, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente4_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente4.Tag.ToString());
            Diente diente = new Diente(btnDiente4, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente5_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente5.Tag.ToString());
            Diente diente = new Diente(btnDiente5, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente6_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente6.Tag.ToString());
            Diente diente = new Diente(btnDiente6, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private void btnDiente7_Click(object sender, EventArgs e)
        {
            int numeroBoton = int.Parse(btnDiente7.Tag.ToString());
            Diente diente = new Diente(btnDiente7, numeroBoton);
            diente.Comprobar(botonPeligroso);
        }

        private int jugadorActual = 1; // Variable para llevar el control del jugador actual

        private void btnJugadores_Click(object sender, EventArgs e)
        {

            switch (jugadorActual)
            {
                case 1:
                    Jugador1.NombreJugador = txtNombreJugadores.Text;
                    lblJugador1.Text = Jugador1.NombreJugador;
                    break;
                case 2:
                    Jugador2.NombreJugador = txtNombreJugadores.Text;
                    lblJugador2.Text = Jugador2.NombreJugador;
                    break;
                case 3:
                    Jugador3.NombreJugador = txtNombreJugadores.Text;
                    lblJugador3.Text = Jugador3.NombreJugador;
                    break;
                default:
                    MessageBox.Show("Ya se han registrado los tres jugadores.");
                    return;
            }

            txtNombreJugadores.Clear();
            jugadorActual++;
        }
    }
}
