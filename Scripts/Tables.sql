

IF (OBJECT_ID('dbo.FK_ASIGNADO_A', 'F') IS NOT NULL)
	ALTER TABLE Ticket DROP CONSTRAINT FK_ASIGNADO_A;
GO
IF (OBJECT_ID('dbo.FK_ID_ERROR', 'F') IS NOT NULL)
	ALTER TABLE Ticket DROP CONSTRAINT FK_ID_ERROR;
GO
IF (OBJECT_ID('dbo.FK_ID_DEPARTAMENTO', 'F') IS NOT NULL)
	ALTER TABLE Ticket DROP CONSTRAINT FK_ID_DEPARTAMENTO;
GO

IF OBJECT_ID (N'Ticket', N'U') IS NOT NULL
	DROP TABLE Ticket;
GO

IF OBJECT_ID (N'Empleado', N'U') IS NOT NULL
	DROP TABLE Empleado;
GO

IF OBJECT_ID (N'Departamento', N'U') IS NOT NULL
	DROP TABLE Departamento;
GO
IF OBJECT_ID (N'Error', N'U') IS NOT NULL
	DROP TABLE Error;
GO

CREATE TABLE  Empleado(
id_empleado INT PRIMARY KEY IDENTITY,
nombre NVARCHAR(100),
usuario NVARCHAR(100),
password varbinary (100) NOT NULL,
email NVARCHAR(100),
telefono NVARCHAR(10)
)

CREATE TABLE Departamento(
id_departamento INT PRIMARY KEY IDENTITY,
nombre NVARCHAR(100),
descripcion NVARCHAR(100),
area NVARCHAR(50),
)



CREATE TABLE Error(
id_error INT PRIMARY KEY IDENTITY,
paso_uno NVARCHAR(200),
paso_dos NVARCHAR(200),
paso_tres NVARCHAR(200),
descripcion NVARCHAR(50),
)

CREATE TABLE Ticket(
id_ticket INT PRIMARY KEY IDENTITY,
asignado_a INT,
comentarios NVARCHAR(500),
fecha_asignacion DATETIME,
fecha_cierre DATETIME,
creado_por NVARCHAR(50),
id_departamento INT,
status tinyint,
id_error INT

)
ALTER TABLE Ticket ADD CONSTRAINT FK_ASIGNADO_A FOREIGN KEY (asignado_a) REFERENCES Empleado(id_empleado);
GO
ALTER TABLE Ticket ADD CONSTRAINT FK_ID_ERROR FOREIGN KEY (id_error) REFERENCES Error(id_error);
GO
ALTER TABLE Ticket ADD CONSTRAINT FK_ID_DEPARTAMENTO FOREIGN KEY (id_departamento) REFERENCES Departamento(id_departamento);
GO
INSERT [dbo].[Empleado] ([nombre], [usuario], [password], [email], [telefono]) VALUES ( N'Carlos Vazquez Ricardez', N'cvr', ENCRYPTBYPASSPHRASE('ZGVwZXBzYVNob3BpZnkyMDIzLg==', '123456'), N'rricardez@live.com.ar', N'2712394873')
GO
INSERT [dbo].[Empleado] ([nombre], [usuario], [password], [email], [telefono]) VALUES ( N'Juan Carlos Bodoque', N'jbd',ENCRYPTBYPASSPHRASE('ZGVwZXBzYVNob3BpZnkyMDIzLg==', '123456'), N'bodoque@live.com.ar', N'2712394873')
GO
INSERT [dbo].[Empleado] ([nombre], [usuario], [password], [email], [telefono]) VALUES ( N'Calcetin con Rombolsman', N'car',ENCRYPTBYPASSPHRASE('ZGVwZXBzYVNob3BpZnkyMDIzLg==', '123456'), N'rombosman@live.com.ar', N'2712394873')
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Departamento] ON 

GO
INSERT [dbo].[Departamento] ([id_departamento], [nombre], [descripcion], [area]) VALUES (1, N'RRHH', N'Departamento de Recursos humanos', N'Nomina')
GO
INSERT [dbo].[Departamento] ([id_departamento], [nombre], [descripcion], [area]) VALUES (2, N'RRHH', N'Departamento de Recursos humanos', N'Reclutamiento')
GO
INSERT [dbo].[Departamento] ([id_departamento], [nombre], [descripcion], [area]) VALUES (3, N'Compras', N'Departamento de compras', N'Insumos')
GO
INSERT [dbo].[Departamento] ([id_departamento], [nombre], [descripcion], [area]) VALUES (4, N'Compras', N'Departamento de compras', N'Cotizacione')
GO
SET IDENTITY_INSERT [dbo].[Departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Error] ON 

GO
INSERT [dbo].[Error] ([id_error], [paso_uno], [paso_dos], [paso_tres], [descripcion]) VALUES (1, N'1', N'1', N'1', N'Error en compras')
GO
INSERT [dbo].[Error] ([id_error], [paso_uno], [paso_dos], [paso_tres], [descripcion]) VALUES (2, N'1', N'0', N'1', N'Error capa 8')
GO
SET IDENTITY_INSERT [dbo].[Error] OFF
GO
