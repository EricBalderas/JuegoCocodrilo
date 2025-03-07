using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Cocodrilo
{
    internal class Jugador
    {
        private string _strJugador;

        public string jugador
        {
            get { return _strJugador; }
            set { _strJugador = value; }
        }

        private string _strNombreJugador;

        public string NombreJugador
        {
            get { return _strNombreJugador; }
            set { _strNombreJugador = value; }
        }


        private int _intVida = 1;

        public int Vida
        {
            get { return _intVida; }
            set { _intVida = value; }
        }

        public void Perder()
        {

            if (Vida > 0)
            {
                Vida = Vida - 1;
            }
            else
            {
                Vida = 1;
            }
        }

    }
}
