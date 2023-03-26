using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.Models
{
    public class PessoaViewModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public double pretensao_salarial { get; set; }
        public string cargo_pretendido { get; set; }
        public List<ExperienciaViewModel> experiencia_profissional { get; set; }
        public List<FormacaoViewModel> formacao_academica { get; set; }
        public List<IdiomaViewModel> idioma { get; set; }
    }
}