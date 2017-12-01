CREATE TABLE [dbo].[Fac_Ventas]
(
	[Cliente_Key] INT NOT NULL PRIMARY KEY, 
    [Empleado_Key] INT NOT NULL, 
    [Producto_Key] INT NOT NULL, 
    [Tiempo_Key] INT NOT NULL, 
    [Monto] MONEY NOT NULL, 
    [NroVentas] INT NOT NULL
)
