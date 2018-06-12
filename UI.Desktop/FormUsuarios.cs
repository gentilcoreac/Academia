using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.DataSource = ul.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
