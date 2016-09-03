﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Logica;
using Entidades;

namespace MovieMatic
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Biblioteca _biblioteca;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource peliculaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peliculaViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // peliculaViewSource.Source = [origen de datos genérico]

            _biblioteca = new Biblioteca();

            Actor depp = new Actor();
            depp.NombreApellido = "Johnny";

            Actor jim = new Actor();
            jim.NombreApellido = "Carrey";

            Pelicula peli = new Pelicula();
            peli.Nombre = "El mejor día de tu vida";
            peli.AnioEstreno = 2011;
            peli.Genero = "Comedia";

            peli.Actores.Add(depp);
            peli.Actores.Add(jim);

            _biblioteca.AgregarPelicula(peli);
            

            peliculaViewSource.Source = _biblioteca.ObtenerPelisOrdenadas();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var salir = new VentanasSecundarias.SalirWindow(_biblioteca);
            if(salir.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                Close();
            }
            

        }
    }
}
