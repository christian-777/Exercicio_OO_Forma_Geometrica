using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OO_Forma_Geometrica
{
    internal class Triangulo : FormaGeometrica
    {
        public double Area()
        {
            return (this.Base * this.Altura) / 2;
        }
    }
}
