CREATE TABLE [dbo].[Dim_Cliente]
(
	[Cliente_Key] INT NOT NULL PRIMARY KEY IDENTITY,
	[ClienteId] INT NOT NULL,
    [Documento] NVARCHAR(50) NOT NULL, 
    [Nombre] NVARCHAR(255) NOT NULL
)
