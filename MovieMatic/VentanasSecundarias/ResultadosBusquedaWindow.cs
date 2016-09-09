using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace MovieMatic.VentanasSecundarias
{
    public partial class ResultadosBusquedaWindow : Form
    {
        Biblioteca _biblioteca;
        int _botonElegido;

        public ResultadosBusquedaWindow(Biblioteca biblio, int boton)
        {
            _biblioteca = biblio;
            _botonElegido = boton;
            InitializeComponent();
        }




    }
}
