﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymPoints.Models
{
    public class Frequencia
    {
        public String Data { get; set; }

        public Frequencia(String data)
        {
            Data = data;
        }
    }
}