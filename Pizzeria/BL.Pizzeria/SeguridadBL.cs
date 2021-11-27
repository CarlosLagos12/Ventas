using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class SeguridadBL
    {
        contexto _Contexto;

        public SeguridadBL()
          {
            _Contexto = new contexto();
          }

        public object _contexto { get; private set; }

        public Usuario Autorizar(string usuario, string contraseña)
        {
            var usuarios = _contexto.Usuarios.ToList();

        foreach (var usuarioDB in usuarios)
        {
            if(usuario == usuarioDB.Nombre && contraseña == usuarioDB.contraseña)
            {
                return usuarioDB;
            }
        }

            return null;
        }
    }
      public class Usuario
      {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string contraseña { get; set;}
      }
    }


