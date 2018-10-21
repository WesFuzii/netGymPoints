using GymPoints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymPoints.Business
{
    public class RepositorioUsuario
    {
        private static RepositorioUsuario _repositorio;

        private List<Usuario> usuarios;

        private RepositorioUsuario()
        {
            usuarios = new List<Usuario>();
        }

        public static RepositorioUsuario Instance()
        {
            if (_repositorio == null)
                _repositorio = new RepositorioUsuario();

            return _repositorio;
        }

        public void IncluirUsuario(Usuario u)
        {
            u.Pontos = 0;
            u.Academia = "Academia Teste";
            usuarios.Add(u);
        }

        public IEnumerable<Usuario> ListarUsuarios()
        {
            return usuarios;
        }

        public Usuario ListarUsuario(int cpf)
        {
            return usuarios.Where(a => a.Cpf == cpf).Single();
        }

        public void ExcluirUsuario(int cpf)
        {
            usuarios.Remove(ListarUsuario(cpf));
        }

        public void AlterarUsuario(Usuario u)
        {
            usuarios.Where(ab => ab.Cpf == u.Cpf)
                .ToList()
                .ForEach(ae =>
                {
                    ae.Nome = u.Nome;
                    ae.Idade = u.Idade;
                    ae.Email = u.Email;
                    ae.Senha = u.Senha;
                });
        }

        public void AlterarAcademia(Usuario u, string academia)
        {
            usuarios.Where(ab => ab.Cpf == u.Cpf)
                .ToList()
                .ForEach(ae =>
                {
                    ae.Academia = academia;
                });
        }
    }
}