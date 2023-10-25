
DROP DATABASE VentasBD
CREATE DATABASE VentasBD

USE VentasBD
INSERT INTO Rol (IdRol, Descripcion) VALUES ('admin', 'Administrador');
INSERT INTO Rol (IdRol, Descripcion) VALUES ('cajero', 'Cajero');

INSERT INTO Usuario (IdUsuario, IdRol, FechaCreacion, NombreCompleto, Username, Clave) VALUES
('Usu-0001', 'admin', '2023-08-21', 'AdminUser', 'admin', '123'),
('Usu-0002', 'cajero', '2023-08-21', 'CajeroUser', 'cajero', '456');

USE VentasBD

CREATE TABLE Rol
(
	IdRol varchar(20) PRIMARY KEY NOT NULL,
	Descripcion varchar(50)NOT NULL,
)
CREATE TABLE Usuario
(
	IdUsuario varchar(20) PRIMARY KEY NOT NULL,
	IdRol varchar(20) FOREIGN KEY REFERENCES Rol(IdRol) NOT NULL,
	FechaCreacion varchar(20) NOT NULL,
	NombreCompleto varchar(70) NOT NULL,
   Username varchar(30)  COLLATE Latin1_General_CS_AS NOT NULL,
	Clave varchar(20) NOT NULL,
)


CREATE TABLE Proveedor(
	Cod_proveedor varchar(50) primary key NOT NULL,
	Nombre varchar(60)  NOT NULL,
	RUC varchar(30)  NOT NULL,
	Direccion varchar(50) NOT NULL,
	Telefono varchar(10) NOT NULL,
	Pagina varchar(70) NOT NULL,
		Estado varchar(15) NOT NULL,
)
CREATE TABLE Categorias(
	Cod_categoria varchar(50) primary key NOT NULL,
	Nombre varchar(60)  NOT NULL,
)



CREATE TABLE Cliente(
	Cod_cliente varchar(50) primary key NOT NULL,
	RUC varchar(30)  NOT NULL,
	Nombre varchar(60)  NOT NULL,
	Calle varchar(60)  NOT NULL,
	Comuna varchar(60)  NOT NULL,
	Ciudad varchar(60)  NOT NULL,
	 Celular VARCHAR(3) NOT NULL,
)
CREATE TABLE Telefono (
   Cod_telefono varchar(50) primary key NOT NULL,
	CodCliente varchar(50) FOREIGN KEY REFERENCES Cliente(Cod_cliente) NOT NULL,
    Numero varchar(20) NOT NULL,
   Compania varchar(20) NOT NULL,
)


CREATE TABLE Productos(
	Cod_producto varchar(50) primary key NOT NULL,
	Nombre varchar(200)  NOT NULL,
	Stock float NOT NULL,
	Precio_compra float NOT NULL,
	Precio_venta float NOT NULL,
	CodCategoria varchar(50) FOREIGN KEY REFERENCES Categorias(Cod_categoria) NOT NULL,
	CodProveedor varchar(50) FOREIGN KEY REFERENCES Proveedor(Cod_proveedor) NOT NULL,
	PDefinido VARCHAR(3) NOT NULL,
)
--DELETE DetalleVentas
--Delete Ventas
--DROP TABLE Compra
--DROP TABLE DetalleCompras
CREATE TABLE Compra(
        NFactura varchar(50) primary key NOT NULL,
        Fecha varchar(20)  NOT NULL,
        CodProveedor varchar(50) FOREIGN KEY REFERENCES Proveedor(Cod_proveedor) NOT NULL,
		Descuento float NOT NULL,
	    MontoTotal float NOT NULL,
			Estado varchar(15) NOT NULL,
)

CREATE TABLE DetalleCompras(
	 ID INT IDENTITY(1,1) PRIMARY KEY,
	Cod_detalle varchar(50)  NOT NULL,
	Factura varchar(50) FOREIGN KEY REFERENCES Compra(NFactura) NOT NULL,
	CodProducto varchar(50) FOREIGN KEY REFERENCES Productos(Cod_producto) NOT NULL,
	Cantidad float NOT NULL,
	MontoxProducto float NOT NULL
)

CREATE TABLE Ventas(
	NFactura varchar(50) primary key NOT NULL,
	Fecha varchar(20)  NOT NULL,
	CodCliente varchar(50) FOREIGN KEY REFERENCES Cliente(Cod_cliente) NOT NULL,
	Descuento float NOT NULL,
	MontoTotal float NOT NULL,
		Estado varchar(15) NOT NULL,
)
CREATE TABLE DetalleVentas(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Cod_detalle varchar(50)NOT NULL,
	Factura varchar(50) FOREIGN KEY REFERENCES Ventas(NFactura) NOT NULL,
	CodProducto varchar(50) FOREIGN KEY REFERENCES Productos(Cod_producto) NOT NULL,
	Cantidad float NOT NULL,
	MontoxProducto float NOT NULL
)

--SELECT COUNT(*) FROM DetalleCompras WHERE Factura <> 'mami' and Cod_detalle = 'DC-0001'
-- SELECT COUNT(*) FROM DetalleCompras WHERE Cod_detalle = 'DC-0001'
--SELECT * from Ventas
--SELECT COUNT(*) FROM DetalleCompras WHERE Factura =  'mami' and Cod_detalle = 'DC-0001'


--SELECT * FROM Telefono
