using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Imovel
    {

        public int imovelId { get; set; }

        public int Numero { get; set; }

        public float AreaUtil { get; set; }

        public Condominio Condominio { get; set; }

        public int CondominioId { get; set; }


    }
}
