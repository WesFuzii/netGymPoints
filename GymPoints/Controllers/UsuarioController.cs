using GymPoints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymPoints.Business;
using System.Threading.Tasks;

namespace GymPoints.Controllers
{
    public class UsuarioController : Controller
    {

        public async Task<ActionResult> Index(Usuario u)
        {
            Usuario aux = RepositorioUsuario.Instance().ListarUsuario(u.Cpf);
            aux.Frequencias = await FrequenciaBusiness.getFrequencias();
            
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