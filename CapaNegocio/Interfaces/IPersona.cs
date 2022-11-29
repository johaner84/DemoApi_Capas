﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface IPersona
    {
        List<Persona> GetPersonas();

        void SetPersona(Persona persona);
        
    }
}
