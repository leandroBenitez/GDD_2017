Create Table Dim_Funcionalidad
(
	Funcionalidad_Id int PRIMARY KEY IDENTITY(1,1),
	Funcionalidad_Desc nvarchar(250)
)

Create Table Dim_Rol
(
	Rol_Id int PRIMARY KEY IDENTITY(1,1),
	Rol_Desc nvarchar(255),
	Rol_Habilitado bit default 1--true
)

Create Table Rl_Rol_Funcionalidad
(
	Rol_Id int FOREIGN KEY REFERENCES Dim_Rol(Rol_Id),
	Funcionalidad_Id int FOREIGN KEY REFERENCES Dim_Funcionalidad(Funcionalidad_Id)
)

Create Table Lk_Usuario
(
	Usuario_Id int PRIMARY KEY IDENTITY(1,1),
	Usuario_Name nvarchar(250),
	Usuario_Password nvarchar(250),
	usuario_Habilitado bit default 1--true
)

Create Table Rl_Rol_Usuario
(
	Rol_Id int FOREIGN KEY REFERENCES Dim_Rol(Rol_Id),
	Usuario_Id int FOREIGN KEY REFERENCES Lk_Usuario(Usuario_Id)
)

Create Table Lg_Loggin
(
	Loggin_Id int PRIMARY KEY IDENTITY(1,1),
	Loggin_Usuario_Id int FOREIGN KEY REFERENCES Lk_Usuario(Usuario_Id),
	Loggin_Fecha datetime
)

Create Table Lk_Cliente
(
	Cliente_Dni int PRIMARY KEY,
	Cliente_Apellido nvarchar(255),
	Cliente_Nombre nvarchar(255),
	Cliente_Fecha_Nac datetime,
	Cliente_Mail nvarchar(255),
	Cliente_Direccion nvarchar(255),
	Cliente_Codigo_Postal nvarchar(255)
)

Create Table Dim_Rubro
(
	Rubro_Id int PRIMARY KEY,
	Rubro_Descripcion nvarchar(50)
)

Create Table Dim_Empresa
(
	Empresa_Id int PRIMARY KEY,
	Empresa_Nombre nvarchar(255),
	Empresa_Cuit nvarchar(50),
	Empresa_Direccion nvarchar(255),
	Empresa_Rubro_Id int FOREIGN KEY REFERENCES Dim_Rubro(Rubro_Id)
)

Create Table Lk_Factura
(
	Factura_Nro int PRIMARY KEY,
	Factura_Fecha datetime,
	Factura_Total numeric(18,2),
	Factura_Fecha_Vencimiento datetime,
	Factura_Cliente_Id int FOREIGN KEY REFERENCES Lk_Cliente(Cliente_Dni),
	Factura_Empresa_Id int FOREIGN KEY REFERENCES Dim_Empresa(Empresa_Id)
)

Create Table Lk_Item_Factura
(
	Item_Nro int PRIMARY KEY,
	Item_Cantidad int,
	Item_Monto numeric(18,2),
	Item_Factura_Nro int FOREIGN KEY REFERENCES Lk_Factura(Factura_Nro)
)

Create Table Dim_FormaPago
(
	FormaPago_Id int PRIMARY KEY,
	FormaPago_Desc nvarchar(255)
)

Create Table Dim_Sucursal
(
	Sucursal_Id int PRIMARY KEY,
	Sucursal_Nombre nvarchar(50),
	Sucursal_Direccion nvarchar(50),
	Sucursal_Codigo_Postal int
)

Create Table Dim_Motivo_Dev
(
	Motivo_Dev_Id int PRIMARY KEY IDENTITY(1,1),
	Motivo_Dev_Desc nvarchar(255)
)

Create Table Ft_Devolucion
(
	Devolucion_Id int PRIMARY KEY IDENTITY (1,1),
	Devolucion_Motivo_Id int FOREIGN KEY REFERENCES Dim_Motivo_Dev(Motivo_Dev_Id),
	Devolucion_Fecha datetime,
	Devolucion_Resp_Id int FOREIGN KEY REFERENCES Lk_Usuario(Usuario_Id)
)

Create Table Ft_Pago
(
	Pago_Nro int PRIMARY KEY,
	Pago_Fecha datetime,
	Pago_Factura_Id int FOREIGN KEY REFERENCES Lk_Factura(Factura_Nro),
	Pago_Item_nro int,
	Pago_Total numeric(18, 2),
	Pago_FormaPago_Id int FOREIGN KEY REFERENCES Dim_FormaPago(FormaPago_Id),
	Pago_Sucursal_Id int FOREIGN KEY REFERENCES Dim_Sucursal(Sucursal_Id),
	Pago_Dev int FOREIGN KEY REFERENCES Ft_Devolucion(Devolucion_Id) NULL,
	Pago_Resp_Id int FOREIGN KEY REFERENCES Lk_Usuario(Usuario_Id)
)

Create Table Ft_Rendicion
(
	Rendicion_Nro int PRIMARY KEY,
	Rendicion_Fecha datetime,
	ItemRendicion_nro int,
	ItemRendicion_Importe numeric(18,2),
	Rendicion_Factura_Nro int FOREIGN KEY REFERENCES Lk_Factura(Factura_Nro),
	Rendicion_Dev int FOREIGN KEY REFERENCES Ft_Devolucion(Devolucion_Id) NULL,
	Rendicion_Resp_Id int FOREIGN KEY REFERENCES Lk_Usuario(Usuario_Id)
)

Drop Table Ft_Rendicion
Drop Table Ft_Pago
Drop Table Ft_Devolucion
Drop Table Dim_Motivo_Dev
Drop Table Dim_Sucursal
Drop Table Dim_FormaPago
Drop Table Lk_Item_Factura
Drop Table Lk_Factura
Drop Table Dim_Empresa
Drop Table Dim_Rubro
Drop Table Lk_Cliente
Drop Table Lg_Loggin
Drop Table Rl_Rol_Usuario
Drop Table Lk_Usuario
Drop Table Rl_Rol_Funcionalidad
Drop Table Dim_Rol
Drop Table Dim_Funcionalidad