﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    public class RequestModel
    {
        public string route { set; get; }
        public string method { set; get; }
        public object data { get; set; }
    }
}
