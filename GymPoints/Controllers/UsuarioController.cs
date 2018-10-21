using GymPoints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymPoints.Business;

namespace GymPoints.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Index(Usuario u)
        {
            Usuario aux = RepositorioUsuario.Instance().ListarUsuario(u.Cpf);
            return View(aux);
        }

        public ActionResult Alterar()
        {
            return View();
        }

        public ActionResult Loja()
        {
            return View();
        }
    }
}