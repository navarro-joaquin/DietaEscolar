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
    public partial class FrmItems : Form
    {
        private bool Editar = false;
        
        public FrmItems()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            if (!Editar)
            {
                txtNombre.ResetText();
            }
            else
            {
                txtId.ResetText();
                txtNombre.ResetText();
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

        private void FrmItems_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_acdDataSet.items' Puede moverla o quitarla según sea necesario.
            this.itemsTableAdapter.Fill(this.bd_acdDataSet.items);
            txtId.ReadOnly = true;
        }

        //Evento TextChanged del txtBuscar
        //Permitira buscar los items disponible automaticamente al
        //ingresar texto en la caja de texto
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        //Evento Click del boton Buscar
        //Buscaremos los items dentro de la base de datos que coincidan
        //con el texto ingresado en la caja de texto
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            itemsTableAdapter.BuscarItem(this.bd_acdDataSet.items, nombre);
        }

        //Evento Click del boton Guardar
        //Guardaremos datos nuevos o editaremos los ya existentes
        //dentro de la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Editar)
            {
                string nombre = txtNombre.Text;

                if (!nombre.Equals(""))
                {
                    try
                    {
                        int id_existente = Convert.ToInt32(itemsTableAdapter.BuscarDuplicados(nombre));
                        if (id_existente == 0)
                        {
                            itemsTableAdapter.InsertarItem(nombre);
                            MessageBox.Show("Item insertado correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El item '" + nombre + "' ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string nombre = txtNombre.Text;

                try
                {
                    itemsTableAdapter.EditarItem(nombre, id);
                    MessageBox.Show("Entrada editada correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Editar = false;

                    tabControl1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.itemsTableAdapter.Fill(this.bd_acdDataSet.items);
            Limpiar();
        }

        //Evento Click del boton Cancelar
        //Limpiaremos las cajas de texto
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Evento Click del boton Eliminar
        //Eliminaremos entradas de la base de datos
        //previa confirmación
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea eliminar las entradas seleccionadas?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.OK)
            {
                try
                {
                    int id;

                    int nro_filas = dgvItems.Rows.GetRowCount(DataGridViewElementStates.Selected);


                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvItems.SelectedRows[i].Cells[0].Value);
                        itemsTableAdapter.EliminarItem(id);
                    }

                    MessageBox.Show(nro_filas + " items eliminados correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemsTableAdapter.Fill(this.bd_acdDataSet.items);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Evento DoubleClick del datagridview
        //Permite cargar los datos del listado a los controles para
        //editar los datos obtenidos de la base de datos
        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();

            Editar = true;

            tabControl1.SelectedIndex = 1;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapturarTeclas(e);
        }
    }
}
