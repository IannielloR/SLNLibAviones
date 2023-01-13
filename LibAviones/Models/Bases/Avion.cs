using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibAviones.Models.Bases
{
    public abstract class Avion
    {
        public Avion(string piloto, string copiloto, string azafata)
        {
            this.Piloto = piloto;
            this.Copiloto = copiloto;
            this.Azafata = azafata;
        }
        public string Piloto { set; get; }
        public string Copiloto { set; get; }
        public string Azafata { set; get; }

        public abstract string Aterrizar();
        public abstract string Despegar();
    }
}
