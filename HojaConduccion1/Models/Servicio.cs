using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HojaConduccion1.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }

        public DateTime HIS { get; set; }

        public DateTime HTS { get; set; }

        public DateTime Fecha { get; set; }

        public string LugarRegistroHoja { get; set; }

        public TimeSpan CargaAsignada { get; set; }

        public TimeSpan CargaReal { get; set; }

        public TimeSpan MinutosExtra { get; set; }
    }
}