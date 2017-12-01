CREATE TABLE [dbo].[OrdenDetalle]
(
	[OrdenId] INT NOT NULL, 
    [ProductoId] INT NOT NULL, 
    [PrecioUnitario] MONEY NULL, 
    [Cantidad] INT NULL, 
	PRIMARY KEY(OrdenId, ProductoId),
    CONSTRAINT [FK_OrdenDetalle_Producto] FOREIGN KEY (ProductoId) REFERENCES Producto(Id), 
    CONSTRAINT [FK_OrdenDetalle_Orden] FOREIGN KEY (OrdenId) REFERENCES Orden(Id)

)
