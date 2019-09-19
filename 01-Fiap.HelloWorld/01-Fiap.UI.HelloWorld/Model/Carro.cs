using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Carro : Veiculo, IAutomatico
    {
        //Métodos
        public override void Ligar()
        {
            Console.WriteLine("Carro ligando");
        }

        public override void Andar()
        {
            Console.WriteLine("Carro andando");
        }

        public void TrocarMarcha()
        {
            Console.WriteLine("Trocando de marcha");
        }

        //Construtor
        public Carro()
        {

        }

        public Carro(string cor) : base(cor)
        {

        }

        //Propriedades (gets e sets)
        public int Portas { get; set; }
        public decimal Valor { get; set; }
        public TipoCarro Tipo { get; set; }

    }
}
