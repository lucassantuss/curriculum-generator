using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using N2_Curriculo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public class PessoaDAO
    {
        /// <summary>
        /// Método que recebe os dados de PessoaViewModel e retorna um SqlParameter desses campos
        /// </summary>
        private SqlParameter[] CriaParametros(PessoaViewModel pessoa)
        {
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("id", pessoa.id);
            p[1] = new SqlParameter("nome", pessoa.nome);
            p[2] = new SqlParameter("cpf", pessoa.cpf);
            p[3] = new SqlParameter("endereco", pessoa.endereco);
            p[4] = new SqlParameter("telefone", pessoa.telefone);
            p[5] = new SqlParameter("email", pessoa.email);
            p[6] = new SqlParameter("pretensao_salarial", pessoa.pretensao_salarial);
            p[7] = new SqlParameter("cargo_pretendido", pessoa.cargo_pretendido);

            return p;
        }

        /// <summary>
        /// Query utilizada para inserir uma nova pessoa
        /// </summary>
        public void Inserir(PessoaViewModel pessoa)
        {
            string sql =
            "insert into dados_pessoais " +
            "values (@nome, @cpf, @endereco, @telefone, " +
            "@email, @pretensao_salarial, @cargo_pretendido)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(pessoa));
        }

        /// <summary>
        /// Query utilizada para alterar uma pessoa existente
        /// </summary>
        public void Alterar(PessoaViewModel pessoa)
        {
            string sql =
            "update dados_pessoais set nome = @nome, cpf = @cpf, " +
            "endereco = @endereco, telefone = @telefone, " +
            "email = @email, pretensao_salarial = @pretensao_salarial, " +
            "cargo_pretendido = @cargo_pretendido " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(pessoa));
        }

        /// <summary>
        /// Query utilizada para excluir uma pessoa existente baseado no Id da Pessoa
        /// </summary>
        public void Excluir(int id)
        {
            string sql = "delete dados_pessoais where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        /// <summary>
        /// Query utilizada para consultar os dados de uma pessoa existente
        /// </summary>
        public PessoaViewModel Consulta(int id)
        {
            string sql = "select * from dados_pessoais where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaPessoa(tabela.Rows[0]);
        }

        /// <summary>
        /// Método responsável por converter os dados de DataRow em PessoaViewModel 
        /// </summary>
        private PessoaViewModel MontaPessoa(DataRow registro)
        {
            PessoaViewModel p = new PessoaViewModel();
            p.id = Convert.ToInt32(registro["id"]);
            p.nome = registro["nome"].ToString();
            p.cpf = registro["cpf"].ToString();
            p.endereco = registro["endereco"].ToString();
            p.telefone = registro["telefone"].ToString();
            p.email = registro["email"].ToString();
            p.pretensao_salarial = Convert.ToDouble(registro["pretensao_salarial"]);
            p.cargo_pretendido = registro["cargo_pretendido"].ToString();

            return p;
        }

        /// <summary>
        /// Query utilizada para listar todas as pessoas existentes em um List<PessoaViewModel>
        /// </summary>
        public List<PessoaViewModel> Listagem()
        {
            List<PessoaViewModel> lista = new List<PessoaViewModel>();
            string sql = "select * from dados_pessoais order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaPessoa(registro));

            return lista;
        }

        /// <summary>
        /// Query utilizada para verificar qual será o próximo id a ser usado na criação de uma nova pessoa
        /// </summary>
        public int ProximoId()
        {
            string sql = "SELECT IDENT_CURRENT('dados_pessoais') + IDENT_INCR('dados_pessoais') AS MAIOR;";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}