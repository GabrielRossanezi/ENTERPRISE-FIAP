using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Models
{
    public class Time
    {
        public string Nome { get; set; }
        public bool Classificado { get; set; }
        public int Vitorias { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Data de Fundação")]
        public DateTime DataFundacao { get; set; }

        [Display(Name = "Folha de Pagamento")]
        public decimal FolhaPagamento { get; set; }
    }
}
