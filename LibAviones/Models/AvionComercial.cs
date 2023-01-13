using LibAviones.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibAviones.Models
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string piloto, string copiloto, string azafata, int prmCapacidad, string prmLineaAerea) : base(piloto, copiloto, azafata)
        {
            this.Capacidad = prmCapacidad;
            this.LineaAerea = prmLineaAerea;

        }
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        public override string Aterrizar()
        {
            return ("Aterrizo el avion comercial");
        }

        public override string Despegar()
        {
            return ("Despego el avion comercial");
        }
        public string Mostrar()
        {
            return ("Piloto: " + Piloto + "\nCopiloto: " + Copiloto + "\nAzafata: " + Azafata+ "\nCapacidad: " + Capacidad.ToString() + "\nLinea Aerea: " + LineaAerea);
        }
    }
}
