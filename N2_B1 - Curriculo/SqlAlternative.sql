-- Alternativa de Tabela Curriculo

-- Criação de tabela referente ao Curriculo
-- p_ referente a Pessoa
-- fa_ referente a Formação Acadêmica
-- ep_ referente a Experiência Profissional
-- id_ referente a Idioma
CREATE TABLE curriculo (
    p_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    p_nome VARCHAR(100) NOT NULL,
    p_cpf VARCHAR(15) NOT NULL,
    p_endereco VARCHAR(100) NOT NULL,
    p_telefone VARCHAR(15) NOT NULL,
    p_email VARCHAR(50) NOT NULL,
    p_pretensao_salarial DECIMAL(10, 2) NOT NULL,
    p_cargo_pretendido VARCHAR(50) NOT NULL,
    
	fa_instituicao VARCHAR(100),
    fa_curso VARCHAR(50),
    fa_situacao VARCHAR(20),
    fa_data_conclusao DATE,

    ep_empresa VARCHAR(100) NOT NULL,
    ep_cargo VARCHAR(50) NOT NULL,
    ep_data_inicio DATE NOT NULL,
    ep_data_fim DATE,

    id_idioma VARCHAR(50) NOT NULL,
    id_nivel VARCHAR(20) NOT NULL,
);

select * from curriculo;