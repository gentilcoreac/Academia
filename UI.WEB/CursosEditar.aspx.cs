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
	public partial class CursosEditar : System.Web.UI.Page
	{

		#region Variables
		private CursoLogic cl = new CursoLogic();
		private MateriaLogic ml = new MateriaLogic();
		private ComisionLogic comLogic = new ComisionLogic();
		private Curso _CursoActual = new Curso();
		private Materia _MateriaActual = new Materia();
		private Comision _ComisionActual = new Comision();

		public enum ModoForm { Alta, Baja, Modificacion, Consulta };
		private ModoForm _Modo;
		#endregion

		#region Propiedades
		public ModoForm Modo
		{
			get { return _Modo; }
			set { _Modo = value; }
		}

		public Curso CursoActual { get => _CursoActual; set => _CursoActual = value; }
		public Materia MateriaActual { get => _MateriaActual; set => _MateriaActual = value; }
		public Comision ComisionActual { get => _ComisionActual; set => _ComisionActual = value; }
		#endregion

		#region Disparadores
		protected void Page_Load(object sender, EventArgs e)
		{

			if (Session["UsuarioLogueado"] != null)
			{
				if (!((Usuario)Session["UsuarioLogueado"]).IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					Response.Redirect("/Cursos.aspx");
				}
				if (PaginaEnEstadoEdicion() && !IsPostBack)
				{
					int id = Int32.Parse(Request.QueryString["id"]);
					CursoActual = cl.GetOne(id);
					MateriaActual = CursoActual.Materia;
					ComisionActual = CursoActual.Comision;
					LlenaCampos();
				}

				if (PaginaEnEstadoAlta() && !IsPostBack)
				{
					EstableceAño();
					LlenaDropDownList();
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
			cl.Save(CursoActual);
			Response.Redirect("~/Cursos");
		}

		protected void btnCancelar_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Cursos");
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

		private bool PaginaEnEstadoAlta()
		{
			if (Request.QueryString["mode"] == "new")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Llena los campos con los datos del curso previamente traidos de la BD
		/// </summary>
		private void LlenaCampos()
		{
			lblIdCurso.Text = CursoActual.ID.ToString();
			txtAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
			txtCupo.Text = CursoActual.Cupo.ToString();

			LlenaDropDownList();
			//Asigna valores actuales a los DDL
			ddlComision.SelectedValue = ComisionActual.ID.ToString();
			ddlMateria.SelectedValue = MateriaActual.ID.ToString();
		}

		/// <summary>
		/// Mapea los datos de los controles actuales del formulario en las propiedades PersonaActual y UsuarioActual
		/// </summary>
		private void MapearADatos()
		{
			if (PaginaEnEstadoEdicion())
			{
				CursoActual.State = (Curso.States)ModoForm.Modificacion;
				CursoActual.ID = Int32.Parse(lblIdCurso.Text);
			}
			else if (PaginaEnEstadoAlta())
			{
				CursoActual.State = (Curso.States)ModoForm.Alta;
			}

			CursoActual.AnioCalendario = Int32.Parse(txtAnioCalendario.Text);
			CursoActual.Cupo = Int32.Parse(txtCupo.Text);
			CursoActual.Comision = new Comision();
			CursoActual.Comision.ID = Int32.Parse(ddlComision.SelectedValue);
			CursoActual.Materia = new Materia();
			CursoActual.Materia.ID = Int32.Parse(ddlMateria.SelectedValue);
		}

		private void LlenaDropDownList()
		{
			ddlComision.DataSource = comLogic.GetAll();
			ddlComision.DataValueField = "ID";
			ddlComision.DataTextField = "Descripcion";
			ddlComision.DataBind();

			ddlMateria.DataSource = ml.GetMateriasDisponibles(Int32.Parse(ddlComision.SelectedValue));
			ddlMateria.DataValueField = "ID";
			ddlMateria.DataTextField = "Descripcion";
			ddlMateria.DataBind();
		}

		private void EstableceAño()
		{
			txtAnioCalendario.Text = DateTime.Today.Year.ToString();
		}
		#endregion

		protected void ddlComision_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlMateria.DataSource = ml.GetMateriasDisponibles(Int32.Parse(ddlComision.SelectedValue));
			ddlMateria.DataValueField = "ID";
			ddlMateria.DataTextField = "Descripcion";
			ddlMateria.DataBind();
		}
	}
}
