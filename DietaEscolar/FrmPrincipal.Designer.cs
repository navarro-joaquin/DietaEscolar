namespace DietaEscolar
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemsBtn = new System.Windows.Forms.ToolStripButton();
            this.UsuariosBtn = new System.Windows.Forms.ToolStripButton();
            this.StockBtn = new System.Windows.Forms.ToolStripButton();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicialYPrimariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secundariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alternativaYConvenioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.operacionesMenu,
            this.reportesToolStripMenuItem,
            this.viewMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsBtn,
            this.UsuariosBtn,
            this.StockBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel.Text = "..: Bienvenido ::.";
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemsBtn.Image = global::DietaEscolar.Properties.Resources.breakfast;
            this.ItemsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(23, 22);
            this.ItemsBtn.Text = "Items";
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // UsuariosBtn
            // 
            this.UsuariosBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UsuariosBtn.Image = global::DietaEscolar.Properties.Resources.man;
            this.UsuariosBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsuariosBtn.Name = "UsuariosBtn";
            this.UsuariosBtn.Size = new System.Drawing.Size(23, 22);
            this.UsuariosBtn.Text = "Usuarios";
            this.UsuariosBtn.Click += new System.EventHandler(this.UsuariosBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StockBtn.Image = global::DietaEscolar.Properties.Resources.warehouse;
            this.StockBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(23, 22);
            this.StockBtn.Text = "Stock de Items";
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.Image = global::DietaEscolar.Properties.Resources.folder;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(76, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.exit__1_;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // operacionesMenu
            // 
            this.operacionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.planeacionToolStripMenuItem});
            this.operacionesMenu.Image = global::DietaEscolar.Properties.Resources.database;
            this.operacionesMenu.Name = "operacionesMenu";
            this.operacionesMenu.Size = new System.Drawing.Size(101, 20);
            this.operacionesMenu.Text = "&Operaciones";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.man;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.breakfast;
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.itemsToolStripMenuItem.Text = "&Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // planeacionToolStripMenuItem
            // 
            this.planeacionToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.warehouse;
            this.planeacionToolStripMenuItem.Name = "planeacionToolStripMenuItem";
            this.planeacionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.planeacionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.planeacionToolStripMenuItem.Text = "&Stock de Items";
            this.planeacionToolStripMenuItem.Click += new System.EventHandler(this.planeacionToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.inicialYPrimariaToolStripMenuItem,
            this.secundariaToolStripMenuItem,
            this.alternativaYConvenioToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.analytics;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.analytics__1_;
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.generalToolStripMenuItem.Text = "&General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // inicialYPrimariaToolStripMenuItem
            // 
            this.inicialYPrimariaToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.analytics__1_;
            this.inicialYPrimariaToolStripMenuItem.Name = "inicialYPrimariaToolStripMenuItem";
            this.inicialYPrimariaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.inicialYPrimariaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.inicialYPrimariaToolStripMenuItem.Text = "&Inicial y Primaria";
            this.inicialYPrimariaToolStripMenuItem.Click += new System.EventHandler(this.inicialYPrimariaToolStripMenuItem_Click);
            // 
            // secundariaToolStripMenuItem
            // 
            this.secundariaToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.analytics__1_;
            this.secundariaToolStripMenuItem.Name = "secundariaToolStripMenuItem";
            this.secundariaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.secundariaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.secundariaToolStripMenuItem.Text = "&Secundaria";
            this.secundariaToolStripMenuItem.Click += new System.EventHandler(this.secundariaToolStripMenuItem_Click);
            // 
            // alternativaYConvenioToolStripMenuItem
            // 
            this.alternativaYConvenioToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.analytics__1_;
            this.alternativaYConvenioToolStripMenuItem.Name = "alternativaYConvenioToolStripMenuItem";
            this.alternativaYConvenioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.alternativaYConvenioToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.alternativaYConvenioToolStripMenuItem.Text = "&Alternativa y Convenio";
            this.alternativaYConvenioToolStripMenuItem.Click += new System.EventHandler(this.alternativaYConvenioToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Image = global::DietaEscolar.Properties.Resources.binoculars;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(51, 20);
            this.viewMenu.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Image = global::DietaEscolar.Properties.Resources.windows;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(82, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.cascade_visualization_option_interface_button;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.tile;
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.tile__1_;
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.error;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem});
            this.helpMenu.Image = global::DietaEscolar.Properties.Resources.info;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(69, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Image = global::DietaEscolar.Properties.Resources.pdf;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.manualToolStripMenuItem.Text = "&Manual de Usuario";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = ".:: Sistema de Gestión PACD ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ItemsBtn;
        private System.Windows.Forms.ToolStripButton UsuariosBtn;
        private System.Windows.Forms.ToolStripButton StockBtn;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicialYPrimariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secundariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alternativaYConvenioToolStripMenuItem;
    }
}



