USE GD2C2017
Go

--Borrado de Stored Procedures
IF OBJECT_ID('PAGO_AGIL.Login') IS NOT NULL
	DROP PROCEDURE PAGO_AGIL.Login;
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
	Factura_Rendicion_Id int FOREIGN KEY REFERENCES PAGO_AGIL.Ft_Rendicion(Rendicion_Id)
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
Create view PAGO_AGIL.Vw_Rendidos
as
Select	 emp.Empresa_Id
		,emp.Empresa_Nombre
		,emp.Empresa_Cuit
		,Convert(char(7), fac.Factura_Fecha_Vencimiento, 126) as Periodo
		,Count(Distinct fac.Factura_Nro) as Cant_Facturas
		,'$' + Cast(Sum(Factura_Total) as varchar) as Total
		,(Select TOP 1 Case aux_ren.Rendicion_Id when null then 'Sin rendir' else 'Rendida' END
			from PAGO_AGIL.Ft_Rendicion as aux_ren
			inner join PAGO_AGIL.Lk_Factura as aux_fac
				on aux_ren.Rendicion_Id = aux_fac.Factura_Rendicion_Id	
			where Convert(char(7), fac.Factura_Fecha_Vencimiento, 126) = Convert(char(7), fac.Factura_Fecha_Vencimiento, 126)	) as Rendida
from PAGO_AGIL.Dim_Empresa as emp
inner join PAGO_AGIL.Lk_Factura as fac
	on emp.Empresa_Id = fac.Factura_Empresa_Id
	inner join PAGO_AGIL.RL_PagoxFactura as pag
		on fac.Factura_Id = pag.Id_Factura
group by emp.Empresa_Id
		,emp.Empresa_Nombre
		,emp.Empresa_Cuit
		,Convert(char(7), fac.Factura_Fecha_Vencimiento, 126)
--order by emp.Empresa_Id
--		,Periodo
Go

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