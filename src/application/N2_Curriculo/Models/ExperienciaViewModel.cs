using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.Models
{
    public class ExperienciaViewModel
    {
        public int id { get; set; }
        public int id_dados_pessoais { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
    }
}