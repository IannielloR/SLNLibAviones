using LibAviones.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibAviones.Models
{
    public class AvionCarga : Avion
    {
        public AvionCarga(string piloto, string copiloto, string azafata, double prmPeso, string prmTipoMercaderia) : base(piloto, copiloto, azafata)
        {
            this.Peso = prmPeso;
            this.TipoMercaderia = prmTipoMercaderia;
        }

        public double Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override string Aterrizar()
        {
            return ("Aterrizo el avion de carga");
        }

        public override string Despegar()
        {
            return ("Despego el avion de carga");
        }
    }
}
