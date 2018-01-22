using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System.Configuration;

namespace DietaEscolar
{
    public partial class FrmReporteGeneral : Form
    {
        public FrmReporteGeneral()
        {
            InitializeComponent();
        }

        private void FrmReporteGeneral_Load(object sender, EventArgs e)
        {
            consultasDataSet dataset = new consultasDataSet();
            string ConnectionString = ConfigurationManager.ConnectionStrings["DietaEscolar.Properties.Settings.bd_acdCS"].ConnectionString;

            MessageBox.Show(ConnectionString);
            this.reportViewer1.RefreshReport();
        }
    }
}
