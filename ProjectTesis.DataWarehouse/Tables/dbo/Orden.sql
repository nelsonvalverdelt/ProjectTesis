CREATE TABLE [dbo].[Orden]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ClienteId] INT NOT NULL,
	[EmpleadoId] INT NOT NULL,
    [Codigo] NVARCHAR(50) NULL,
	[CodigoDocumento] NVARCHAR(50) NULL, 
	[FechaEmision] DATETIME NULL,
	[Recargo] DECIMAL(3,2) NULL,  
    [Estado] NVARCHAR(50) NULL, 
    [Vigencia] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Orden_Cliente] FOREIGN KEY (ClienteId) REFERENCES Cliente(Id), 
    CONSTRAINT [FK_Orden_Empleado] FOREIGN KEY (EmpleadoId) REFERENCES Empleado(Id) 
)
