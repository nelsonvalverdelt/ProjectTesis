﻿CREATE TABLE [dbo].[Empleado]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Usuario] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL
)
