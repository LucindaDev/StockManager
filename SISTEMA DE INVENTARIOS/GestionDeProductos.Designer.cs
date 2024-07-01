namespace SISTEMA_DE_INVENTARIOS
{
    partial class GestionDeProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.dgvListadoGrupos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblCantidadProxTerminarProducto = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblnombreProducto = new System.Windows.Forms.Label();
            this.txtCantidadProxTerminar = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.rbGestionDeProductos = new System.Windows.Forms.RadioButton();
            this.rbGestionDeGrupos = new System.Windows.Forms.RadioButton();
            this.gbGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.dgvListadoGrupos);
            this.gbGrupos.Controls.Add(this.btnAgregar);
            this.gbGrupos.Controls.Add(this.dgvListadoProductos);
            this.gbGrupos.Controls.Add(this.groupBox3);
            this.gbGrupos.Controls.Add(this.btnGuardar);
            this.gbGrupos.Controls.Add(this.btnEliminar);
            this.gbGrupos.Controls.Add(this.btnEditar);
            this.gbGrupos.Controls.Add(this.menuStrip2);
            this.gbGrupos.Location = new System.Drawing.Point(15, 68);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(834, 528);
            this.gbGrupos.TabIndex = 9;
            this.gbGrupos.TabStop = false;
            // 
            // dgvListadoGrupos
            // 
            this.dgvListadoGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListadoGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvListadoGrupos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListadoGrupos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvListadoGrupos.Location = new System.Drawing.Point(6, 65);
            this.dgvListadoGrupos.Name = "dgvListadoGrupos";
            this.dgvListadoGrupos.ReadOnly = true;
            this.dgvListadoGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoGrupos.Size = new System.Drawing.Size(411, 446);
            this.dgvListadoGrupos.StandardTab = true;
            this.dgvListadoGrupos.TabIndex = 18;
            this.dgvListadoGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoGrupos_CellClick);
            this.dgvListadoGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoGrupos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(246, 43);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar Grupo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(6, 65);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.ReadOnly = true;
            this.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.Size = new System.Drawing.Size(411, 446);
            this.dgvListadoProductos.StandardTab = true;
            this.dgvListadoProductos.TabIndex = 17;
            this.dgvListadoProductos.Visible = false;
            this.dgvListadoProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNombreGrupo);
            this.groupBox3.Controls.Add(this.lblNombreGrupo);
            this.groupBox3.Controls.Add(this.lblCantidadProxTerminarProducto);
            this.groupBox3.Controls.Add(this.lblCantidadProducto);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.lblnombreProducto);
            this.groupBox3.Controls.Add(this.txtCantidadProxTerminar);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Location = new System.Drawing.Point(423, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 446);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Enabled = false;
            this.txtNombreGrupo.Location = new System.Drawing.Point(161, 16);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.ReadOnly = true;
            this.txtNombreGrupo.Size = new System.Drawing.Size(238, 20);
            this.txtNombreGrupo.TabIndex = 8;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreGrupo.Location = new System.Drawing.Point(7, 16);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(148, 17);
            this.lblNombreGrupo.TabIndex = 7;
            this.lblNombreGrupo.Text = "Nombre del grupo: ";
            // 
            // lblCantidadProxTerminarProducto
            // 
            this.lblCantidadProxTerminarProducto.AutoSize = true;
            this.lblCantidadProxTerminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProxTerminarProducto.Location = new System.Drawing.Point(7, 67);
            this.lblCantidadProxTerminarProducto.Name = "lblCantidadProxTerminarProducto";
            this.lblCantidadProxTerminarProducto.Size = new System.Drawing.Size(188, 16);
            this.lblCantidadProxTerminarProducto.TabIndex = 6;
            this.lblCantidadProxTerminarProducto.Text = "Cantidad prox. a terminar: ";
            this.lblCantidadProxTerminarProducto.Visible = false;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(7, 42);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(77, 16);
            this.lblCantidadProducto.TabIndex = 5;
            this.lblCantidadProducto.Text = "Cantidad: ";
            this.lblCantidadProducto.Visible = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(183, 16);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(216, 20);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.Visible = false;
            // 
            // lblnombreProducto
            // 
            this.lblnombreProducto.AutoSize = true;
            this.lblnombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblnombreProducto.Location = new System.Drawing.Point(7, 16);
            this.lblnombreProducto.Name = "lblnombreProducto";
            this.lblnombreProducto.Size = new System.Drawing.Size(170, 17);
            this.lblnombreProducto.TabIndex = 3;
            this.lblnombreProducto.Text = "Nombre del producto: ";
            this.lblnombreProducto.Visible = false;
            // 
            // txtCantidadProxTerminar
            // 
            this.txtCantidadProxTerminar.Enabled = false;
            this.txtCantidadProxTerminar.Location = new System.Drawing.Point(201, 67);
            this.txtCantidadProxTerminar.Name = "txtCantidadProxTerminar";
            this.txtCantidadProxTerminar.ReadOnly = true;
            this.txtCantidadProxTerminar.Size = new System.Drawing.Size(198, 20);
            this.txtCantidadProxTerminar.TabIndex = 2;
            this.txtCantidadProxTerminar.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(90, 41);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(309, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(664, 16);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(463, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 43);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(273, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 43);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(828, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // rbGestionDeProductos
            // 
            this.rbGestionDeProductos.AutoSize = true;
            this.rbGestionDeProductos.Location = new System.Drawing.Point(12, 35);
            this.rbGestionDeProductos.Name = "rbGestionDeProductos";
            this.rbGestionDeProductos.Size = new System.Drawing.Size(127, 17);
            this.rbGestionDeProductos.TabIndex = 10;
            this.rbGestionDeProductos.TabStop = true;
            this.rbGestionDeProductos.Text = "Gestión de Productos";
            this.rbGestionDeProductos.UseVisualStyleBackColor = true;
            this.rbGestionDeProductos.CheckedChanged += new System.EventHandler(this.RbGestionDeProductos_CheckedChanged);
            // 
            // rbGestionDeGrupos
            // 
            this.rbGestionDeGrupos.AutoSize = true;
            this.rbGestionDeGrupos.Checked = true;
            this.rbGestionDeGrupos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbGestionDeGrupos.Location = new System.Drawing.Point(12, 12);
            this.rbGestionDeGrupos.Name = "rbGestionDeGrupos";
            this.rbGestionDeGrupos.Size = new System.Drawing.Size(113, 17);
            this.rbGestionDeGrupos.TabIndex = 11;
            this.rbGestionDeGrupos.TabStop = true;
            this.rbGestionDeGrupos.Text = "Gestión de Grupos";
            this.rbGestionDeGrupos.UseVisualStyleBackColor = true;
            this.rbGestionDeGrupos.CheckedChanged += new System.EventHandler(this.RbGestionDeGrupos_CheckedChanged);
            // 
            // GestionDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 608);
            this.Controls.Add(this.rbGestionDeGrupos);
            this.Controls.Add(this.rbGestionDeProductos);
            this.Controls.Add(this.gbGrupos);
            this.Name = "GestionDeProductos";
            this.Text = "GestionDeProductos";
            this.Load += new System.EventHandler(this.GestionDeProductos_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCantidadProxTerminarProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblnombreProducto;
        private System.Windows.Forms.TextBox txtCantidadProxTerminar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.RadioButton rbGestionDeProductos;
        private System.Windows.Forms.RadioButton rbGestionDeGrupos;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvListadoGrupos;
    }
}