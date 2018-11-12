using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MateriasEditar : System.Web.UI.Page
    {
        #region Variables
        private MateriaLogic ml = new MateriaLogic();
        private PlanLogic planLogic = new PlanLogic();
        private Materia _MateriaActual = new Materia();
        private Plan _PlanActual = new Plan();
        public enum ModoForm { Alta, Baja, Modificacion, Consulta };
        private ModoForm _Modo;
        #endregion

        #region Propiedades
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }

        public Materia MateriaActual { get => _MateriaActual; set => _MateriaActual = value; }
        public Plan PlanActual { get => _PlanActual; set => _PlanActual = value; }
        #endregion

        #region Disparadores
        protected void Page_Load(object sender, EventArgs e)
        {
			//((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador)
			Usuario usuarioLogueado = (Usuario)Session["UsuarioLogueado"];


			if (Session["UsuarioLogueado"] != null)
			{
				if (usuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					if (PaginaEnEstadoEdicion() && !IsPostBack)
					{
						int id = Int32.Parse(Request.QueryString["id"]);
						MateriaActual = ml.GetOne(id);
						PlanActual = MateriaActual.Plan;
						llenaCampos();
					}
				}
				
			}
			else
			{
				Response.Redirect("/login.aspx");
			}
			
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            ml.Save(MateriaActual);
            Response.Redirect("~/Materias");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Materias");
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Verifica si la página está en estado de edición 
        /// </summary>
        /// <returns></returns>
        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Llena los campos con los datos de la Persona y Usuario previamente traidos de la BD
        /// </summary>
        private void llenaCampos()
        {
            lblIdMateria.Text = MateriaActual.ID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion.ToString();
            txtHsSemanales.Text = MateriaActual.HSSemanales.ToString();
            txtHorasTotales.Text = MateriaActual.HSTotales.ToString();

            //Llenar el dropdownlist
            PlanLogic planLogic = new PlanLogic();
            ddlPlan.DataSource = planLogic.GetAll();
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataTextField = "WebDesc";
            ddlPlan.DataBind();

            ddlPlan.SelectedValue = MateriaActual.Plan.ID.ToString();
        }

        /// <summary>
        /// Mapea los datos de los controles actuales del formulario en las propiedades PersonaActual y UsuarioActual
        /// </summary>
        private void MapearADatos()
        {
            MateriaActual.State = (Materia.States)ModoForm.Modificacion;
            MateriaActual.ID = Int32.Parse(lblIdMateria.Text);
            MateriaActual.Descripcion = txtDescripcion.Text;
            MateriaActual.HSSemanales = Int32.Parse(txtHsSemanales.Text);
            MateriaActual.HSTotales = Int32.Parse(txtHorasTotales.Text);
            MateriaActual.Plan = new Plan();
            MateriaActual.Plan.ID = ddlPlan.SelectedIndex + 1;
        }
        #endregion
    }
}