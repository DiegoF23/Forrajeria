CREATE PROCEDURE ingreso_PA
	@user NVARCHAR(80),
	@pass NVARCHAR(80)
AS
BEGIN
 SELECT * FROM Usuarios 
	WHERE NombreUsuario=@user
		AND Pass=@pass;
END;

CREATE PROCEDURE MostrarProductos
AS
BEGIN
	Select A.ProductoID as 'Codigo',A.Nombre,A.Descripcion,A.Precio,A.Stock,B.Nombre as 'Proveedor' From Productos as A
	inner join Proveedores as B
	on A.ProveedorID = B.ProveedorID;
	
END;


create procedure AgregarProductos
	@nombre nvarchar(255),
	@descripcion nvarchar(MAX),
	@precio decimal(10,2),
	@stock int,
	@idProveedor int
as
begin
	insert into Productos(Nombre,Descripcion,Precio,Stock,ProveedorID)
	values(@nombre,@descripcion,@precio,@stock,@idProveedor);
end;


create procedure EditarProductos
	@idProducto int,
	@nombre nvarchar(255),
	@descripcion nvarchar(MAX),
	@precio decimal(10,2),
	@stock int,
	@idProveedor int
as
begin
	update Productos 
	set
		Nombre = @nombre,
		Descripcion=@descripcion,
		Precio=@precio,
		Stock=@stock,
		ProveedorID=@idProveedor
	where 
		ProductoID=@idProducto;
end;

create procedure EliminarProductos
	 @id_producto int
as
begin
	delete from Productos
		where ProductoID=@id_producto;
end;



create procedure FiltroProductotexto
	@texto nvarchar(Max)
as
begin
	Select A.ProductoID as 'Codigo',A.Nombre,A.Descripcion,A.Precio,A.Stock,B.Nombre as 'Proveedor' From Productos as A
	inner join Proveedores as B
	on A.ProveedorID = B.ProveedorID
	where (			upper(A.Nombre) like UPPER('%'+@texto+'%'))
				or
					(upper(A.Descripcion) like upper('%'+@texto+'%'));
end;

create procedure FiltroProductoId
	@idProducto int
as
begin
	Select A.ProductoID as 'Codigo',A.Nombre,A.Descripcion,A.Precio,A.Stock,B.Nombre as 'Proveedor' From Productos as A
	inner join Proveedores as B
	on A.ProveedorID = B.ProveedorID
	where A.ProductoID like @idProducto; 
end;

create procedure selectProveedor
as 
begin
select ProveedorID, Nombre from Proveedores;
end;


--Proveedores

--Crear un registro (CREATE):

CREATE PROCEDURE sp_InsertarProveedor
    @Nombre NVARCHAR(255),
    @Direccion NVARCHAR(255),
    @Telefono NVARCHAR(15)
AS
BEGIN
    INSERT INTO Proveedores (Nombre, Direccion, Telefono)
    VALUES (@Nombre, @Direccion, @Telefono);
END;


--Leer registros (READ):

CREATE PROCEDURE sp_ListarProveedores
AS
BEGIN
    SELECT * FROM Proveedores;
END;

--Actualizar un registro (UPDATE):

CREATE PROCEDURE sp_ActualizarProveedor
    @ProveedorID INT,
    @Nombre NVARCHAR(255),
    @Direccion NVARCHAR(255),
    @Telefono NVARCHAR(15)
AS
BEGIN
    UPDATE Proveedores
    SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono
    WHERE ProveedorID = @ProveedorID;
END;

--Eliminar un registro (DELETE):

CREATE PROCEDURE sp_EliminarProveedor
    @ProveedorID INT
AS
BEGIN
    DELETE FROM Proveedores
    WHERE ProveedorID = @ProveedorID;
END;

----------------------------------------------------------------------------------
--Carrito--------------------

--Productos Disponibles
create procedure ProductosDisponibles 
as
begin
	select ProductoID as 'Codigo',Nombre,Descripcion,Stock,Precio from Productos
		where Stock > 0;
end;

--Filtrar Productos Disponibles texto
create procedure FiltroProdDispText
@texto nvarchar(Max)
as
begin
select ProductoID as 'Codigo',Nombre,Descripcion,Stock,Precio from Productos
		where Stock > 0
			and
			  (	upper(Nombre) like UPPER('%'+@texto+'%'))
				or
					(upper(Descripcion) like upper('%'+@texto+'%'));
end;
-- Filtrar Productos Disponibles int
create procedure FiltroProdDispInt
	@idProducto int
as
begin
	Select ProductoID as 'Codigo',Nombre,Descripcion,Stock,Precio From Productos as A

	where Stock > 0 and ProductoID like @idProducto; 
end;

-- traer detalles de producto para agregar al carro
create procedure productosDetalle
@idProd int
as
begin
	select Nombre, Precio from Productos
		where ProductoID = @idProd ;
end;

--Disminuir stock de Productos

create procedure restarStock
@idProd int,
@stock int
as
begin
	update Productos
	set
		Stock-=@stock
	where ProductoID= @idProd;
end;

--Restaurar Stock
create procedure restaurarStock
@idProd int,
@stock int
as
begin
	update Productos
	set
		Stock+=@stock
	where ProductoID= @idProd;
end;

-- stock actual
create procedure stockActual
@idProd int
as
begin
select Stock from Productos
	where ProductoID= @idProd;
end;

--Finalizar Venta
--cargar cliente y que devuelva el id generado
CREATE PROCEDURE InsertarClienteYObtenerID
(
    @nombre NVARCHAR(255),
    @direccion NVARCHAR(255),
    @telefono NVARCHAR(15)
)
AS
BEGIN
    -- Insertar datos en la tabla
    INSERT INTO Clientes (Nombre, Direccion,Telefono)
	 VALUES (@nombre, @direccion,@telefono);

    -- Obtener el ID generado
    SELECT SCOPE_IDENTITY() AS ClienteID;
END;

--Cargar Venta
CREATE PROCEDURE InsertarVentaYObtenerID
(
    @fecha NVARCHAR(255),
    @ClienteID int
)
AS
BEGIN
    -- Insertar datos en la tabla
    INSERT INTO Ventas(Fecha, ClienteID)
	  VALUES (@fecha, @ClienteID);

    -- Obtener el ID generado
    SELECT SCOPE_IDENTITY() AS VentaID;
END

--Cargar DetallesVenta
CREATE PROCEDURE InsertarDetallesVenta
	@VentaID int,
	@ProductoID int,
	@Cantidad int,
	@PrecioUnitario DECIMAL(10, 2)
as
begin
	insert into DetallesVentas(VentaID,ProductoID,Cantidad,PrecioUnitario)
	values(@VentaID,@ProductoID,@Cantidad,@PrecioUnitario);
end;

CREATE PROCEDURE ObtenerUltimoIDVenta
AS
BEGIN
    SELECT ISNULL(MAX(VentaID), 0) AS UltimoIDVenta
    FROM Ventas;
END;

--select * from Clientes;
select * from Ventas;
--select * from DetallesVentas;