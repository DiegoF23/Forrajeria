DROP DATABASE Forrajeria

-- Eliminar la base de datos si existe
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'Forrajeria')
BEGIN
    USE master;
	 --DATABASE Forrajeria SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

-- Eliminar la base de datos Forrajeria
		DROP DATABASE Forrajeria;
END
 USE master;
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
    Fecha nvarchar(255) NOT NULL,
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



--Ingreso usuario Adminstrador
INSERT INTO Usuarios(NombreUsuario,Pass,NombreCompleto,Rol)
VALUES('admin','admin','Administrador','Administrador');


--ingresos Proveedores
insert into Proveedores(Nombre,Direccion,Telefono ) 
values ('ProveedorEjemplo1','calle falsa 123','381551112234');

insert into Proveedores(Nombre,Direccion,Telefono ) 
values ('ProveedorEjemplo2','calle falsa 12332','3815511234');

insert into Proveedores(Nombre,Direccion,Telefono ) 
values ('ProveedorEjemplo3','calle frias silva 1231','381665441');

insert into Proveedores(Nombre,Direccion,Telefono ) 
values ('ProveedorEjemplo4','calle lucero 321','381778855');

--ingresos Productos
insert into Productos(Nombre,Descripcion,Precio,Stock,ProveedorID)
values ('Purina','Suplementos vitamínicos y minerales para animales.',3500,10,1);


SELECT * FROM Usuarios;
select * from Productos;
select * from Proveedores;

--update Productos
--set stock=10