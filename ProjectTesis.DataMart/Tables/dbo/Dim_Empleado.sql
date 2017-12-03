CREATE TABLE [dbo].[Dim_Empleado]
(
	[Empleado_Key] INT NOT NULL PRIMARY KEY IDENTITY, 
	[EmpleadoId] INT NOT NULL,
	[Usuario] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL
)
