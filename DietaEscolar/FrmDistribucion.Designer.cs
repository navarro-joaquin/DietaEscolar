namespace DietaEscolar
{
    partial class FrmDistribucion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label lblIdItem;
            System.Windows.Forms.Label lblNivel;
            System.Windows.Forms.Label lblDiaSemana;
            System.Windows.Forms.Label lblNroDias;
            System.Windows.Forms.Label lblEstado;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_planeacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_acdDataSet = new DietaEscolar.bd_acdDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbStock = new System.Windows.Forms.GroupBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbIdItem = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.txtNroDias = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.vista_planeacionTableAdapter = new DietaEscolar.bd_acdDataSetTableAdapters.vista_planeacionTableAdapter();
            this.tableAdapterManager = new DietaEscolar.bd_acdDataSetTableAdapters.TableAdapterManager();
            this.planeacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeacionTableAdapter = new DietaEscolar.bd_acdDataSetTableAdapters.planeacionTableAdapter();
            this.itemsTableAdapter = new DietaEscolar.bd_acdDataSetTableAdapters.itemsTableAdapter();
            lblId = new System.Windows.Forms.Label();
            lblIdItem = new System.Windows.Forms.Label();
            lblNivel = new System.Windows.Forms.Label();
            lblDiaSemana = new System.Windows.Forms.Label();
            lblNroDias = new System.Windows.Forms.Label();
            lblEstado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_planeacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_acdDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(35, 33);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(32, 18);
            lblId.TabIndex = 0;
            lblId.Text = "Nro:";
            // 
            // lblIdItem
            // 
            lblIdItem.AutoSize = true;
            lblIdItem.Location = new System.Drawing.Point(35, 69);
            lblIdItem.Name = "lblIdItem";
            lblIdItem.Size = new System.Drawing.Size(36, 18);
            lblIdItem.TabIndex = 2;
            lblIdItem.Text = "Item:";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new System.Drawing.Point(35, 109);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new System.Drawing.Size(38, 18);
            lblNivel.TabIndex = 4;
            lblNivel.Text = "Nivel:";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new System.Drawing.Point(291, 109);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new System.Drawing.Size(53, 18);
            lblDiaSemana.TabIndex = 6;
            lblDiaSemana.Text = "Semana:";
            // 
            // lblNroDias
            // 
            lblNroDias.AutoSize = true;
            lblNroDias.Location = new System.Drawing.Point(35, 150);
            lblNroDias.Name = "lblNroDias";
            lblNroDias.Size = new System.Drawing.Size(75, 18);
            lblNroDias.TabIndex = 8;
            lblNroDias.Text = "Nro de Días:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(291, 150);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(48, 18);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 27);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Stock de items";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 323);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.cmbBuscar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.dgvStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "ITEM",
            "SEMANA",
            "NIVEL"});
            this.cmbBuscar.Location = new System.Drawing.Point(6, 22);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(121, 26);
            this.cmbBuscar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(561, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(413, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(163, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 21);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvStock.DataSource = this.vista_planeacionBindingSource;
            this.dgvStock.Location = new System.Drawing.Point(6, 69);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(642, 220);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 330;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dia_semana";
            this.dataGridViewTextBoxColumn3.HeaderText = "Semana";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nro_dias";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nro de Días";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nivel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // vista_planeacionBindingSource
            // 
            this.vista_planeacionBindingSource.DataMember = "vista_planeacion";
            this.vista_planeacionBindingSource.DataSource = this.bd_acdDataSet;
            // 
            // bd_acdDataSet
            // 
            this.bd_acdDataSet.DataSetName = "bd_acdDataSet";
            this.bd_acdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbStock
            // 
            this.grbStock.Controls.Add(this.cmbNivel);
            this.grbStock.Controls.Add(this.btnCancelar);
            this.grbStock.Controls.Add(this.btnGuardar);
            this.grbStock.Controls.Add(lblId);
            this.grbStock.Controls.Add(this.txtId);
            this.grbStock.Controls.Add(lblIdItem);
            this.grbStock.Controls.Add(this.cmbIdItem);
            this.grbStock.Controls.Add(lblNivel);
            this.grbStock.Controls.Add(lblDiaSemana);
            this.grbStock.Controls.Add(this.cmbDiaSemana);
            this.grbStock.Controls.Add(lblNroDias);
            this.grbStock.Controls.Add(this.txtNroDias);
            this.grbStock.Controls.Add(lblEstado);
            this.grbStock.Controls.Add(this.chkEstado);
            this.grbStock.Location = new System.Drawing.Point(45, 18);
            this.grbStock.Name = "grbStock";
            this.grbStock.Size = new System.Drawing.Size(555, 267);
            this.grbStock.TabIndex = 0;
            this.grbStock.TabStop = false;
            this.grbStock.Text = "Stock de Items";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "INICIAL Y PRIMARIA",
            "SECUNDARIA",
            "ALTERNATIVA Y CONVENIO"});
            this.cmbNivel.Location = new System.Drawing.Point(113, 106);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(133, 26);
            this.cmbNivel.TabIndex = 14;
            this.cmbNivel.Text = "INICIAL Y PRIMARIA";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(369, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(102, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 41);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 21);
            this.txtId.TabIndex = 1;
            // 
            // cmbIdItem
            // 
            this.cmbIdItem.DataSource = this.itemsBindingSource;
            this.cmbIdItem.DisplayMember = "nombre";
            this.cmbIdItem.FormattingEnabled = true;
            this.cmbIdItem.Location = new System.Drawing.Point(113, 66);
            this.cmbIdItem.Name = "cmbIdItem";
            this.cmbIdItem.Size = new System.Drawing.Size(377, 26);
            this.cmbIdItem.TabIndex = 3;
            this.cmbIdItem.ValueMember = "id";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.bd_acdDataSet;
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES"});
            this.cmbDiaSemana.Location = new System.Drawing.Point(369, 106);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(121, 26);
            this.cmbDiaSemana.TabIndex = 7;
            this.cmbDiaSemana.Text = "LUNES";
            // 
            // txtNroDias
            // 
            this.txtNroDias.Location = new System.Drawing.Point(113, 147);
            this.txtNroDias.Name = "txtNroDias";
            this.txtNroDias.Size = new System.Drawing.Size(93, 21);
            this.txtNroDias.TabIndex = 9;
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(369, 145);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(121, 24);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // vista_planeacionTableAdapter
            // 
            this.vista_planeacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.itemsTableAdapter = null;
            this.tableAdapterManager.planeacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DietaEscolar.bd_acdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // planeacionBindingSource
            // 
            this.planeacionBindingSource.DataMember = "planeacion";
            this.planeacionBindingSource.DataSource = this.bd_acdDataSet;
            // 
            // planeacionTableAdapter
            // 
            this.planeacionTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDistribucion";
            this.Text = ".:. Mantenimiento de Stock .:.";
            this.Load += new System.EventHandler(this.FrmDistribucion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_planeacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_acdDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grbStock.ResumeLayout(false);
            this.grbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private bd_acdDataSet bd_acdDataSet;
        private System.Windows.Forms.BindingSource vista_planeacionBindingSource;
        private bd_acdDataSetTableAdapters.vista_planeacionTableAdapter vista_planeacionTableAdapter;
        private bd_acdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grbStock;
        private System.Windows.Forms.BindingSource planeacionBindingSource;
        private bd_acdDataSetTableAdapters.planeacionTableAdapter planeacionTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbIdItem;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.TextBox txtNroDias;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private bd_acdDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbNivel;
    }
}