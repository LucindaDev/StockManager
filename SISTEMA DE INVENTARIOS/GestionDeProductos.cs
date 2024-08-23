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
        private bool esEdicion = false;
        private int idEdicion = -1;

        public GestionDeProductos()
        {
            InitializeComponent();
            CargarDatosGrupos();
            HabilitarCampos(false);
        }

        private void GestionDeProductos_Load(object sender, EventArgs e)
        {
            CargarDatosGrupos();
            btnGuardar.Enabled = false;
        }

        //RB GESTION DE GRUPOS
        private void RbGestionDeGrupos_CheckedChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
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
                btnAgregar.Enabled = true;
            }

        }

        //RB GESTION DE PRODUCTOS
        private void RbGestionDeProductos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosProductos();
            btnGuardar.Enabled=false;
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

        //LIMPIAR DATOS DE LOS TEXTBOX
        private void Limpiar()
        {
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtNombreGrupo.Text = "";
            txtCantidadProxTerminar.Text = "";
            esEdicion = false;
            idEdicion = -1;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtNombreGrupo.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtCantidadProxTerminar.Enabled = false;
            rbGestionDeGrupos.Enabled = true;
            rbGestionDeProductos.Enabled = true;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombreProducto.Enabled = habilitar;
            txtCantidad.Enabled = habilitar;
            txtCantidadProxTerminar.Enabled = habilitar;
            txtNombreGrupo.Enabled = habilitar;
        }

        //BUTTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled=false;
            btnAgregar.Enabled=false;
            btnCancelar.Enabled=true;


            if (rbGestionDeGrupos.Checked)
            {
                rbGestionDeProductos.Enabled = false;
                btnGuardar.Enabled = true;
                esEdicion = false;
                HabilitarCampos(true);
            }

            if (rbGestionDeProductos.Checked)
            {
                rbGestionDeGrupos.Enabled = false;
                btnGuardar.Enabled = true;
                txtNombreProducto.Enabled = true;
                txtCantidad.Enabled = true;
                txtCantidadProxTerminar.Enabled = true;
                esEdicion = false;
                HabilitarCampos(true);
            }

        }

        //BUTTON ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();

            if (rbGestionDeGrupos.Checked)
            {
                if (dgvListadoGrupos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Por favor seleccione un grupo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (dgvListadoProductos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Por favor seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string tabla = rbGestionDeGrupos.Checked ? "grupos" : "inventario";
            string RowId = rbGestionDeGrupos.Checked
                ? dgvListadoGrupos.SelectedCells[0].Value.ToString()
                : dgvListadoProductos.SelectedCells[0].Value.ToString();
            string eliminar = string.Format("DELETE FROM {0} WHERE Id = {1}", tabla, RowId);

            SqlCommand comando = new SqlCommand(eliminar, conexion);
            comando.ExecuteNonQuery();

            if (rbGestionDeGrupos.Checked)
            {
                MessageBox.Show($"Grupo eliminado con éxito");
                CargarDatosGrupos();
            }
            else
            {
                CargarDatosProductos();
                MessageBox.Show($"Producto eliminado con éxito");
            }
            Limpiar();
        }
    

        //BUTTON EDITAR
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(idEdicion == -1)
            {
                MessageBox.Show("Debes seleccionar un elemento a editar", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNombreProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtCantidadProxTerminar.Enabled = true;
            txtNombreGrupo.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAgregar.Enabled = false;
            esEdicion = true;

            if (rbGestionDeGrupos.Checked)
            {
                rbGestionDeProductos.Enabled = false;
            }
            if (rbGestionDeProductos.Checked)
            {
                rbGestionDeGrupos.Enabled = false;
            }
        }

        //BUTTON GUARDAR
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            SqlConnection conexion = c.CrearConexion();
            string tabla = rbGestionDeGrupos.Checked ? "grupos" : "inventario";

            if (rbGestionDeGrupos.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNombreGrupo.Text))
                {
                    MessageBox.Show("El nombre del grupo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidadProxTerminar.Text))
                {
                    MessageBox.Show("Todos los campos de producto deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (esEdicion)
            { 
                string actualizar = rbGestionDeGrupos.Checked
                    ? string.Format("UPDATE grupos SET grupo = '{0}' WHERE id = {1};", txtNombreGrupo.Text, idEdicion)
                    : string.Format("UPDATE inventario SET producto = '{0}', cantidad = {1}, cantidad_prox_terminar = {2} WHERE id = {3};",
                        txtNombreProducto.Text, txtCantidad.Text, txtCantidadProxTerminar.Text, idEdicion);

                SqlCommand comando = new SqlCommand(actualizar, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show($"{tabla} actualizado con éxito");

                HabilitarCampos(false);
            }
            else
            {
                string insertar = rbGestionDeGrupos.Checked
                    ? string.Format("INSERT INTO grupos (grupo) VALUES ('{0}')", txtNombreGrupo.Text)
                    : string.Format("INSERT INTO inventario (producto, cantidad, cantidad_prox_terminar) VALUES ('{0}', '{1}', '{2}')",
                        txtNombreProducto.Text, txtCantidad.Text, txtCantidadProxTerminar.Text);

                SqlCommand comando = new SqlCommand(insertar, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show($"{tabla} agregado con éxito");

                HabilitarCampos(false);
            }


            if (rbGestionDeGrupos.Checked)
            {
                CargarDatosGrupos();
            }
            else
            {
                CargarDatosProductos();
            }
            Limpiar();
        }

        //CARGAR DATOS EN LA TABLA DE GRUPOS.
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
            if (dgvListadoProductos.Columns["cantidad_prox_terminar"] != null)
            {
                dgvListadoProductos.Columns["cantidad_prox_terminar"].Visible = false;
            }
        }

        //CARGAR DATOS EN LA TABLA DE PRODUCTOS.
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

        //MOSTRAR DATOS DEL LISTADO DE GRUPOS EN LOS TEXTBOX.
        private void DgvListadoGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListadoGrupos.Rows[e.RowIndex];
                idEdicion = Convert.ToInt32(row.Cells["id"].Value);
                txtNombreGrupo.Text = row.Cells["grupo"].Value.ToString();
                esEdicion = true;
            }
                txtNombreGrupo.Text = dgvListadoGrupos.SelectedCells[1].Value.ToString();
        }

        //MOSTRAR DATOS DEL LISTADO DE PRODUCTOS EN LOS TEXTBOX.
        private void DgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListadoProductos.Rows[e.RowIndex];
                idEdicion = Convert.ToInt32(row.Cells["id"].Value);
                txtNombreProducto.Text = row.Cells["producto"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                txtCantidadProxTerminar.Text = row.Cells["cantidad_prox_terminar"].Value.ToString();
                esEdicion = true;
            }

            txtNombreProducto.Text = dgvListadoProductos.SelectedCells[1].Value.ToString();
            txtCantidad.Text = dgvListadoProductos.SelectedCells[2].Value.ToString();
            txtCantidadProxTerminar.Text = dgvListadoProductos.SelectedCells[3].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tienes cambios sin guardar, ¿Estás seguro de querer cancelar?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Limpiar();
            }
        }
    }
}
