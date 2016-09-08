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
    public partial class AgregarPeliculaWindow : Form
    {
        List<Actor> _actoresNuevos = new List<Actor>();
        Biblioteca _biblioteca;

        public AgregarPeliculaWindow(Biblioteca biblio)
        {
            _biblioteca = biblio;
            InitializeComponent();
        }
        


        private void AgregarActorButton_Click(object sender, EventArgs e)
        {
            Actor nuevoActor = new Actor();
            nuevoActor.NombreApellido = nombreApellidoTextBox.Text;

            _actoresNuevos.Add(nuevoActor);

            actoresNuevosComboBox.DataSource = null;
            actoresNuevosComboBox.DataSource = _actoresNuevos;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            Pelicula peliNueva = new Pelicula();

            peliNueva.Nombre = nombreTextBox.Text;
            peliNueva.Genero = generoTextBox.Text;
            peliNueva.Director = directorTextBox.Text;
            peliNueva.AnioEstreno = Convert.ToInt32(anioEstrenoTextBox.Text);
            peliNueva.Actores.AddRange(_actoresNuevos);
            peliNueva.Sinopsis = sinopsisRichTextBox.Text;

            _biblioteca.AgregarPelicula(peliNueva);

            Close();
        }
    }
}
