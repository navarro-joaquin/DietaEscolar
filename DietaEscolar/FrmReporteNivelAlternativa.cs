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
    public partial class FrmReporteNivelAlternativa : Form
    {
        public FrmReporteNivelAlternativa()
        {
            InitializeComponent();
        }

        private void FrmReporteNivelAlternativa_Load(object sender, EventArgs e)
        {
            consultasDataSet dataset = new consultasDataSet();
            string ConnectionString = ConfigurationManager.ConnectionStrings["DietaEscolar.Properties.Settings.bd_acdCS"].ConnectionString;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();

            string consulta = "SELECT `nombre`, `dia_semana`, `nro_dias`, `nivel`, `estado`, `fecha` FROM `vista_planeacion` WHERE `nivel` LIKE 'ALTERNATIVA Y CONVENIO' ORDER BY FIELD (`dia_semana`, 'LUNES', 'MARTES', 'MIERCOLES', 'JUEVES', 'VIERNES')";

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, ConnectionString);
            adapter.Fill(dataset, dataset.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Consulta", dataset.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

            conn.Close();

            this.reportViewer1.RefreshReport();
        }
    }
}
