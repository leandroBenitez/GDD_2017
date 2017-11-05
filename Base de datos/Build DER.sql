USE GD2C2017
Go

--Borrado de Stored Procedures
IF OBJECT_ID('PAGO_AGIL.Login') IS NOT NULL
	DROP PROCEDURE PAGO_AGIL.Login;
Go

IF OBJECT_ID('PAGO_AGIL.agregar_sucursal') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].agregar_sucursal
GO

IF OBJECT_ID('PAGO_AGIL.modificar_sucursal') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].modificar_sucursal
Go

IF OBJECT_ID('PAGO_AGIL.Modificar_Empresa') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Modificar_Empresa
Go

IF OBJECT_ID('PAGO_AGIL.Alta_Empresa') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Alta_Empresa
Go

IF OBJECT_ID('PAGO_AGIL.Baja_Empresa') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Baja_Empresa
Go

IF OBJECT_ID('PAGO_AGIL.Pago') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Pago
Go

IF OBJECT_ID('PAGO_AGIL.alta_factura') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].alta_factura
GO

IF OBJECT_ID('PAGO_AGIL.alta_item_fact') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].alta_item_fact
Go

IF OBJECT_ID('PAGO_AGIL.calcular_fact_total') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].calcular_fact_total
Go

IF OBJECT_ID('PAGO_AGIL.bajaCliente') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].bajaCliente
Go

IF OBJECT_ID('PAGO_AGIL.topMontoRendido') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].topMontoRendido
Go

IF OBJECT_ID('PAGO_AGIL.topPorcentajePago') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].topPorcentajePago
Go

IF OBJECT_ID('PAGO_AGIL.topCantidadPagos') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].topCantidadPagos
Go

IF OBJECT_ID('PAGO_AGIL.nuevoCliente') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].nuevoCliente
Go

IF OBJECT_ID('PAGO_AGIL.modificaCliente') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].modificaCliente
Go

IF OBJECT_ID('PAGO_AGIL.Alta_Rol') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].modificaCliente
Go

IF OBJECT_ID('PAGO_AGIL.Rol_Funcionalidad') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].modificaCliente
Go

IF OBJECT_ID('PAGO_AGIL.topPorcentajeFacturasEmpresa') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].topPorcentajeFacturasEmpresa
Go

IF OBJECT_ID('PAGO_AGIL..Rol_Funcionalidad_Modif') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Rol_Funcionalidad_Modif
Go

IF OBJECT_ID('PAGO_AGIL..Mod_Rol') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].Mod_Rol
Go

IF OBJECT_ID('PAGO_AGIL.FacturaPaga') IS NOT NULL
DROP PROCEDURE [PAGO_AGIL].FacturaPaga
Go


--Borrado de Vistas
IF OBJECT_ID('PAGO_AGIL.Vw_Rendidos') IS NOT NULL
    DROP VIEW PAGO_AGIL.Vw_Rendidos;

IF OBJECT_ID('PAGO_AGIL.Vw_User_Info') IS NOT NULL
    DROP VIEW PAGO_AGIL.Vw_User_Info;

IF OBJECT_ID('PAGO_AGIL.Vw_Empresa') IS NOT NULL
    DROP VIEW PAGO_AGIL.Vw_Empresa;
Go

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

IF OBJECT_ID('PAGO_AGIL.Baja_Rol', 'U') IS NOT NULL 
	DROP TABLE PAGO_AGIL.Baja_Rol;
Go



--Borrado de Schema
IF EXISTS (SELECT 'exists' FROM sys.schemas WHERE name = 'PAGO_AGIL')
	DROP SCHEMA PAGO_AGIL;
Go

--------------CREACION DE OBJETOS DE BASE DE DATOS---------------
--Creacion de Schema
CREATE SCHEMA PAGO_AGIL AUTHORIZATION gd
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
	Usuario_Password varbinary(32),
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
	Cliente_Mail nvarchar(255),
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
	Empresa_Id int PRIMARY KEY IDENTITY(1,1),
	Empresa_Nombre nvarchar(255),
	Empresa_Cuit nvarchar(50) UNIQUE,
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
	Factura_Rendicion_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Ft_Rendicion(Rendicion_Id),
	Factura_Pagado bit default 0 --1 pagado
)

Create Table PAGO_AGIL.Lk_Item_Factura
(
	Item_Id int PRIMARY KEY IDENTITY(1,1),
	Item_Cantidad int,
	Item_Monto numeric(18,2),
	Item_Factura_Nro int FOREIGN KEY REFERENCES PAGO_AGIL.Lk_Factura(Factura_Id)
)

Create Table PAGO_AGIL.Dim_FormaPago
(
	FormaPago_Id int PRIMARY KEY IDENTITY(1,1),
	FormaPago_Desc nvarchar(255)
)

