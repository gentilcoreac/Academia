using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
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

        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
    
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
        /*
        public void Delete(Usuario usuario)
        {
            UsuarioData.Delete(id);
        }*/
    }
}
