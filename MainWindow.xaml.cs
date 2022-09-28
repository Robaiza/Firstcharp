using LiveCharts;
using LiveCharts.Wpf;
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
using TabLenguajesProgra.Pantallas;

namespace Tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProgramasEntretenimiento programasEntretenimiento = new ProgramasEntretenimiento();
        LenguajesProgramacion lenguajesProgramacion = new LenguajesProgramacion();
        Libros libros = new Libros(); Page1 Page1 = new Page1();


        public MainWindow()
        {
            InitializeComponent();
            MyFrame.NavigationService.Navigate(programasEntretenimiento);

            MyFrame.NavigationService.Navigate(Page1);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(programasEntretenimiento);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(libros);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(lenguajesProgramacion);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(Page1);
        }
    }
}
