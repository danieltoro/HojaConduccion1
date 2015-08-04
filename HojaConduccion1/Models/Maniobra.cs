using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HojaConduccion1.Models
{
    public class Maniobra
    {
        public int ManiobraID { get; set; }

        public int Tren { get; set; }

        public int CocheP { get; set; }

        public int Radio { get; set; }

        public string LugarIni { get; set; }

        public DateTime HoraIni { get; set; }

        public DateTime HoraFin { get; set; }

        public string LugarFin { get; set; }

        public TimeSpan DuracionManiobra { get; set; }

            public void CalculoDuracionManiobra()
            {
                DuracionManiobra = HoraFin.Subtract(HoraIni);
            }
    }
}