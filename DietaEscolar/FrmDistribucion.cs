using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietaEscolar
{
    public partial class FrmDistribucion : Form
    {
        private bool Editar = false;

        public FrmDistribucion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            if (!Editar)
            {
                txtNroDias.ResetText();
                cmbIdItem.SelectedIndex = 0;
                cmbNivel.SelectedIndex = 0;
                cmbDiaSemana.SelectedIndex = 0;
                chkEstado.Checked = false;

                cmbIdItem.Focus();
            }
            else
            {
                txtId.ResetText();
                txtNroDias.ResetText();
                cmbIdItem.SelectedIndex = 0;
                cmbNivel.SelectedIndex = 0;
                cmbDiaSemana.SelectedIndex = 0;
                chkEstado.Checked = false;

                cmbIdItem.Focus();
            }
        }

        private void CapturarTeclas(KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btnGuardar.PerformClick();
            }
            if (e.KeyChar == (int)Keys.Escape)
            {
                Limpiar();
                tabControl1.SelectedIndex = 0;
            }
        }

        private void FrmDistribucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_acdDataSet.items' Puede moverla o quitarla según sea necesario.
            this.itemsTableAdapter.Fill(this.bd_acdDataSet.items);
            // TODO: esta línea de código carga datos en la tabla 'bd_acdDataSet.planeacion' Puede moverla o quitarla según sea necesario.
            // this.planeacionTableAdapter.Fill(this.bd_acdDataSet.planeacion);
            // TODO: esta línea de código carga datos en la tabla 'bd_acdDataSet.vista_planeacion' Puede moverla o quitarla según sea necesario.
            this.vista_planeacionTableAdapter.Fill(this.bd_acdDataSet.vista_planeacion);

            cmbBuscar.SelectedIndex = 0;
            txtId.ReadOnly = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    this.vista_planeacionTableAdapter.BuscarNombre(bd_acdDataSet.vista_planeacion, txtBuscar.Text);
                    break;
                case 1:
                    this.vista_planeacionTableAdapter.BuscarDiaSemana(bd_acdDataSet.vista_planeacion, txtBuscar.Text);
                    break;
                case 2:
                    this.vista_planeacionTableAdapter.BuscarNivel(bd_acdDataSet.vista_planeacion, txtBuscar.Text);
                    break;
                default:
                    this.vista_planeacionTableAdapter.BuscarNombre(bd_acdDataSet.vista_planeacion, txtBuscar.Text);
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Editar)
            {
                int id_item = Convert.ToInt32(cmbIdItem.SelectedValue);
                string nivel = cmbNivel.Text;
                string semana = cmbDiaSemana.Text;
                int nro_dias = 0;
                if (!txtNroDias.Text.Equals(""))
                {
                    nro_dias = Convert.ToInt32(txtNroDias.Text);
                }

                string estado = chkEstado.Checked ? "1" : "0";

                if (!(txtNroDias.Text.Equals("")))
                {
                    try
                    {
                        int id_existente = Convert.ToInt32(planeacionTableAdapter.BuscarDuplicados(id_item, nivel, semana, nro_dias, estado));
                        if (id_existente == 0)
                        {
                            planeacionTableAdapter.InsertarStock(id_item, nivel, semana, nro_dias, estado);
                            MessageBox.Show("Item insertado correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese los datos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                int id_item = Convert.ToInt32(cmbIdItem.SelectedValue);
                string nivel = cmbNivel.Text;
                string semana = cmbDiaSemana.Text;
                int nro_dias = 0;
                if (!txtNroDias.Text.Equals(""))
                {
                    nro_dias = Convert.ToInt32(txtNroDias.Text);
                }

                string estado = chkEstado.Checked ? "1" : "0";

                try
                {
                    planeacionTableAdapter.EditarStock(id_item, nivel, semana, nro_dias, estado, id);
                    MessageBox.Show("Entrada editada correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Editar = false;

                    tabControl1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.vista_planeacionTableAdapter.Fill(this.bd_acdDataSet.vista_planeacion);
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea eliminar las entradas seleccionadas?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.OK)
            {
                try
                {
                    int id;

                    int nro_filas = dgvStock.Rows.GetRowCount(DataGridViewElementStates.Selected);


                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvStock.SelectedRows[i].Cells[0].Value);
                        planeacionTableAdapter.EliminarStock(id);
                    }

                    MessageBox.Show(nro_filas + " items eliminados correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vista_planeacionTableAdapter.Fill(this.bd_acdDataSet.vista_planeacion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
            cmbIdItem.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            cmbNivel.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();
            cmbDiaSemana.Text = dgvStock.CurrentRow.Cells[2].Value.ToString();
            txtNroDias.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();

            string estado = dgvStock.CurrentRow.Cells[5].Value.ToString();

            if (estado.Equals("0"))
            {
                chkEstado.Checked = false;
            }
            else
            {
                chkEstado.Checked = true;
            }

            Editar = true;

            tabControl1.SelectedIndex = 1;
        }
    }
}
