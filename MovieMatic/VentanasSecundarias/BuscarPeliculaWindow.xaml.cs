using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Entidades;
using Logica;

namespace MovieMatic.VentanasSecundarias
{
    /// <summary>
    /// Interaction logic for BuscarPeliculaWindow.xaml
    /// </summary>
    public partial class BuscarPeliculaWindow : Window
    {
        Biblioteca _biblioteca;
        List<Pelicula> _pelisEncontradas = new List<Pelicula>();
        Pelicula _peliABuscar = new Pelicula();

        public BuscarPeliculaWindow(Biblioteca biblio)
        {
            _biblioteca = biblio;
            InitializeComponent();
        }

        public List<Pelicula> BuscarPorNombreButton_Click(object sender, RoutedEventArgs e)
        {
            _peliABuscar.Nombre = nombrePeliABuscarTextBox.Text;
            
            _pelisEncontradas =_biblioteca.ObtenerPeliculasPorNombre(Convert.ToString(_peliABuscar));

            return _pelisEncontradas;
        }

        private void BuscarPorDirectorButton_Click(object sender, RoutedEventArgs e)
        {
            _peliABuscar.Director = directorPeliABuscarTextBox.Text;
            
        }

        private void BuscarPeliPorAnioButton_Click(object sender, RoutedEventArgs e)
        {

            anioPeliABuscarComboBox.DataSource = ;
        }

        private void BuscarPeliPorGeneroButton_Click(object sender, RoutedEventArgs e)
        {
            generoPeliABuscarComboBox.DataSourse = ;
        }
    }
}
