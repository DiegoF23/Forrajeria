--PROCEDIMIENTO ALMACENADO PARA LOGUEAR

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
	Select ProductoID as 'Codigo',Nombre,Descripcion,Precio,Stock,ProveedorID as 'Proveedor' From Productos;
END