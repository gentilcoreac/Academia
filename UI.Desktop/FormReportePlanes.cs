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
    public partial class FormReportePlanes : ApplicationForm
    {
        public FormReportePlanes()
        {
            InitializeComponent();
        }

        private void FormReportePlanes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.SP_Planes' Puede moverla o quitarla según sea necesario.
            this.SP_PlanesTableAdapter.Fill(this.AcademiaDataSet.SP_Planes);

            this.reportViewer1.RefreshReport();
        }
    }
}
