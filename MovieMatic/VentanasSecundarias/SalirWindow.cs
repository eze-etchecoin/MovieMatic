using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace MovieMatic.VentanasSecundarias
{
    public partial class SalirWindow : Form
    {
        private Biblioteca _biblioteca;

        public SalirWindow(Biblioteca biblio)
        {
            _biblioteca = biblio;
            InitializeComponent();
        }
        
        private void NoSalirButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void SiSalirButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            EntityPersistor<Pelicula> persistPelis = new EntityPersistor<Pelicula>();
            EntityPersistor<Actor> persistActores = new EntityPersistor<Actor>();
            persistPelis.Grabar(_biblioteca.ObtenerPeliteca());
            persistActores.Grabar(_biblioteca.ObtenerListaActores());
            Close();
        }

        private void CancelarSalirButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RespaldarSalirLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
