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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource peliculaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peliculaViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // peliculaViewSource.Source = [origen de datos genérico]
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
