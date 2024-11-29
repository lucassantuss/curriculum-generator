using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public static class ConexaoBD
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST\\SQLEXPRESS; Database=db_Curriculo; Integrated Security=True;";
            //string strCon = "Data Source=LOCALHOST\\SQLEXPRESS; Database=db_Curriculo; user id=sa; password=123456";
            // string strCon = "Data Source=LOCALHOST; Database=db_Curriculo; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}

/* Script de Criação do Banco e das tabelas necessárias

    create database db_Curriculo;
    use db_Curriculo;

    CREATE TABLE dados_pessoais (
        id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        nome VARCHAR(100) NOT NULL,
        cpf VARCHAR(15) NOT NULL,
        endereco VARCHAR(100) NOT NULL,
        telefone VARCHAR(15) NOT NULL,
        email VARCHAR(50) NOT NULL,
        pretensao_salarial DECIMAL(10, 2) NOT NULL,
        cargo_pretendido VARCHAR(50) NOT NULL
    );

    CREATE TABLE formacao_academica (
        id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        id_dados_pessoais INT NOT NULL,
        instituicao VARCHAR(100),
        curso VARCHAR(50),
        situacao VARCHAR(20),
        data_conclusao DATE,
        FOREIGN KEY (id_dados_pessoais) REFERENCES dados_pessoais(id)
    );

    CREATE TABLE experiencia_profissional (
        id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        id_dados_pessoais INT NOT NULL,
        empresa VARCHAR(100) NOT NULL,
        cargo VARCHAR(50) NOT NULL,
        data_inicio DATE NOT NULL,
        data_fim DATE,
        FOREIGN KEY (id_dados_pessoais) REFERENCES dados_pessoais(id)
    );

    CREATE TABLE idiomas (
        id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        id_dados_pessoais INT NOT NULL,
        idioma VARCHAR(50) NOT NULL,
        nivel VARCHAR(20) NOT NULL,
        FOREIGN KEY (id_dados_pessoais) REFERENCES dados_pessoais(id)
    );
*/