using GymPoints.Business;
using GymPoints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GymPoints.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            await AutenticacaoSF.autenticarSF();

            return View();
        }
    }
}