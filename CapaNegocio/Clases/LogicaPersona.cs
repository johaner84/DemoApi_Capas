using CapaDatos;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class LogicaPersona : IPersona
    {
        private P2Context db;
        public LogicaPersona(P2Context db)
        {
            this.db = db;
        }

        public List<Persona> GetPersonas() 
        {
            return db.Personas.Where(a=>a.Activo==true).ToList();
        }

        public void SetPersona(Persona persona)
        { 
            db.Personas.Add(persona);
            db.SaveChanges();
        }
    }
}
