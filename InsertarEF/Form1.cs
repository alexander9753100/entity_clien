using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertarEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ProductoRepository pR = new ProductoRepository();

        private Productos CrearProducto()
        {
            var producto = new Productos
            {
                Id = int.Parse(txbIDProducto.Text),
                Nombre = txbNombre.Text,
                Descripcion = txbDescripcion.Text,
                Precio = decimal.Parse(txbPrecio.Text),
                Stock = int.Parse(txbStock.Text),
                Marca = txbMarca.Text,
                Categoria = txbCategoria.Text,
            };
            return producto;
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            var producto = CrearProducto();
            var resultado = pR.InsertarProducto(producto);
            MessageBox.Show($"Se inserto {resultado}");
        }

        private void btnBuscarporID_Click(object sender, EventArgs e)
        {
            var producto = pR.ObtenerPorId(Int32.Parse(txbBuscarPorID.Text));
            List<Productos> lista = new List<Productos> { producto };
            dgvProductos.DataSource = lista;
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var producto = pR.ObtenerTodo();
            dgvProductos.DataSource = producto;
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y el carácter de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }

        private void txbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un control (como Backspace) y no es un dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }

        private void txbIDProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un control (como Backspace) y no es un dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }
    }
}
