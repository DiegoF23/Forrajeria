--PROCEDIMIENTO ALMACENADO PARA LOGUEAR
 use Forrajeria;

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