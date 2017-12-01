CREATE TABLE [dbo].[Producto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Codigo] NVARCHAR(50) ,
    [Nombre] NVARCHAR(250), 
    [Marca] NVARCHAR(50), 
    [Grupo] NVARCHAR(50), 
    [SubGrupo] NVARCHAR(50),
	[Precio] MONEY NOT NULL
)
