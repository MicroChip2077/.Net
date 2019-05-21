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
    /// Lógica de interacción para MenuInicio.xaml
    /// </summary>
    public partial class MenuInicio : MetroWindow
    {
        public MenuInicio()
        {
            InitializeComponent();
            ClienteColleccion myClient = new ClienteColleccion();
            Application.Current.Resources["myClient"] = myClient;
            //CargaMuestras();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente _vistaAgregarCliente = new AgregarCliente();
            _vistaAgregarCliente.ShowDialog();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            ListarClientes _vistaListarClientes = new ListarClientes();
            _vistaListarClientes.ShowDialog();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            AgregarContrato _vistaAgregarContrato = new AgregarContrato();
            _vistaAgregarContrato.ShowDialog();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            ListarContrato _vistaListaDeContrato = new ListarContrato();
            _vistaListaDeContrato.ShowDialog();
        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
