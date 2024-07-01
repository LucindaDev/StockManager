using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_INVENTARIOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CatálogoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btninventario_Click(object sender, EventArgs e)
        {
            Inventario pantallaInventario = new Inventario();
            pantallaInventario.Show();
        }

        private void Btnperfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
        }

       

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            GestionDeProductos gestionDeProductos = new GestionDeProductos();
            gestionDeProductos.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            Conexion c = new Conexion(); 
        }
    }
}
