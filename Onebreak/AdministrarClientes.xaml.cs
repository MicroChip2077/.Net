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

namespace Onebreak
{
    /// <summary>
    /// Lógica de interacción para AdministrarClientes.xaml
    /// </summary>
    public partial class AdministrarClientes : MetroWindow
    {

        public AdministrarClientes()
        {
            InitializeComponent();
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            //clienteColleccion Kcliente = (clienteColleccion)Application.Current.Resources["kcliente"];
            //dgCliente.ItemsSource = Kcliente;
            //dgCliente.Items.Refresh();
        }


        private void Btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            //clienteColleccion Kcliente = (clienteColleccion)Application.Current.Resources["kcliente"];
            //dgCliente.ItemsSource = kcliente.BuscarClienteRut(tbx_rut.Text);
            //dgCliente.Items.Refresh();
        }

        private void Btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            MostrarCliente();
        }

        private void Btn_agre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Editar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
