using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios02Punto02POO.BL
{
    public class Cono
    {
        

        public double Altura { get; set; }
        public double Radio { get; set; }
        public double Generatriz { get; set; }

        
        
        public double GetArea() => Math.Round((Math.PI * Radio) * (Radio + Generatriz));
        public double GetVolumen() => Math.Round(((Math.PI * Math.Pow(Radio, 2)) * Altura) / 3);


    }
}
