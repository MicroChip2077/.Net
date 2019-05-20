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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace Onebreak
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (textUsuario.Text == "ADMIN" && textPass.Text == "ADMIN" || textUsuario.Text == "ROOT" && textPass.Text == "ROOT")
            {
                await this.ShowMessageAsync("Exito", "Datos Validados");
                MenuInicio _mostrarNuevaView = new MenuInicio();
                this.Close();
                _mostrarNuevaView.ShowDialog();
            }else{
                await this.ShowMessageAsync("Error", "¡ Verifica los datos ingresados !");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


