using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Fiap.Web.AspNet.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long Cpf { get; set; }
        public bool Maior { get; set; }
    }
}
