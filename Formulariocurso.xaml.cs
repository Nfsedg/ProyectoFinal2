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
    /// Lógica de interacción para Formulariocurso.xaml
    /// </summary>
    public partial class Formulariocurso : Page
    {
        
        public Formulariocurso()
        {
            InitializeComponent();
        }
        CursosServices profesorService = new CursosServices(null);

        private void Guardar1(object sender, RoutedEventArgs e)
        {
            Curso curso = new Curso();
            curso.Nombre = txtNombre.Text;
            curso.Fecha = DateTime.Now;
            curso.NumHoras = int.Parse(txtNumHor.Text);
            curso.Matricula = txtMatricula.Text;
            if(online.IsChecked == true)
            {
                curso.TipoCurso = "Curso Online";
            } else if(presencial.IsChecked == true)
            {
                curso.TipoCurso = "Curso Presencial";
            }

            var respuesta = profesorService.CrearProfesor(curso);
            if (respuesta.Correcto)
            {
                MessageBox.Show(respuesta.Mensaje, "Informacion");
                txtNombre.Clear();
                txtNumHor.Clear();
                txtMatricula.Clear();
                online.IsChecked= false;
                presencial.IsChecked = false;
            }
        }
    }
}
