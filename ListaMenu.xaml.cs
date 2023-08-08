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
using WPF_APP.Modelos;
using WPF_APP.Service;

namespace WPF_APP
{
    /// <summary>
    /// Lógica de interacción para ListaMenu.xaml
    /// </summary>
    public partial class ListaMenu : Page
    {

        private ProfesorService profesorService = new ProfesorService(null);

        public ListaMenu()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Content = new Formulario();
        }

        public void CargarDatos()
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores = profesorService.ObtenerLista();
            dg_Profesores.ItemsSource = profesores;
        }

        private void Editar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            MainWindow.frame.Content = new Formulario(id);
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            MessageBoxResult result = MessageBox.Show("¿Estas seguro que deseas eliminar este registro","Mensaje",MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes)
            {
                var resultado = profesorService.EliminarProfesor(id);

                if (resultado.Correcto)
                {
                    MessageBox.Show(resultado.Mensaje,"Mensaje");
                    MainWindow.frame.Content = new ListaMenu();
                }
            }
        }

        private void Curso_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Content = new Formulariocurso();
        }
    }
}
