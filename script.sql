-- Criar o banco de dados
CREATE DATABASE cadastroAutomoveis;
GO

-- Usar o banco de dados recém-criado
USE cadastroAutomoveis;
GO

-- Criar a tabela Combustivel
CREATE TABLE Combustivel (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descricao NVARCHAR(255) NOT NULL UNIQUE,
    status BIT
);
GO

-- Criar a tabela Cores
CREATE TABLE Cores (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descricao NVARCHAR(255) NOT NULL UNIQUE,
    status BIT
);
GO

-- Criar a tabela Veiculos
CREATE TABLE Veiculos (
    Placa NVARCHAR(10) PRIMARY KEY,
    Renavam NVARCHAR(20) UNIQUE,
    Numero_do_Chassi NVARCHAR(20) UNIQUE,
    Numero_do_motor NVARCHAR(20) UNIQUE,
    Marca NVARCHAR(100),
    Modelo NVARCHAR(100),
    Combustivel_id INT,
    Cor_id INT,
    Ano_de_Fabricacao INT,
    Status BIT,
    Foto VARBINARY(MAX),
    FOREIGN KEY (Combustivel_id) REFERENCES Combustivel(id),
    FOREIGN KEY (Cor_id) REFERENCES Cores(id)
);
GO 