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
    /// Lógica de interacción para Formulario.xaml
    /// </summary>
    public partial class Formulario : Page
    {
        private ProfesorService profesorService = new ProfesorService(null);
        public int id = 0;
        public Formulario(int id = 0)
        {
            InitializeComponent();
            this.id = id;

            if(id != 0)
            {
                CargarProfesor(id);
            }
        }

        public void CargarProfesor(int id)
        {
            var profesor = profesorService.ObtenerPorId(id);
            txtNombre.Text = profesor.Nombre;
            txtApellidos.Text = profesor.Apellidos;
            txtEspecialización.Text = profesor.Especializacion;
            txtNumEmpleados.Text = profesor.NumEMpleado;
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            if(id == 0)
            {
                Profesor profesor = new Profesor();
                profesor.Nombre = txtNombre.Text;
                profesor.Apellidos = txtApellidos.Text;
                profesor.Especializacion = txtEspecialización.Text;
                profesor.NumEMpleado = txtNumEmpleados.Text;

                var respuesta = profesorService.CrearProfesor(profesor);

                if (respuesta.Correcto)
                {
                    MessageBox.Show(respuesta.Mensaje, "Informacion");
                    MainWindow.frame.Content = new ListaMenu();
                }
            }
            else
            {
                var profesor = profesorService.ObtenerPorId(id);
                profesor.Nombre = txtNombre.Text;
                profesor.Apellidos = txtApellidos.Text;
                profesor.Especializacion = txtEspecialización.Text;
                profesor.NumEMpleado = txtNumEmpleados.Text;

                var resultado = profesorService.ActualizarProfesor(profesor);
                if (resultado.Correcto)
                {
                    MessageBox.Show(resultado.Mensaje, "Mensaje");
                    MainWindow.frame.Content = new ListaMenu();
                }
                
            }
            
        }
    }
}
