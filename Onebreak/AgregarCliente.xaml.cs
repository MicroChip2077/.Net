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
        public AgregarCliente()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            txtRut.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            txtNomContacto.Text = string.Empty;
            txtMailContacto.Text = string.Empty;
            
            
        }

        private void cargarActividad()
        {
            //ActividadEmpresa actEmp = new ActividadEmpresa();
            ////cmbxActividad.ItemsSource = actEmp.ReadAll();
            cmbxActividad.DisplayMemberPath = "Razon Social";

        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Rut = txtRut.Text;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.NombreContacto = txtNomContacto.Text;
            cliente.MailContacto = txtMailContacto.Text;
            cliente.Direccion =txtDireccion.Text;
            cliente.Telefono =txtTelefono.Text;
            cliente.IdActEmp = int.Parse(cmbxActividad.SelectedValue.ToString());
            cliente.IdEmp = int.Parse(cmbxTipo.SelectedValue.ToString());

            //en esta parte no me deja llamar a los metodos que realice en en clienteColleccion ****BuscarClientePorRut****
            Cliente cliente = ClienteColleccion.BuscarClientePorRut

        }

    }
    }
