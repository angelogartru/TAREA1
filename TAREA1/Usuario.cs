﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1
{
    internal class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool activo { get; set; }
    }
}
