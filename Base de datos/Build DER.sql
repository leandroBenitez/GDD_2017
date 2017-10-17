--Drop de tablas
IF OBJECT_ID('PAGO_AGIL.Rl_DevolucioxFactura', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Rl_DevolucioxFactura;

IF OBJECT_ID('PAGO_AGIL.RL_PagoxFactura', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.RL_PagoxFactura;
  
IF OBJECT_ID('PAGO_AGIL.RL_UsuarioxSucursal', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.RL_UsuarioxSucursal;

IF OBJECT_ID('PAGO_AGIL.Ft_Pago', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Ft_Pago;

IF OBJECT_ID('PAGO_AGIL.Ft_Devolucion', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Ft_Devolucion;
  
IF OBJECT_ID('PAGO_AGIL.Dim_Motivo_Dev', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Motivo_Dev;

IF OBJECT_ID('PAGO_AGIL.Dim_Sucursal', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Sucursal;

IF OBJECT_ID('PAGO_AGIL.Dim_FormaPago', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_FormaPago;

IF OBJECT_ID('PAGO_AGIL.Lk_Item_Factura', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Lk_Item_Factura;

IF OBJECT_ID('PAGO_AGIL.Lk_Factura', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Lk_Factura;

IF OBJECT_ID('PAGO_AGIL.Ft_Rendicion', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Ft_Rendicion;

IF OBJECT_ID('PAGO_AGIL.Dim_Empresa', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Empresa;

IF OBJECT_ID('PAGO_AGIL.Dim_Rubro', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Rubro;

IF OBJECT_ID('PAGO_AGIL.Lk_Cliente', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Lk_Cliente;

IF OBJECT_ID('PAGO_AGIL.Lg_Loggin_Incorrecto', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Lg_Loggin_Incorrecto;

IF OBJECT_ID('PAGO_AGIL.Rl_RolxUsuario', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Rl_RolxUsuario;

IF OBJECT_ID('PAGO_AGIL.Lk_Usuario', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Lk_Usuario;

IF OBJECT_ID('PAGO_AGIL.Rl_RolxFuncionalidad', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Rl_RolxFuncionalidad;

IF OBJECT_ID('PAGO_AGIL.Dim_Funcionalidad', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Funcionalidad;

IF OBJECT_ID('PAGO_AGIL.Dim_Rol', 'U') IS NOT NULL 
  DROP TABLE PAGO_AGIL.Dim_Rol;
Go

--Creacion de tablas
Create Table PAGO_AGIL.Dim_Rol
(
	Rol_Id int PRIMARY KEY IDENTITY(1,1),
	Rol_Desc nvarchar(255),
	Rol_Habilitado bit default 1--true
)

Create Table PAGO_AGIL.Dim_Funcionalidad
(
	Funcionalidad_Id int PRIMARY KEY IDENTITY(1,1),
	Funcionalidad_Desc nvarchar(250)
)

Create Table PAGO_AGIL.Rl_RolxFuncionalidad
(
	Rol_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Rol(Rol_Id),
	Funcionalidad_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Funcionalidad(Funcionalidad_Id)
)

Create Table PAGO_AGIL.Lk_Usuario
(
	Usuario_Id int PRIMARY KEY IDENTITY(1,1),
	Usuario_Name nvarchar(250),
	Usuario_Password nvarchar(250),
	Usuario_Habilitado bit default 1--true
)

Create Table PAGO_AGIL.Rl_RolxUsuario
(
	Rol_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Rol(Rol_Id),
	Usuario_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id)
)

Create Table PAGO_AGIL.Lg_Loggin_Incorrecto
(
	Loggin_Id int PRIMARY KEY IDENTITY(1,1),
	Loggin_Usuario_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id),
	Loggin_Fecha datetime
)

Create Table PAGO_AGIL.Lk_Cliente
(
	Cliente_Id int PRIMARY KEY IDENTITY(1,1),
	Cliente_Dni int,
	Cliente_Apellido nvarchar(255),
	Cliente_Nombre nvarchar(255),
	Cliente_Telefono nvarchar(255),
	Cliente_Fecha_Nac datetime,
	Cliente_Mail nvarchar(255) UNIQUE,
	Cliente_Direccion nvarchar(255),
	Cliente_Codigo_Postal nvarchar(255),
	Cliente_Habilitado bit default 1--true
)

Create Table PAGO_AGIL.Dim_Rubro
(
	Rubro_Id int PRIMARY KEY,
	Rubro_Descripcion nvarchar(50)
)

Create Table PAGO_AGIL.Dim_Empresa
(
	Empresa_Id int PRIMARY KEY,
	Empresa_Nombre nvarchar(255),
	Empresa_Cuit nvarchar(50),
	Empresa_Direccion nvarchar(255),
	Empresa_Rubro_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Rubro(Rubro_Id),
	Empresa_Habilitado bit default 1--true
)

Create Table PAGO_AGIL.Ft_Rendicion
(
	Rendicion_Id int PRIMARY KEY,
	Rendicion_Fecha datetime,
	Rendicion_nfacturas bit,
	Rendicion_ItemNro int,
	Rendicion_Comision numeric(18,2),
	Rendicion_Total numeric(18,2),
	Rendicion_Resp_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id)
)

Create Table PAGO_AGIL.Lk_Factura
(
	Factura_Id int PRIMARY KEY IDENTITY(1,1),
	Factura_Nro int,
	Factura_Fecha_Alta datetime,
	Factura_Total numeric(18,2),
	Factura_Fecha_Vencimiento datetime,
	Factura_Cliente_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Cliente(Cliente_Id),
	Factura_Empresa_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Empresa(Empresa_Id),
	Factura_Rendicion_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Ft_Rendicion(Rendicion_Id)
)

Create Table PAGO_AGIL.Lk_Item_Factura
(
	Item_Id int PRIMARY KEY,
	Item_Cantidad int,
	Item_Monto numeric(18,2),
	Item_Factura_Nro int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Factura(Factura_Id)
)

Create Table PAGO_AGIL.Dim_FormaPago
(
	FormaPago_Id int PRIMARY KEY,
	FormaPago_Desc nvarchar(255)
)

Create Table PAGO_AGIL.Dim_Sucursal
(
	Sucursal_Id int PRIMARY KEY,
	Sucursal_Nombre nvarchar(50),
	Sucursal_Direccion nvarchar(50),
	Sucursal_Codigo_Postal int,
	Sucursal_Habilitado bit default 1 -- true
)

Create Table PAGO_AGIL.Dim_Motivo_Dev
(
	Motivo_Dev_Id int PRIMARY KEY IDENTITY(1,1),
	Motivo_Dev_Desc nvarchar(255)
)

Create Table PAGO_AGIL.Ft_Devolucion
(
	Devolucion_Id int PRIMARY KEY IDENTITY (1,1),
	Devolucion_Motivo_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Motivo_Dev(Motivo_Dev_Id),
	Devolucion_Fecha datetime,
	Devolucion_Resp_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id)
)

Create Table PAGO_AGIL.Ft_Pago
(
	Pago_Id int PRIMARY KEY,
	Pago_Fecha datetime,
	Pago_Item_nro int,
	Pago_Total numeric(18, 2),
	Pago_FormaPago_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_FormaPago(FormaPago_Id),
	Pago_Sucursal_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Sucursal(Sucursal_Id),
	Pago_Resp_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id)
)

Create Table PAGO_AGIL.RL_UsuarioxSucursal
(
	Id_usuario int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Usuario(Usuario_Id),
	Id_Sucursal int FOREIGN KEY REFERENCES PAGO_AGIL.Dim_Sucursal(Sucursal_Id)
)

Create Table PAGO_AGIL.RL_PagoxFactura
(
	Id_Factura int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Factura(Factura_Id),
	Id_Pago int FOREIGN KEY REFERENCES PAGO_AGIL.Ft_Pago(Pago_Id)
)

Create Table PAGO_AGIL.Rl_DevolucioxFactura
(
	Id_Devolucion int FOREIGN KEY REFERENCES PAGO_AGIL.Ft_Devolucion(Devolucion_Id),
	Id_Factura int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Factura(Factura_Id)
)
Go