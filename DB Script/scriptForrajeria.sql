-- Eliminar la base de datos si existe
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'Forrajeria')
BEGIN
    ALTER DATABASE Forrajeria SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Forrajeria;
END

-- Crear la base de datos Forrajeria
CREATE DATABASE Forrajeria;

-- Usar la base de datos recién creada
USE Forrajeria;

-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
   UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
   NombreUsuario NVARCHAR(255) NOT NULL,
   Pass NVARCHAR(255) NOT NULL,
   NombreCompleto NVARCHAR(255),
   Rol NVARCHAR(50) NOT NULL
);

-- Crear la tabla Productos
CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Descripcion NVARCHAR(MAX),
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    ProveedorID INT
);

-- Crear la tabla Clientes
CREATE TABLE Clientes (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Direccion NVARCHAR(255),
    Telefono NVARCHAR(15)
);

-- Crear la tabla Ventas
CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
    ClienteID INT,
);

-- Crear la tabla DetallesVentas
CREATE TABLE DetallesVentas (
    DetalleVentaID INT IDENTITY(1,1) PRIMARY KEY,
    VentaID INT,
    ProductoID INT,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
);

-- Crear la tabla Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Direccion NVARCHAR(255),
    Telefono NVARCHAR(15)
);

-- Crear la tabla Compras
CREATE TABLE Compras (
   CompraID INT IDENTITY(1,1) PRIMARY KEY,
   Fecha DATE NOT NULL,
   ProveedorID INT
);

-- Agregar la restricción de clave foranea para la columna ProveedorID en la tabla Productos
ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Proveedores FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID);

-- Agregar la restricción de clave foranea para la columna ProveedorID en la tabla Compras
ALTER TABLE Compras
ADD CONSTRAINT FK_Compras_Proveedores FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID);

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

--Ingreso usuario Adminstrador
INSERT INTO Usuarios(NombreUsuario,Pass,NombreCompleto,Rol)
VALUES('admin','admin','Administrador','Administrador');

SELECT * FROM Usuarios;


