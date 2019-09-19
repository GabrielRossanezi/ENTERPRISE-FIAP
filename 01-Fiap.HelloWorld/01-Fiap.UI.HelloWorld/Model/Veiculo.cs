using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Veiculo
    {
        //Métodos
        public abstract void Ligar();

        //virtual -> permite a sobrescrita do método
        public virtual void Andar()
        {
            Console.WriteLine("Veiculo em movimento");
        }

        //Construtor - ctor tab tab
        public Veiculo()
        {

        }

        public Veiculo(string cor)
        {
            this.Cor = cor;
        }

        //Atributos - Fields/Campos
        private int _codigo;

        //Métodos - Gets/Sets
        public string Cor { get; set; }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

    }
}
