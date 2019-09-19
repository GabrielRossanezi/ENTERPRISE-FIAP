using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Exercicio01.Exception
{
    //Exception -> tab tab
    [Serializable]
    public class SaldoInsuficienteException : System.Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, System.Exception inner) : base(message, inner) { }
        protected SaldoInsuficienteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
