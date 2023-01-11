using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Core.Entidades;


namespace WindowsApp
{
    public partial class WindowsApp : Form
    {
        public WindowsApp()
        {
            InitializeComponent();
        }

        private void MostrarProductos(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Nombre = "Laptop",
                Descripcion = "Laptop HP",
                PrecioCosto = 2000,
                Margen = 20,
                IVA = 0.21,
                Proveedor = "Importadora .NET",
                Categoria = "Tecnologia",
                Subcategoria = "N/A"
            };

            MessageBox.Show($"Producto: {Environment.NewLine}\n{p}");          
        }

        private void MostrarClientes(object sender, EventArgs e)
        {
            ClienteIndividuo cliInd = new ClienteIndividuo()
            {
                Nombre = "Samuel",
                Apellido = "Rivera",
                CUIT = "20-00000000-1",
                Email = "email@email.com",
                Telefono = "11 1234-5678",
                Direccion = "CABA"
            };

            MessageBox.Show($"Cliente: {Environment.NewLine}\n{cliInd}");
        }     
    }
}