Create Table PAGO_AGIL.Dim_Sucursal
(
	Sucursal_Id int PRIMARY KEY IDENTITY (1,1),
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

--Migracion de datos
--Carga de roles
Insert into PAGO_AGIL.Dim_Rol (Rol_Desc)
Values	('Administrador'),
		('Cobrador')

--Carga de funcionalidades
Insert into PAGO_AGIL.Dim_Funcionalidad (Funcionalidad_Desc)
Values	('ABM de Rol'),
		('ABM de Cliente'),
		('ABM de Empresa'),
		('ABM de Sucursal'),
		('ABM Facturas'),
		('Registro de Pago de Facturas'),
		('Rendicion de Facturas cobradas'),
		('Listado Estadistico')

--Carga de Roles x Funcionalidad
Insert into PAGO_AGIL.Rl_RolxFuncionalidad (Rol_Id, Funcionalidad_Id)
Values	 (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8) --Administrador
			  ,(2,2),(2,3)		,(2,5),(2,6),(2,7),(2,8) --Cobrador

--Carga de Usuarios
Insert into PAGO_AGIL.Lk_Usuario (Usuario_Name, Usuario_Password)
Values	 ('admin', HASHBYTES('SHA2_256','w23e'))
		,('user', HASHBYTES('SHA2_256','user'))

--Carga de Rol x Usuario
Insert into PAGO_AGIL.Rl_RolxUsuario (Rol_Id, Usuario_Id)
Values	 (1,1),(2,1) --Admin
		,(2,2)		 --User

--Carga de Clientes
Insert into PAGO_AGIL.Lk_Cliente (Cliente_Dni, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal)
Select distinct [Cliente-Dni],[Cliente-Apellido],[Cliente-Nombre],[Cliente-Fecha_Nac],Cliente_Mail,Cliente_Direccion, Cliente_Codigo_Postal  
from gd_esquema.Maestra

--Carga de Rubro
INSERT INTO PAGO_AGIL.Dim_Rubro (Rubro_Id ,	Rubro_Descripcion)
SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion 
FROM gd_esquema.Maestra

--Carga de Empresa
insert into PAGO_AGIL.Dim_Empresa (Empresa_Nombre,Empresa_Cuit,Empresa_Direccion,Empresa_Rubro_Id)
select distinct Empresa_Nombre, Empresa_Cuit,Empresa_Direccion,Empresa_Rubro 
from gd_esquema.Maestra

--Carga de Rendicion
Insert into PAGO_AGIL.Ft_Rendicion (Rendicion_Id, Rendicion_Fecha, Rendicion_nfacturas, Rendicion_ItemNro, Rendicion_Comision, Rendicion_Total)
Select	Rendicion_Nro
		,Rendicion_Fecha
		,Count(Distinct Nro_Factura) as Cant_Facturas
		,ItemRendicion_nro
		,ItemRendicion_Importe
		,(Select SUM(distinct Factura_Total) from gd_esquema.Maestra as aux where aux.Rendicion_Nro = main.Rendicion_Nro) as Monto_Total
from gd_esquema.Maestra as main
where Rendicion_Nro is not null
group by Rendicion_Nro
		,Rendicion_Fecha
		,ItemRendicion_nro
		,ItemRendicion_Importe

--Carga de Forma de Pago
Insert into PAGO_AGIL.Dim_FormaPago (FormaPago_Desc)
select distinct FormaPagoDescripcion 
from gd_esquema.Maestra
where FormaPagoDescripcion is not null

--Carga de Sucursal
Insert into PAGO_AGIL.Dim_Sucursal (Sucursal_Nombre, Sucursal_Direccion, Sucursal_Codigo_Postal)
select distinct maestra.Sucursal_Nombre
		,maestra.Sucursal_Direcci�n
		,maestra.Sucursal_Codigo_Postal
from gd_esquema.Maestra as maestra
where Sucursal_Nombre is not null

--Carga de Motivo Devolucion
Insert into  PAGO_AGIL.Dim_Motivo_Dev (Motivo_Dev_Desc) 
values	 ('Motivo devolucion inventado 1')

--Carga de Devoluciones
Insert into PAGO_AGIL.Ft_Devolucion(Devolucion_Motivo_Id, Devolucion_Fecha, Devolucion_Resp_Id)
Values (1, GETDATE(), 1)

--Carga de Pago
Insert into PAGO_AGIL.Ft_Pago(	 Pago_Id
								,Pago_Fecha
								,Pago_Item_nro
								,Pago_Total
								,Pago_FormaPago_Id
								,Pago_Sucursal_Id
								,Pago_Resp_Id	)
Select   distinct maestra.Pago_nro
		,maestra.Pago_Fecha
		,maestra.ItemPago_nro
		,maestra.Total
		,(select fp.FormaPago_Id from PAGO_AGIL.Dim_FormaPago as fp where maestra.FormaPagoDescripcion = fp.FormaPago_Desc) as FormaPago_Id
		,(select aux.Sucursal_Id from PAGO_AGIL.Dim_Sucursal as aux where aux.Sucursal_Nombre = maestra.Sucursal_Nombre) as Sucursal_Id
		,NULL as Responsable_Id
from gd_esquema.Maestra as maestra
where maestra.Pago_nro is not null

--Carga de Factura
Insert into PAGO_AGIL.Lk_Factura (Factura_Nro,Factura_Fecha_Alta,Factura_Total,Factura_Fecha_Vencimiento,Factura_Cliente_Id,Factura_Empresa_Id,Factura_Rendicion_Id)
select distinct Nro_Factura,
		Factura_Fecha,
		Factura_Total,
		Factura_Fecha_Vencimiento,
		(select Cliente_Id from PAGO_AGIL.Lk_Cliente as aux where aux.Cliente_Dni = main.[Cliente-Dni]) as cliente_id,
		(select Empresa_Id from PAGO_AGIL.Dim_Empresa as aux where aux.Empresa_Cuit = main.Empresa_Cuit) as empresa_id,
		(select top 1 Rendicion_Nro from gd_esquema.Maestra as aux where aux.Nro_Factura = main.Nro_Factura order by Rendicion_Nro desc) as rendicion
from gd_esquema.Maestra as main

--Carga de Item Factura
Insert into PAGO_AGIL.Lk_Item_Factura (Item_Cantidad,Item_Monto,Item_Factura_Nro)
select distinct ItemFactura_Cantidad,
				ItemFactura_Monto,
				(select Factura_Id from PAGO_AGIL.Lk_Factura as aux where aux.Factura_Nro = main.Nro_Factura) as factura_id
from gd_esquema.Maestra as main

--Carga de Pagos x Factura
Insert into PAGO_AGIL.RL_PagoxFactura (Id_Factura, Id_Pago)
Select distinct fac.Factura_Id, pag.Pago_Id 
from gd_esquema.Maestra as main
inner join PAGO_AGIL.Ft_Pago as pag
	on main.Pago_nro = pag.Pago_Id
inner join PAGO_AGIL.Lk_Factura as fac
	on main.Nro_Factura = fac.Factura_Nro
where main.Pago_nro is not null

Update fac
Set fac.Factura_Pagado = 1
from PAGO_AGIL.Lk_Factura as fac
inner join PAGO_AGIL.RL_PagoxFactura as rl
	on fac.Factura_Id = rl.Id_Factura

--Carga de Usuarios x Sucursal
Insert into PAGO_AGIL.RL_UsuarioxSucursal (Id_Sucursal, Id_usuario)
Select Sucursal_Id, Usuario_Id 
from PAGO_AGIL.Dim_Sucursal, PAGO_AGIL.Lk_Usuario
Go

--Impresion de resumen de migracion
Declare @var_Dim_Rol int = (Select Count(1) from PAGO_AGIL.Dim_Rol)
Declare @var_Dim_Funcionalidad int = (Select Count(1) from PAGO_AGIL.Dim_Funcionalidad)
Declare @var_Rl_RolxFuncionalidad int = (Select Count(1) from PAGO_AGIL.Rl_RolxFuncionalidad)
Declare @var_Lk_Usuario int = (Select Count(1) from PAGO_AGIL.Lk_Usuario)
Declare @var_Rl_RolxUsuario int = (Select Count(1) from PAGO_AGIL.Rl_RolxUsuario)
Declare @var_Lg_Loggin_Incorrecto int = (Select Count(1) from PAGO_AGIL.Lg_Loggin_Incorrecto)
Declare @var_Lk_Cliente int = (Select Count(1) from PAGO_AGIL.Lk_Cliente)
Declare @var_Dim_Rubro int = (Select Count(1) from PAGO_AGIL.Dim_Rubro)
Declare @var_Dim_Empresa int = (Select Count(1) from PAGO_AGIL.Dim_Empresa)
Declare @var_Ft_Rendicion int = (Select Count(1) from PAGO_AGIL.Ft_Rendicion)
Declare @var_Lk_Factura int = (Select Count(1) from PAGO_AGIL.Lk_Factura)
Declare @var_Lk_Item_Factura int = (Select Count(1) from PAGO_AGIL.Lk_Item_Factura)
Declare @var_Dim_FormaPago int = (Select Count(1) from PAGO_AGIL.Dim_FormaPago)
Declare @var_Dim_Sucursal int = (Select Count(1) from PAGO_AGIL.Dim_Sucursal)
Declare @var_Dim_Motivo_Dev int = (Select Count(1) from PAGO_AGIL.Dim_Motivo_Dev)
Declare @var_Ft_Devolucion int = (Select Count(1) from PAGO_AGIL.Ft_Devolucion)
Declare @var_Ft_Pago int = (Select Count(1) from PAGO_AGIL.Ft_Pago)
Declare @var_RL_UsuarioxSucursal int = (Select Count(1) from PAGO_AGIL.RL_UsuarioxSucursal)
Declare @var_RL_PagoxFactura int = (Select Count(1) from PAGO_AGIL.RL_PagoxFactura)
Declare @var_Rl_DevolucioxFactura int = (Select Count(1) from PAGO_AGIL.Rl_DevolucioxFactura)

Print 'Registros insertados en PAGO_AGIL.Dim_Rol: ' + CAST(@var_Dim_Rol AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_Funcionalidad: ' + CAST(@var_Dim_Funcionalidad AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Rl_RolxFuncionalidad: ' + CAST(@var_Rl_RolxFuncionalidad AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Lk_Usuario: ' + CAST(@var_Lk_Usuario AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Rl_RolxUsuario: ' + CAST(@var_Rl_RolxUsuario AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Lg_Loggin_Incorrecto: ' + CAST(@var_Lg_Loggin_Incorrecto AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Lk_Cliente: ' + CAST(@var_Lk_Cliente AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_Rubro: ' + CAST(@var_Dim_Rubro AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_Empresa: ' + CAST(@var_Dim_Empresa AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Ft_Rendicion: ' + CAST(@var_Ft_Rendicion AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Lk_Factura: ' + CAST(@var_Lk_Factura AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Lk_Item_Factura: ' + CAST(@var_Lk_Item_Factura AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_FormaPago: ' + CAST(@var_Dim_FormaPago AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_Sucursal: ' + CAST(@var_Dim_Sucursal AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Dim_Motivo_Dev: ' + CAST(@var_Dim_Motivo_Dev AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Ft_Devolucion: ' + CAST(@var_Ft_Devolucion AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Ft_Pago: ' + CAST(@var_Ft_Pago AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.RL_UsuarioxSucursal: ' + CAST(@var_RL_UsuarioxSucursal AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.RL_PagoxFactura: ' + CAST(@var_RL_PagoxFactura AS VARCHAR)
Print 'Registros insertados en PAGO_AGIL.Rl_DevolucioxFactura: ' + CAST(@var_Rl_DevolucioxFactura AS VARCHAR)
Go

--Creacion de Views
--Creacion de vista con informacion de funcionalidades x usuario
Create View PAGO_AGIL.Vw_User_Info
as
Select	 rol.Rol_Desc Rol
		,fun.Funcionalidad_Desc Funcionalidad
		,usu.Usuario_Name Usuario
from PAGO_AGIL.Dim_Rol rol
inner join PAGO_AGIL.Rl_RolxFuncionalidad rl_fun
	on rol.Rol_Id = rl_fun.Rol_Id
	inner join PAGO_AGIL.Dim_Funcionalidad fun
		on rl_fun.Funcionalidad_Id = fun.Funcionalidad_Id
inner join PAGO_AGIL.Rl_RolxUsuario rl_us
	on rol.Rol_Id = rl_us.Rol_Id
	inner join PAGO_AGIL.Lk_Usuario usu
		on rl_us.Usuario_Id = usu.Usuario_Id
where	rol.Rol_Habilitado = 1
	and usu.Usuario_Habilitado = 1
Go

--Vista con informacion de Empresas
Create view PAGO_AGIL.Vw_Empresa 
As
Select   emp.Empresa_Id
		,emp.Empresa_Nombre
		,emp.Empresa_Cuit
		,emp.Empresa_Direccion
		,rub.Rubro_Descripcion as Rubro
		,case emp.Empresa_Habilitado when 0 then 'Inhabilitado'
		else 'Habilitado' end as Habilitado
from PAGO_AGIL.Dim_Empresa as emp
inner join PAGO_AGIL.Dim_Rubro as rub
	on rub.Rubro_Id = emp.Empresa_Rubro_Id
Go

--Vista con informacion de rendiciones
Create view [PAGO_AGIL].[Vw_Rendidos]
as
Select	 emp.Empresa_Id
		,emp.Empresa_Nombre
		,emp.Empresa_Cuit
		,Convert(char(7), fac.Factura_Fecha_Vencimiento, 126) as Periodo
		,Count(Distinct fac.Factura_Nro) as Cant_Facturas
		,'$' + Cast(Sum(Factura_Total) as varchar) as Total
		,case when fac.Factura_Rendicion_Id is not null then 'Rendida' else 'Sin rendir' end as Rendida
from PAGO_AGIL.Dim_Empresa as emp
inner join PAGO_AGIL.Lk_Factura as fac
	on emp.Empresa_Id = fac.Factura_Empresa_Id
where fac.Factura_Pagado = 1
group by emp.Empresa_Id
		,emp.Empresa_Nombre
		,emp.Empresa_Cuit
		,Convert(char(7), fac.Factura_Fecha_Vencimiento, 126)
		,case when fac.Factura_Rendicion_Id is not null then 'Rendida' else 'Sin rendir' end
--order by emp.Empresa_Id
--		,Periodo

GO

--Creacion de Stored Procedures
--Procedimiento para verificar entrada a sistema
Create Procedure [PAGO_AGIL].[Login] (@user varchar(100), @pass varchar(100))
as
Declare @usuario int = 0
Declare @password int = 0
Declare @habilitado int = 0

Select	@usuario = Usuario_Id,
		@habilitado = Usuario_Habilitado
from PAGO_AGIL.Lk_Usuario 
where	Usuario_Name like @user 

Select @password = 1
from PAGO_AGIL.Lk_Usuario
where	Usuario_Name like @user
	and	Usuario_Password like HASHBYTES('SHA2_256',@pass) 

If @usuario = 0
	Select 'Inexistente' as Resultado
Else If @habilitado = 0
	Select 'Inhabilitado' as Resultado 
Else If @usuario <> 0 and @password = 0 and @habilitado = 1
Begin
	Insert into PAGO_AGIL.Lg_Loggin_Incorrecto (Loggin_Usuario_Id, Loggin_Fecha)
	Select @usuario, Getdate()
	Select 'Invalido' as Resultado

	If 3 = (Select Count(1) from PAGO_AGIL.Lg_Loggin_Incorrecto where Loggin_Usuario_Id = @usuario)
	Begin
		Update PAGO_AGIL.Lk_Usuario
		Set Usuario_Habilitado = 0
		where Usuario_Id = @usuario
	End
End
Else
Begin
	Delete from PAGO_AGIL.Lg_Loggin_Incorrecto where Loggin_Usuario_Id = @usuario
	Select 'Valido' as Resultado
End

Go

-- Registro de Pago, faltan cosas
Create Procedure PAGO_AGIL.Pago  (   @empresa varchar(100)
									,@fecha_pago varchar(10)
									,@cliente varchar(100)
									,@user varchar(100)
									,@fecha_venc varchar(10)
									,@importe int
									,@nro_factura int
									,@sucursal varchar(100)
									,@forma_pago varchar(100))
as

declare @fecha_valida int = 1
declare @empresa_activa int = 0
declare @resultado varchar(100) = ''
declare @factura_existente int = 0
declare @pago_id int
declare @f_ven date
declare @f_pag date
declare @id_factura int

Select @empresa_activa = 1 from PAGO_AGIL.Dim_Empresa as emp
where emp.Empresa_Nombre like @empresa
	and emp.Empresa_Habilitado = 1

if @empresa_activa = 0
begin
	set @resultado = ' Empresa Inactiva'
end

Select @factura_existente = 1, @id_factura = fact.Factura_Id from PAGO_AGIL.Lk_Factura as fact
inner join PAGO_AGIL.Dim_Empresa as emp
	on emp.Empresa_Id = fact.Factura_Empresa_Id
inner join PAGO_AGIL.Lk_Cliente as cli
	on cli.Cliente_Id = fact.Factura_Cliente_Id
where fact.Factura_Nro = @nro_factura
	and emp.Empresa_Nombre like @empresa
	and (cli.Cliente_Nombre + ' ' + cli.Cliente_Apellido) = @cliente

if @factura_existente = 0
begin
	set @resultado = @resultado + ' Factura inexistente'
end

set @f_pag = convert(date, @fecha_pago, 101)
set @f_ven = convert(date, @fecha_venc, 101)

if(@f_ven < @f_pag)
begin
	set @fecha_valida = 0
	set @resultado = @resultado + ' Factura vencida'
end

if(@fecha_valida = 0 or @empresa_activa = 0 or @factura_existente = 0)
begin
	set @resultado = 'Error:' + @resultado 
end

if(@resultado not like 'Error%')
begin
	insert into PAGO_AGIL.RL_PagoxFactura(Id_Factura)
	values(@id_factura)
end

Select @resultado as Resultado
Go

-- Alta Sucursal

Create procedure [PAGO_AGIL].agregar_sucursal (@nombre nvarchar(50),@direccion nvarchar(50),@cp int)
as 

	if exists(select * from PAGO_AGIL.Dim_Sucursal s where s.Sucursal_Codigo_Postal = @cp )
		select -1 -- Ya existe una sucursal con ese CP
	else 
		begin
			insert into PAGO_AGIL.Dim_Sucursal (Sucursal_Nombre,Sucursal_Direccion,Sucursal_Codigo_Postal,Sucursal_Habilitado)
			values (@nombre,@direccion,@cp,1)
			select 1
		end
GO

-- Modificar Sucursal

Create procedure [PAGO_AGIL].modificar_sucursal (@nombreant nvarchar(50),@direccionant nvarchar(50),@cpant int,@nombrenuev nvarchar(50),@direccionnuev nvarchar(50),@cpnuev int,@habilitar bit)
as 	
	declare @actualizarnombre nvarchar(50);	
	declare @actualizardire nvarchar(50);
	declare @actualizarcp int;
	
	set @actualizarnombre = @nombrenuev
	set @actualizardire = @direccionnuev
	set @actualizarcp = @cpnuev
	
	if (@nombrenuev = @nombreant and @direccionnuev = @direccionant and @cpnuev = @cpant)
		begin
			update PAGO_AGIL.Dim_Sucursal
			set Sucursal_Habilitado = @habilitar
			where Sucursal_Codigo_Postal = @cpant and Sucursal_Direccion = @direccionant and Sucursal_Nombre = @nombreant
			return 1
		end
	else
		begin
			if exists(select * from PAGO_AGIL.Dim_Sucursal s where s.Sucursal_Codigo_Postal = @cpnuev) and @cpnuev<>@cpant
				return -1  -- Ya existe una sucursal con ese CP
			else
				begin
					update PAGO_AGIL.Dim_Sucursal
					set Sucursal_Nombre = @actualizarnombre,
					Sucursal_Direccion = @actualizardire,
					Sucursal_Codigo_Postal = @actualizarcp,
					Sucursal_Habilitado = @habilitar
					where Sucursal_Codigo_Postal = @cpant and Sucursal_Direccion = @direccionant and Sucursal_Nombre = @nombreant
					return 1
				end
		end
Go

--Modificar Empresa

Create Procedure PAGO_AGIL.Modificar_Empresa  (@id int
												,@nombre varchar(100)
												,@direccion varchar(100)
												,@cuit varchar(100)
												,@rubro varchar(100)
												,@habilitada bit)
as

declare @cuit_valido int = 1
declare @resultado varchar(100) = 'OK'

Select @cuit_valido = 0 from PAGO_AGIL.Dim_Empresa as emp
where emp.Empresa_Cuit like @cuit and emp.Empresa_Id != @id

if @cuit_valido = 0
begin
	set @resultado = 'Error: CUIT duplicado'
end
else
begin
	update emp
		set  emp.Empresa_Nombre = @nombre
			,emp.Empresa_Cuit = @cuit
			,emp.Empresa_Rubro_Id = rub.Rubro_Id
			,emp.Empresa_Direccion = @direccion
			,emp.Empresa_Habilitado = @habilitada
	    from PAGO_AGIL.Dim_Empresa as emp
		inner join PAGO_AGIL.Dim_Rubro as rub
			on rub.Rubro_Descripcion like @rubro
		where emp.Empresa_Id = @id
end

select @resultado as Resultado

GO

--Dar de Alta Empresa

Create Procedure PAGO_AGIL.Alta_Empresa  (@nombre varchar(100)
											,@direccion varchar(100)
											,@cuit varchar(100)
											,@rubro varchar(100))
as

declare @cuit_valido int = 1
declare @resultado varchar(100) = 'OK'

Select @cuit_valido = 0 from PAGO_AGIL.Dim_Empresa as emp
where emp.Empresa_Cuit like @cuit

if @cuit_valido = 0
begin
	set @resultado = 'Error: CUIT duplicado'
end
else
begin
	insert into PAGO_AGIL.Dim_Empresa (Empresa_Nombre
									  ,Empresa_Cuit
									  ,Empresa_Direccion
									  ,Empresa_Rubro_Id)
	values  (@nombre
			,@cuit
			,@direccion
			,(select rub.Rubro_Id from PAGO_AGIL.Dim_Rubro as rub
				where rub.Rubro_Descripcion like @rubro)
			)
end

Select @resultado as Resultado

GO

--Baja Empresa

Create Procedure PAGO_AGIL.Baja_Empresa  (@id int)
as
	update emp
		set emp.Empresa_Habilitado = 0
	    from PAGO_AGIL.Dim_Empresa as emp
		where emp.Empresa_Id = @id

GO

-- Alta Factura

Create procedure [PAGO_AGIL].alta_factura  (@nro int, @alta varchar(50),@venc varchar(50),@empr nvarchar(100),@clie nvarchar(100))
as
	declare @dtalta datetime
	declare @dtvenc datetime

	set @dtalta = CONVERT(datetime,@alta,103)
	set @dtvenc= CONVERT(datetime,@venc,103)

	if exists(select top 1 * from PAGO_AGIL.Lk_Factura where Factura_Nro= @nro)
		return -1 -- Nro de Factura existente 
	else
		begin
			if (@dtvenc <= @dtalta)
				return -2 -- Fecha vencimiento anterior a la alta
			else
				begin
					declare @clienteID int
					declare @empresaID int
					declare @retorno int

					select @clienteID=Cliente_Id from PAGO_AGIL.Lk_Cliente where (Cliente_Nombre+','+Cliente_Apellido) = @clie
					select @empresaID=Empresa_Id from PAGO_AGIL.Dim_Empresa where Empresa_Nombre = @empr 

					insert into PAGO_AGIL.Lk_Factura(Factura_Nro,Factura_Fecha_Alta,Factura_Fecha_Vencimiento,Factura_Empresa_Id,Factura_Cliente_Id)
					values (@nro,@dtalta,@dtvenc,@empresaID,@clienteID)

					set @retorno = SCOPE_IDENTITY()
					return @retorno -- Exitos
				end
		end
Go

-- Alta Item Factura

create procedure [PAGO_AGIL].alta_item_fact  (@cant int,@monto varchar(50),@idfac int)
as
	declare @montor numeric(18,2)
	set @montor = CONVERT(numeric(18,2),@monto)
	insert into PAGO_AGIL.Lk_Item_Factura(Item_Cantidad,Item_Monto,Item_Factura_Nro) values (@cant,@montor,@idfac)

Go

-- Update monto factura total
create procedure [PAGO_AGIL].calcular_fact_total  (@idfac int)
as
	declare @monto numeric(18,2)
	select @monto = sum(Item_Monto) from PAGO_AGIL.Lk_Item_Factura where Item_Factura_Nro = @idfac
	
	update PAGO_AGIL.Lk_Factura
		set Factura_Total = @monto
		where Factura_Id = @idfac
go

--Baja de un cliente
create procedure PAGO_AGIL.bajaCliente(@dni int) as
begin
	declare @estadoActual int = (select Cliente_Habilitado from PAGO_AGIL.Lk_Cliente where Cliente_Dni = @dni)
	if(@estadoActual = 1)
		begin
			update  PAGO_AGIL.Lk_Cliente 
			set Cliente_Habilitado=0
			where Cliente_Dni = @dni
			select 'El cliente fue deshabilitado correctamente' as Resultado
		end
	else 
		select 'El cliente ya se encuentra deshabilitado' as Resultado
	end

GO
;

-- Ranking porcentaje facturas pagadas por empresa 

create procedure PAGO_AGIL.topPorcentajeFacturasEmpresa(@fechaInicio date, @fechaFin date) as 
	begin
		select distinct top 5
		emp.Empresa_Nombre as Nombre,
		emp.Empresa_Cuit as Cuit,
		rub.Rubro_Descripcion as Descripcion,
		(select
		(select count(1) from PAGO_AGIL.Lk_Factura as factAux 
		inner join PAGO_AGIL.RL_PagoxFactura as pagofactAux on factAux.Factura_Id = pagofactAux.Id_Factura
		inner join PAGO_AGIL.Ft_Pago as pagoAux on pagofactAux.Id_Pago = pagoAux.Pago_Id
		where factAux.Factura_Empresa_Id = emp.Empresa_Id 
		AND factAux.Factura_Fecha_Alta BETWEEN @fechaInicio and @fechaFin
		AND pagoAux.Pago_Fecha between @fechaInicio and @fechaFin) *100 /
		(select count(1) from PAGO_AGIL.Lk_Factura as factAux2 where factAux2.Factura_Empresa_Id=emp.Empresa_Id)) as porcentaje
		from PAGO_AGIL.Lk_Factura as fact 
		inner join PAGO_AGIL.Dim_Empresa as emp on fact.Factura_Empresa_Id=emp.Empresa_Id
		inner join PAGO_AGIL.Dim_Rubro as rub on emp.Empresa_Rubro_Id = rub.Rubro_Id
	end
go

-- Ranking monto rendido

create procedure PAGO_AGIL.topMontoRendido (@fechaInicio date, @fechaFin date) as
	begin
		select top 5
		emp.Empresa_Nombre as Empresa_Nombre,
		rubro.Rubro_Descripcion as rubro,
		sum(factura_total) as monto_rendido
		from PAGO_AGIL.Lk_Factura as fact
		inner join PAGO_AGIL.Dim_Empresa as emp on fact.Factura_Empresa_Id = emp.Empresa_Id
		inner join PAGO_AGIL.Dim_Rubro as rubro on rubro.Rubro_Id = emp.Empresa_Rubro_Id
		where convert(date, fact.Factura_Fecha_Alta) between @fechaInicio and @fechaFin
		group by emp.Empresa_Nombre, Factura_Empresa_Id, rubro.Rubro_Descripcion
	end
go
;

--Ranking porcentaje de pago
create procedure PAGO_AGIL.topPorcentajePago(@fechaInicio date, @fechaFin date) as 
	begin
		select distinct top 5
		clie.Cliente_Dni as Dni_Cliente,
		clie.Cliente_Apellido as ApellidoCliente,
		clie.Cliente_Nombre as NombreCliente,
		(select count(1) from PAGO_AGIL.Lk_Factura as factAux 
			inner join PAGO_AGIL.RL_PagoxFactura as pagofactAux on factAux.Factura_Id=pagofactAux.Id_Factura
			inner join PAGO_AGIL.Ft_Pago as pagoAux on pagofactAux.Id_Pago = pagoAux.Pago_Id
		where factAux.Factura_Cliente_Id = clie.Cliente_Id 	AND factAux.Factura_Pagado=1 AND 
		factAux.Factura_Fecha_Alta between @fechaInicio and @fechaFin and pagoAux.Pago_Fecha between @fechaInicio and @fechaFin) *100 /
		(select count(1) from PAGO_AGIL.Lk_Factura as factAux2 where factAux2.Factura_Cliente_Id = clie.Cliente_Id ) as porcentaje
		from PAGO_AGIL.Lk_Factura as fact
		inner join PAGO_AGIL.Lk_Cliente as clie on fact.Factura_Cliente_Id = clie.Cliente_Id
		order by porcentaje desc
	;
	end
go
;

-- Ranking cantidad de pagos
create procedure PAGO_AGIL.topCantidadPagos(@fechaInicio date, @fechaFin date) as
	begin
		SELECT top 5
		CLIE.Cliente_Nombre as Cliente_Nombre,
		CLIE.Cliente_Apellido as Cliente_Apellido,
		CLIE.Cliente_Dni as Cliente_Dni,
		(select count(1) from PAGO_AGIL.Lk_Factura as aux_fact WHERE aux_fact.Factura_Cliente_Id=CLIE.Cliente_Id
		AND aux_fact.Factura_Pagado=1) as cantidad_pagos
		from PAGO_AGIL.Lk_Factura FACT
		inner join PAGO_AGIL.RL_PagoxFactura as PAGOF on (PAGOF.id_factura = FACT.Factura_Id AND PAGOF.Id_Pago is not null)
		inner join PAGO_AGIL.Lk_Cliente as CLIE on FACT.Factura_Cliente_Id = CLIE.Cliente_Id
		inner join PAGO_AGIL.Ft_Pago as PAGO on PAGOF.Id_Pago = PAGO.Pago_Id
		where convert(date,PAGO.Pago_Fecha) between @fechaInicio and @fechaFin
		order by cantidad_pagos desc
	end
go

--Creacion de nuevo cliente

create procedure PAGO_AGIL.nuevoCliente(@DNI int, @apellido nvarchar(255), @nombre nvarchar(255), 
@telefono nvarchar(255), @fechaNac datetime, @mail nvarchar(255), @direccion nvarchar(255), @codigoPostal nvarchar(255), @habilitado int) as
	begin
		insert into PAGO_AGIL.Lk_Cliente(Cliente_Dni, Cliente_Apellido, Cliente_Nombre, Cliente_Telefono, Cliente_Fecha_Nac, 
		Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, Cliente_Habilitado) 
		values (@DNI, @apellido, @nombre, @telefono, @fechaNac, @mail, @direccion, @codigoPostal, @habilitado)
		select 'Insertado correctamente' as Resultado
	end
	GO
;

-- Modificacion de cliente
create procedure PAGO_AGIL.modificaCliente(@dni_buscado int, @DNI int, @apellido nvarchar(255), @nombre nvarchar(255), 
@telefono nvarchar(255), @fechaNac datetime, @mail nvarchar(255), @direccion nvarchar(255), 
@codigoPostal nvarchar(255), @habilitado int) as
	begin
		if @DNI is not null 
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Dni = @DNI
				where Cliente_Dni =@dni_buscado
			end
		if @apellido !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Apellido = @apellido
				where Cliente_Dni =@dni_buscado
			end
		if @nombre !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Nombre = @nombre
				where Cliente_Dni =@dni_buscado
			end
		if @telefono !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Telefono = @telefono
				where Cliente_Dni =@dni_buscado
			end
		if @fechaNac !='' 
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Fecha_Nac = @fechaNac
				where Cliente_Dni =@dni_buscado
			end
		if @mail !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Mail = @mail
				where Cliente_Dni =@dni_buscado
			end
		if @direccion !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Direccion = @direccion
				where Cliente_Dni =@dni_buscado
			end
		if @codigoPostal !=''
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Codigo_Postal = @codigoPostal
				where Cliente_Dni =@dni_buscado
			end
		if @habilitado is not null 
			begin
				update PAGO_AGIL.Lk_Cliente 
				set Cliente_Habilitado = @habilitado
				where Cliente_Dni =@dni_buscado
			end
		select 'Cliente modificado con exito'
	end
go
;

--Alta Rol 
Create Procedure PAGO_AGIL.Rol_Funcionalidad(@id_funcionalidad int)
as

Insert into PAGO_AGIL.Rl_RolxFuncionalidad(Funcionalidad_Id)
values (@id_funcionalidad)

GO

Create Procedure PAGO_AGIL.Alta_Rol(@nombre varchar(100))
as

Insert into PAGO_AGIL.Dim_Rol(Rol_Desc)
values (@nombre)

update rf
	set rf.Rol_Id = rol.Rol_Id
from PAGO_AGIL.Rl_RolxFuncionalidad as rf
	inner join PAGO_AGIL.Dim_Rol as rol
	on rol.Rol_Desc like @nombre
where rf.Rol_id is null

GO

--Baja Rol

Create Procedure PAGO_AGIL.Baja_Rol (@id_rol int)
as
Update rol
	set rol.Rol_Habilitado = 0 from PAGO_AGIL.Dim_Rol as rol 
	where rol.Rol_Id = @id_rol

Delete from PAGO_AGIL.Rl_RolxUsuario 
where Rol_Id = @id_rol

GO

--Modificacion Rol
Create Procedure PAGO_AGIL.Rol_Funcionalidad_Modif ( @id_funcionalidad int
													,@id_rol int
													,@checkeado int)
as

declare @relacion_existente int = 0

Select @relacion_existente = 1 from PAGO_AGIL.Rl_RolxFuncionalidad as rf
where rf.Funcionalidad_Id = @id_funcionalidad 
	and rf.Rol_Id = @id_rol
	
if @relacion_existente = 1
begin
	if @checkeado = 0
	begin
		delete from  PAGO_AGIL.Rl_RolxFuncionalidad 
		where Funcionalidad_Id = @id_funcionalidad 
		and Rol_Id = @id_rol
	end
	else
	begin
		insert into PAGO_AGIL.Rl_RolxFuncionalidad (Funcionalidad_Id, Rol_Id)
		values (@id_funcionalidad, @id_rol)
	end	
end 
else
begin 
	if @checkeado = 1
	begin
		insert into PAGO_AGIL.Rl_RolxFuncionalidad (Funcionalidad_Id, Rol_Id)
		values (@id_funcionalidad, @id_rol)
	end
end

GO

Create Procedure PAGO_AGIL.Mod_Rol(@id_rol int, @nombre varchar(100), @habilitado bit)
as

Update rol
	set rol.Rol_Desc = @nombre,
		rol.Rol_Habilitado = @habilitado
	from PAGO_AGIL.Dim_Rol as rol
	where rol.Rol_Id = @id_rol

GO

--Alta Registro Pago
Create Procedure PAGO_AGIL.FacturaPaga (@id_factura int)
as
	insert into PAGO_AGIL.RL_PagoxFactura(Id_Factura)
	values(@id_factura)
GO

Create Procedure PAGO_AGIL.RegistrarPago( @fecha varchar(20)
										, @total int
										, @forma_pago varchar(100)
										, @sucursal varchar(100)
										, @user varchar(100))
as

declare @pago_id int
declare @f_pag date = convert(date, @fecha, 101)
	
select @pago_id = count(1) - 1 from PAGO_AGIL.Ft_Pago
insert into PAGO_AGIL.Ft_Pago(	Pago_Id
								,Pago_Fecha
								,Pago_Item_nro
								,Pago_Total
								,Pago_FormaPago_Id
								,Pago_Sucursal_Id
								,Pago_Resp_Id)
	values  (@pago_id
			,@f_pag
			,null
			,@total
			,(select form.FormaPago_Id from PAGO_AGIL.Dim_FormaPago as form
				where form.FormaPago_Desc like @forma_pago)
			,(select suc.Sucursal_Id from PAGO_AGIL.Dim_Sucursal as suc
				where suc.Sucursal_Nombre like @sucursal)
			,(select us.Usuario_Id from PAGO_AGIL.Lk_Usuario as us
				where us.Usuario_Name like @user)
			) 