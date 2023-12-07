-- Scripts utilizados para criação de tabelas no banco de dados

CREATE TABLE Usuarios
(
    ID VARCHAR(36) PRIMARY KEY,
    Email NVARCHAR(50) NOT NULL,
    Senha NVARCHAR(50) NOT NULL
);

CREATE TABLE Todo
(
    ID VARCHAR(36) PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL,
    Done BIT NOT NULL,
    UserID VARCHAR(36) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Usuarios(ID)
);

