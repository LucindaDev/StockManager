using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_INVENTARIOS
{
    public partial class GestionDeProductos : Form
    {
        public GestionDeProductos()
        {
            InitializeComponent();
            CargarDatosGrupos();
        }

        private void RbGestionDeGrupos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGestionDeGrupos.Checked == true)
            {
                btnAgregar.Text = "Agregar Grupo";
                lblNombreGrupo.Visible = true;
                txtNombreGrupo.Visible = true;
                lblnombreProducto.Visible = false;
                txtNombreProducto.Visible = false;
                lblCantidadProducto.Visible = false;
                txtCantidad.Visible = false;
                lblCantidadProxTerminarProducto.Visible = false;
                txtCantidadProxTerminar.Visible = false;
                dgvListadoGrupos.Visible = true;
                dgvListadoProductos.Visible = false;
            }

        }

        private void RbGestionDeProductos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosProductos();
            if (rbGestionDeProductos.Checked)
            {
                btnAgregar.Text = "Agregar Producto";
                lblnombreProducto.Visible = true;
                txtNombreProducto.Visible = true;
                lblCantidadProducto.Visible = true;
                txtCantidad.Visible = true;
                lblCantidadProxTerminarProducto.Visible = true;
                txtCantidadProxTerminar.Visible = true;
                lblNombreGrupo.Visible = false;
                txtNombreGrupo.Visible = false;
                dgvListadoGrupos.Visible=false;
                dgvListadoProductos.Visible=true;
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();

            string RowId = dgvListadoProductos.SelectedCells[0].Value.ToString();
            string eliminar = string.Format("DELETE FROM inventario WHERE Id = {0}", RowId);

            SqlCommand comando = new SqlCommand(eliminar, conexion);
            comando.ExecuteNonQuery();
            CargarDatosProductos();
            Limpiar();

            MessageBox.Show("Producto eliminado con éxito");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (txtNombreProducto.Text != "" && txtCantidad.Text != "" && txtCantidadProxTerminar.Text != "")
            {
                string agregar = string.Format("INSERT INTO inventario (producto, cantidad) VALUES ('{0}', '{1}','{2}')", txtNombreProducto.Text, txtCantidad.Text, txtCantidadProxTerminar.Text);
                
                SqlConnection conexion = c.CrearConexion();

                SqlCommand comando = new SqlCommand(agregar,conexion);
                comando.ExecuteNonQuery();
                CargarDatosProductos();
                MessageBox.Show("Producto agregado con éxito");

            }
            if (txtNombreGrupo.Text != "")
            {
                string agregar = string.Format("INSERT INTO grupos (grupo) VALUES ('{0}')", txtNombreGrupo.Text);

                SqlConnection conexion = c.CrearConexion();

                SqlCommand comando = new SqlCommand(agregar, conexion);
                comando.ExecuteNonQuery();
                CargarDatosGrupos();
                MessageBox.Show("Grupo Agregado con éxito");

            }

            Limpiar();

        }

        private void Limpiar()
        {
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtNombreGrupo.Text = "";
        }
        private void dgvListadoGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreGrupo.Text = dgvListadoGrupos.SelectedCells[1].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtCantidadProxTerminar.Enabled = true;
            txtNombreGrupo.Enabled = true;



        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();
            string RowId = dgvListadoProductos.SelectedCells[0].Value.ToString();

            string actualizar = string.Format("UPDATE inventario " +
                                "SET producto = '{0}', " +
                                "cantidad = {1}, " +
                                "cantidad_prox_terminar = {2} " +
                                "WHERE id = {3};",
                                txtNombreProducto.Text,
                                txtCantidad.Text,
                                txtCantidadProxTerminar.Text,
                                RowId);

            SqlCommand comando = new SqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();

            CargarDatosProductos();

            txtNombreProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtCantidadProxTerminar.Enabled = false;
            txtNombreGrupo.Enabled = false;

        }

        private void CargarDatosGrupos()
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();
            if (conexion == null)
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string consulta = "SELECT id,grupo FROM grupos";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvListadoGrupos.DataSource = dt;
                dgvListadoGrupos.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarDatosProductos()
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();
            if (conexion == null)
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string consulta = "SELECT * FROM inventario";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvListadoProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dgvListadoGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionDeProductos_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtCantidadProxTerminar.Enabled = false;
            txtNombreGrupo.Enabled = false;
            CargarDatosGrupos();
        }

        private void dgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProducto.Text = dgvListadoProductos.SelectedCells[1].Value.ToString();
            txtCantidad.Text = dgvListadoProductos.SelectedCells[2].Value.ToString();
            txtCantidadProxTerminar.Text = dgvListadoProductos.SelectedCells[3].Value.ToString();
        }
    }
}
