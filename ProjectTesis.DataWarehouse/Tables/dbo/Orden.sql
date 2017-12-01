CREATE TABLE [dbo].[Orden]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ClienteId] INT NOT NULL,
	[EmpleadoId] INT NOT NULL,
    [Codigo] NVARCHAR(35) NULL,
	[FechaEmision] DATETIME NULL,
	[ModoPago] NVARCHAR(50),
	[FormaPago] NVARCHAR(50), 
    CONSTRAINT [FK_Orden_Cliente] FOREIGN KEY (ClienteId) REFERENCES Cliente(Id), 
    CONSTRAINT [FK_Orden_Empleado] FOREIGN KEY (EmpleadoId) REFERENCES Empleado(Id) 
)
