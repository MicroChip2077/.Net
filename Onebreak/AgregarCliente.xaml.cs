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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using ModeloOnBreak;


namespace Onebreak
{
    /// <summary>
    /// Lógica de interacción para AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : MetroWindow
    {
        public AgregarCliente(string buscarRut)
        {
            InitializeComponent();
            btnAgregar.Visibility = Visibility.Visible;
            btnModificar.Visibility = Visibility.Hidden;
            ClienteColleccion misPersonas = (ClienteColleccion)Application.Current.Resources["myClient"];

            if (buscarRut.Equals(string.Empty))
            {
                btnAgregar.Visibility = Visibility.Visible;
                btnEliminar.Visibility = Visibility.Hidden;
            }
            else
            {
                btnModificar.Visibility = Visibility.Visible;
                ClienteColleccion myClient = (ClienteColleccion)Application.Current.Resources["myClient"];
                Cliente cli = myClient.BuscarElRut(buscarRut);
                txtRut.IsEnabled = false;
                txtRut.Text = buscarRut;
                txtNombre.Text = cli.NombCli;
                txtApellido.Text = cli.Apellido;
                dpFechanacimiento.SelectedDate = cli.FechaNacimiento;
                txtEstatura.Text = cli.Estatura.ToString();

            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClienteColleccion myClient = (ClienteColleccion)Application.Current.Resources["myclient"];
                Cliente cli = myClient.BuscarElRut(txtRut.Text);

                MessageBoxResult delete = MessageBox.Show(
                    "¿Está Seguro de eliminar a este cliente?",
                    "Confirmar",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (delete == MessageBoxResult.Yes)
                {
                    myClient.Remove(cli);
                    MessageBox.Show("Cliente Eliminado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Persona no encontrada", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (!_sValidado())
            {
                return;
            }
            Cliente buscCliente = new Cliente();
            ClienteColleccion myClient =  (ClienteColleccion)Application.Current.Resources["myClient"];

            buscCliente = myClient.BuscarElRut(txtRut.Text);
            if (buscCliente != null)
            {
                await this.ShowMessageAsync("Mensaje :", "Ya existe una persona con este rut.");
                return;
            }
            /*Creando instancia cliente*/
            Cliente cli = new Cliente();

            //Capturando datos desde los controles
            cli.Rut = txtRut.Text;
            cli.NombCli = txtNombre.Text;
            cli.Apellido = txtApellido.Text;
            cli.Estatura = double.Parse(txtEstatura.Text.Replace(".",","));
            cli.FechaNacimiento = (DateTime)dpFechanacimiento.SelectedDate;
            
            /*Agregar a la coleccion*/
            myClient.Add(cli);
            MessageBox.Show("Persona Agregada");

        }


        private async void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!_sValidado())
                {
                    return;
                }
                ClienteColleccion myClient = (ClienteColleccion)Application.Current.Resources["Myclient"];
                Cliente cli = myClient.BuscarElRut(txtRut.Text);

                cli.NombCli = txtNombre.Text;
                cli.Apellido = txtApellido.Text;
                cli.Estatura = double.Parse(txtEstatura.Text);
                cli.FechaNacimiento = (DateTime)dpFechanacimiento.SelectedDate;
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Mensaje :", "Persona No Econtrada.");

            }
        }
        bool _sValidado()
        {
            if (txtRut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mensaje : Por Favor Ingrese el rut");
                return false;
            }

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mensaje : Por Favor Ingrese Nombre");
                return false;
            }

            if (txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mensaje : Por Favor Ingrese Apellido");
                return false;
            }

            /*condición estatura*/
            if (txtEstatura.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Mensaje : Por Favor ingrese Estatura");
                return false;
            }
            try
            {
                double estatura = double.Parse(txtEstatura.Text);
                if (estatura < 0.9)
                {
                    MessageBox.Show("Mensaje : La estatura debe ser mayor a 90 cm");
                    return false;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Mensaje :Debe Ingresar una estatura Válida");
                return false;
            }

            if (dpFechanacimiento.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Mensaje : Por Favor Ingrese fecha menor a Hoy");
                return false;
            }
            return true;
        }

        private void BtnEliminar_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnModificar_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    }
