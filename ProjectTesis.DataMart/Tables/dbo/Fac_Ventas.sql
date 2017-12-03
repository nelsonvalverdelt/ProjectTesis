CREATE TABLE [dbo].[Fac_Ventas]
(
	[Cliente_Key] INT NOT NULL, 
    [Empleado_Key] INT NOT NULL, 
    [Producto_Key] INT NOT NULL, 
    [Tiempo_Key] INT NOT NULL, 
	[Precio] MONEY NOT NULL,
	[Cantidad] INT NOT NULL,
    [Monto] MONEY NOT NULL, 
    [RecargoUsoTarjeta] MONEY NOT NULL, 
    [MontoTotal] MONEY NOT NULL, 
	PRIMARY KEY([Cliente_Key],[Empleado_Key],[Producto_Key],[Tiempo_Key]),
    CONSTRAINT [FK_Fac_Ventas_ToTable] FOREIGN KEY (Cliente_Key) REFERENCES Dim_Cliente(Cliente_Key), 
    CONSTRAINT [FK_Fac_Ventas_ToTable_1] FOREIGN KEY (Empleado_Key) REFERENCES Dim_Empleado(Empleado_Key), 
    CONSTRAINT [FK_Fac_Ventas_ToTable_2] FOREIGN KEY (Tiempo_Key) REFERENCES Dim_Tiempo(Tiempo_Key), 
    CONSTRAINT [FK_Fac_Ventas_ToTable_3] FOREIGN KEY (Producto_Key) REFERENCES Dim_Producto(Producto_Key)
)
