-- Atividade N2 - 1� Bimestre
-- Lucas Ara�jo dos Santos - RA: 081210009
-- Renan C�sar de Ara�jo   - RA: 081210033

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

select * from dados_pessoais;
select * from experiencia_profissional;
select * from formacao_academica;
select * from idiomas;

INSERT INTO dados_pessoais VALUES
('Lucas', '087.956.050-96', 'Rua Jo�o Pereira, 145', '11 98596-1254', 'lucas@gmail.com', 5500, 'Desenvolvedor Sr.'),
('Pedro', '474.773.020-64', 'Rua Amadeu de Souza, 5031', '11 97858-1212', 'pedro_p@gmail.com', 2500, 'Cozinheiro'),
('Maria', '615.790.840-87', 'Rua Pirapora, 22', '11 98855-2233', 'maria_clara@gmail.com', 4000, 'M�dica');

INSERT INTO experiencia_profissional VALUES
(1, 'Termomecanica', 'Estagi�rio', '2023-01-01', '2024-12-31'),
(1, 'SBK', 'Analista de Suporte', '2021-12-01', '2022-12-31'),
(2, 'Outback', 'Auxiliar de Cozinha', '2021-01-01', '2023-01-01'),
(3, 'UBS S�o Carlos', 'Atendente de Hospital', '2022-12-01', '2023-07-01');

INSERT INTO formacao_academica VALUES
(1, 'ETEC Lauro Gomes', 'T�cnico em Inform�tica', 'Conclu�do', '2020-12-31'),
(1, 'Faculdade Engenheiro Salvador Arena', 'Engenharia de Computa��o', 'Em andamento', '2023-05-01'),
(2, 'Mais Voc� Academy', 'Culin�ria', 'Conclu�do', '2022-12-31'),
(3, 'USP', 'Medicina', 'Em andamento', '2023-09-01');

INSERT INTO idiomas VALUES
(1, 'Portugu�s', 'Nativo'),
(1, 'Espanhol', 'Intermedi�rio'),
(2, 'Portugu�s', 'Nativo'),
(2, 'Ingl�s', 'Intermedi�rio'),
(3, 'Portugu�s', 'Nativo');