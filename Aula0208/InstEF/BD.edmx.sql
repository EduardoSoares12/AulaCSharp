
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/14/2018 22:19:25
-- Generated from EDMX file: C:\Users\1704805\source\repos\AulaCSharp\Aula0208\InstEF\BD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PrimeriaBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CPF] time  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Endereços'
CREATE TABLE [dbo].[Endereços] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomeRua] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Endereços'
ALTER TABLE [dbo].[Endereços]
ADD CONSTRAINT [PK_Endereços]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Endereços'
ALTER TABLE [dbo].[Endereços]
ADD CONSTRAINT [FK_ClienteEndereço]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteEndereço'
CREATE INDEX [IX_FK_ClienteEndereço]
ON [dbo].[Endereços]
    ([ClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------