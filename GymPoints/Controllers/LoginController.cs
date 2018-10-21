using GymPoints.Models;
using GymPoints.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymPoints.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario u)
        {

            if (ModelState.IsValid)
            {
                RepositorioUsuario.Instance().IncluirUsuario(u);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Error");
        }

        [HttpPost]
        public ActionResult Index(Usuario u)
        {
            IEnumerable<Usuario> usuarios = RepositorioUsuario.Instance().ListarUsuarios();
            if (ModelState.IsValid)
            {
                if (usuarios.Any())
                {
                    Usuario aux = usuarios.Where(ab => ab.Email == u.Email && ab.Senha == u.Senha).Single();
                    if (aux != null)
                    {
                        return RedirectToAction("Index", "Usuario", aux);
                    }
                }
            }
            return RedirectToAction("Error");          
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}