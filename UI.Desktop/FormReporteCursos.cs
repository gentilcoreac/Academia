using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormReporteCursos : ApplicationForm
    {
        public FormReporteCursos()
        {
            InitializeComponent();
        }

        private void FormReporteCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.SP_Cursos' Puede moverla o quitarla según sea necesario.
            AcademiaDataSet.EnforceConstraints = false;
            this.SP_CursosTableAdapter.Fill(this.AcademiaDataSet.SP_Cursos);

            this.reportViewer1.RefreshReport();
        }
    }
}
