CREATE TABLE [dbo].[Dim_Tiempo]
(
	[Tiempo_Key] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Fecha] DATETIME NOT NULL,
    [Año] INT NOT NULL, 
    [Mes] INT NOT NULL, 
    [Dia] INT NOT NULL, 
    [Hora] INT NOT NULL, 
    [Minuto] INT NOT NULL
)
