using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIEquipos.Models
{
    public class Equipo
    {
        public int id { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreDirector { get; set; }
    }
}