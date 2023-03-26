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

        public void Inserir(PessoaViewModel pessoa)
        {
            string sql =
            "insert into dados_pessoais " +
            "values (@nome, @cpf, @endereco, @telefone, " +
            "@email, @pretensao_salarial, @cargo_pretendido)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(pessoa));
        }

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

        public void Excluir(int id)
        {
            string sql = "delete dados_pessoais where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public PessoaViewModel Consulta(int id)
        {
            string sql = "select * from dados_pessoais where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaPessoa(tabela.Rows[0]);
        }

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

        public List<PessoaViewModel> Listagem()
        {
            List<PessoaViewModel> lista = new List<PessoaViewModel>();
            string sql = "select * from dados_pessoais order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaPessoa(registro));

            return lista;
        }
    }
}