using MiniCrudApp.Controllers;
using MiniCrudApp.Models;

namespace MiniCrudApp
{
    public partial class Form1 : Form
    {
        private readonly ProductoController pController = new ProductoController();
        public Form1()
        {
            InitializeComponent();
            RefreshProductList();
        }

        private void RefreshProductList()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = pController.ObtainProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtNombre.Text;
                decimal price = decimal.Parse(txtPrecio.Text);

                pController.AddProduct(id, name, price);
                RefreshProductList();
                MessageBox.Show("Product added!");
                MessageBox.Show("Total products: " + pController.ObtainProducts().Count());

            }
            catch (Exception ex)
            {
                MessageBox.Show("[ERROR]: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtNombre.Text;
                decimal price = decimal.Parse(txtPrecio.Text);

                bool edited = pController.EditProduct(id, name, price);
                if (edited)
                {
                    RefreshProductList();
                    MessageBox.Show("Product updated!");
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                bool deleted = pController.DeleteProduct(id);
                if (deleted)
                {
                    RefreshProductList();
                    MessageBox.Show("Product deleted!");
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is Producto selectedProduct)
            {
                txtID.Text = selectedProduct.ID.ToString();
                txtNombre.Text = selectedProduct.Name;
                txtPrecio.Text = selectedProduct.Price.ToString();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
