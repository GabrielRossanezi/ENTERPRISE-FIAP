using _01_Fiap.UI.HelloWorld.Model;
using System;

namespace Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro();
            //Atribuir um código ao carro
            carro.Codigo = 10;
            carro.Tipo = TipoCarro.Hatch;
            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);

            //Intanciar um carro 2
            Carro carro2 = new Carro()
            {
                Portas = 4,
                Valor = 100000
            };

        }
    }
}
