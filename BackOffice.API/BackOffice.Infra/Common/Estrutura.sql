-- Tabela Departamento
CREATE TABLE Departamento (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Nome NVARCHAR(255) NOT NULL,
    ResponsavelId UNIQUEIDENTIFIER,
    DataCadastro DATETIME NOT NULL,
    DataAtualizacao DATETIME NOT NULL,
    FOREIGN KEY (ResponsavelId) REFERENCES Pessoa(Id)
);

-- Tabela Endereco
CREATE TABLE Endereco (
    Rua NVARCHAR(255),
    Bairro NVARCHAR(255),
    Cidade NVARCHAR(255),
    UF NVARCHAR(2),
    IBGE NVARCHAR(10),
    PessoaId UNIQUEIDENTIFIER,
    FOREIGN KEY (PessoaId) REFERENCES Pessoa(Id)
);

-- Tabela Pessoa
CREATE TABLE Pessoa (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    TipoPessoa INT NOT NULL,
    Documento NVARCHAR(20) NOT NULL,
    Nome NVARCHAR(255) NOT NULL,
    Apelido NVARCHAR(255),
    DataCadastro DATETIME NOT NULL,
    DataAtualizacao DATETIME NOT NULL
);

-- Tabela Usuario
CREATE TABLE Usuario (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Login NVARCHAR(50) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Perfil INT NOT NULL,
    SenhaHash NVARCHAR(255) NOT NULL,
    Ativo BIT NOT NULL,
    DataCadastro DATETIME NOT NULL,
    DataAtualizacao DATETIME NOT NULL
);

-- Tabela Qualificacao
CREATE TABLE Qualificacao (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Descricao NVARCHAR(255) NOT NULL
);

-- Tabela PessoaQualificacao (Tabela intermediária)
CREATE TABLE PessoaQualificacao (
    PessoaId UNIQUEIDENTIFIER,
    QualificacaoId UNIQUEIDENTIFIER,
    PRIMARY KEY (PessoaId, QualificacaoId),
    FOREIGN KEY (PessoaId) REFERENCES Pessoa(Id),
    FOREIGN KEY (QualificacaoId) REFERENCES Qualificacao(Id)
);

ALTER TABLE Endereco
ADD Id UNIQUEIDENTIFIER PRIMARY KEY;