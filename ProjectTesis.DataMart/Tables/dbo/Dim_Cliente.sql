CREATE TABLE [dbo].[Dim_Cliente]
(
	[Cliente_Key] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Documento] NVARCHAR(50) NOT NULL, 
    [Nombre] NVARCHAR(100) NOT NULL

)
