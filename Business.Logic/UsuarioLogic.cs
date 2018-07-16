using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
	public class UsuarioLogic : BusinessLogic
	{

		public UsuarioAdapter _usuarioData;
		public UsuarioAdapter UsuarioData
		{
			get { return _usuarioData; }
			set { _usuarioData = value; }
		}
		public UsuarioLogic()
		{
			UsuarioData = new UsuarioAdapter();
		}

		/*public Usuario GetOne(Usuario usuario)
        {
            return UsuarioData.GetOne(usuario);
        }*/

		public Usuario GetOne(int ID)
		{
			return UsuarioData.GetOne(ID);
		}

		public List<Usuario> GetAll()
		{
			return UsuarioData.GetAll();
		}

		public List<Usuario> GetAll(string tipoBusqueda, string busqueda)
		{
			return UsuarioData.GetAll(tipoBusqueda, busqueda);
		}

		public void Save(Usuario usuario)
		{
			UsuarioData.Save(usuario);
		}

		public void Delete(int id)
		{
			UsuarioData.Delete(id);
		}

		public Business.Entities.Usuario GetLoggedUser(string usuario, string contrasenia)
		{
			return UsuarioData.GetLoggedUser(usuario, contrasenia);
		}

		public int GetMaxID()
		{
			return UsuarioData.GetMaxID();
		}
		public Boolean EsAdministrador(Usuario usrLogueado)
		{
			if (usrLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}
