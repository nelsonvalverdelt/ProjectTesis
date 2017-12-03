CREATE TABLE [dbo].[Dim_Producto]
(
	[Producto_Key] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductoId] INT NOT NULL,
	[Codigo] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL, 
    [Marca] NVARCHAR(50) NOT NULL, 
    [Grupo] NVARCHAR(50) NOT NULL, 
    [SubGrupo] NVARCHAR(50) NOT NULL
)
