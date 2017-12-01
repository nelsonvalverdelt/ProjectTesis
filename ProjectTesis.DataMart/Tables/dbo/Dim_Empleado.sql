CREATE TABLE [dbo].[Dim_Empleado]
(
	[Empleado_Key] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Usuario] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL
)
