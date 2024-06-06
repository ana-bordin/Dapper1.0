USE [Dapper]
GO

CREATE TABLE [dbo].[TB_PEDIDO]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
	[Mesa] [int] NOT NULL,
 CONSTRAINT [pk_Pedido] PRIMARY KEY (Id)
)


