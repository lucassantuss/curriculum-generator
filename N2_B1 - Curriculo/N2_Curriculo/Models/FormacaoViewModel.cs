using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.Models
{
    public class FormacaoViewModel
    {
        public int id { get; set; }
        public int id_dados_pessoais { get; set; }
        public string instituicao { get; set; }
        public string curso { get; set; }
        public string situacao { get; set; }
        public DateTime data_conclusao { get; set; }
    }
}