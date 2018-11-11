using Business.Logic;
using Microsoft.Reporting.WinForms;
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

namespace UI.Desktop
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.SP_Cursos' Puede moverla o quitarla según sea necesario.
            this.SP_CursosTableAdapter.Fill(this.AcademiaDataSet.SP_Cursos);
            this.SP_PlanesTableAdapter.Fill(this.AcademiaDataSet.SP_Planes);
            this.reportViewer1.RefreshReport();
        }
    }
}
