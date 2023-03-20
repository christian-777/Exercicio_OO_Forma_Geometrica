using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OO_Forma_Geometrica
{
    internal abstract class FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Base*Altura;
        }

        public override string ToString()
        {
            return this.Base + " " + this.Altura;
        }
    }
}
