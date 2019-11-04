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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SuperHeroe hero;
      
        public MainWindow()
        {
            InitializeComponent();
            hero = SuperHeroe.GetSample();      
            NombreTextBlock.DataContext = hero;
            EnemigoTextBlock.DataContext = hero;
            VengadoresTextBlock.DataContext = hero;
            FotoImage.DataContext = hero;
            
            
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            NombreTextBox.DataContext = hero;
            EnemigoTextBox.DataContext = hero;
            FotoTexBox.DataContext = hero;
            VengadoresCheckBox.DataContext = hero;
         


        }
    }
}
