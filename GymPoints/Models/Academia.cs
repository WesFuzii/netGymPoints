using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymPoints.Models
{
    public class Academia
    {
        public String Nome { get; set; }

        public Academia(String nome)
        {
            Nome = nome;
        }
    }
}