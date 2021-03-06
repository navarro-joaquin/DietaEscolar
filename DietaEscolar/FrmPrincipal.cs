﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietaEscolar
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(string nombre_usuario)
        {
            InitializeComponent();
            toolStripStatusLabel.Text = "..: BIENVENIDO " + nombre_usuario + " :..";
        }

        //Funcionalidad del boton Salir en el menú Archivo
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Mostrar/Ocultar Barra de Herramientas
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        //Mostrar/Ocultar Barra de Estado
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        //Ordenar formularios hijo en Cascada
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        //Ordenar formularios hijo en Mosaico Vertical
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        //Ordenar formularios hijo en Mosaico Horizontal
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Cerrar todos los formularios hijo
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItems frm = new FrmItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            itemsToolStripMenuItem.PerformClick();
        }

        private void UsuariosBtn_Click(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.PerformClick();
        }

        private void planeacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistribucion frm = new FrmDistribucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            planeacionToolStripMenuItem.PerformClick();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGeneral reporteGeneral = new FrmReporteGeneral();
            reporteGeneral.MdiParent = this;
            reporteGeneral.Show();
        }

        private void inicialYPrimariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteNivelInicial reporte = new FrmReporteNivelInicial();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void secundariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteNivelSecundaria reporte = new FrmReporteNivelSecundaria();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void alternativaYConvenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteNivelAlternativa reporte = new FrmReporteNivelAlternativa();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual.pdf");
            System.Diagnostics.Process.Start(pdfPath);
        }
    }
}
