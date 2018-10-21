using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymPoints.Models
{
    public class Usuario
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }        
        public string Email { get; set; }
        public string Senha { get; set; }

        public int Pontos { get; set; }
        public string Academia { get; set; }
        public List<Frequencia> Frequencias { get; set; }

    }
}