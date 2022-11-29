using System;
using System.Collections.Generic;

namespace CapaDatos
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public string? Provincia { get; set; }
        public bool? Activo { get; set; }
    }
}
