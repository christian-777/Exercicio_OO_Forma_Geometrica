using System.Xml;
using Exercicio_OO_Forma_Geometrica;

internal class Program
{
    private static void Main(string[] args)
    {
        Quadrado quadrado= new Quadrado();
        Triangulo triangulo= new Triangulo();  

        quadrado.Base = 10;
        quadrado.Altura = quadrado.Base;

        triangulo.Base = 3;
        triangulo.Altura = 14;

        Console.WriteLine(quadrado.ToString());
        Console.WriteLine(triangulo.ToString());

        Console.WriteLine(quadrado.Area());
        Console.WriteLine(triangulo.Area());
        /*Console.WriteLine("digite a base: ");
        int base1= int.Parse(Console.ReadLine());

        Console.WriteLine("digite a altura: ");
        int altura = int.Parse(Console.ReadLine());

        Quadrado quadrado = new Quadrado(base1);
        Triangulo triangulo = new Triangulo(base1, altura);

        Console.WriteLine("se for quadrado: " + quadrado.Area());
        Console.WriteLine("se for triangulo: " + triangulo.Area());*/
    }
}
