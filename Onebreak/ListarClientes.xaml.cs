using System;
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
    /// Lógica de interacción para ListarClientes.xaml
    /// </summary>
    public partial class ListarClientes : MetroWindow
    {
        public ListarClientes()
        {
            InitializeComponent();
            MostrarCliente();
            
        }

        private void MostrarCliente()
        {
            ClienteColleccion myClient = (ClienteColleccion)Application.Current.Resources["myClient"];
            dgridCliente.ItemsSource = myClient;
            dgridCliente.Items.Refresh();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente _vistaAgregarCliente = new AgregarCliente(string.Empty);
            _vistaAgregarCliente.ShowDialog();
            
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            ClienteColleccion myClient = (ClienteColleccion)Application.Current.Resources["myClient"];
            dgridCliente.ItemsSource = myClient.BuscarPosicionRut(txtBuscarPorRut.Text);
            dgridCliente.Items.Refresh();

        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = (Cliente)dgridCliente.SelectedItem;
            AgregarCliente agreeForm = new AgregarCliente(cli.Rut);
            agreeForm.ShowDialog();
            MostrarCliente();
        }
    }
}
