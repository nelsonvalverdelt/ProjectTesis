﻿CREATE TABLE [dbo].[Dim_Producto]
(
	[Producto_Key] INT NOT NULL PRIMARY KEY IDENTITY,
	[Codigo] NVARCHAR(35) NOT NULL,
    [Nombre] NVARCHAR(150) NOT NULL, 
    [Marca] NVARCHAR(50) NOT NULL, 
    [Grupo] NVARCHAR(50) NOT NULL, 
    [SubGrupo] NVARCHAR(50) NOT NULL
)
