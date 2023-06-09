

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
id_error INT

)
ALTER TABLE Ticket ADD CONSTRAINT FK_ASIGNADO_A FOREIGN KEY (asignado_a) REFERENCES Empleado(id_empleado);
GO
ALTER TABLE Ticket ADD CONSTRAINT FK_ID_ERROR FOREIGN KEY (id_error) REFERENCES Error(id_error);
GO
ALTER TABLE Ticket ADD CONSTRAINT FK_ID_DEPARTAMENTO FOREIGN KEY (id_departamento) REFERENCES Departamento(id_departamento);
GO

INSERT INTO Empleado
	(nombre,email,password,telefono,usuario )
values('Carlos Vazquez Ricardez', 'rricardez@live.com.ar',  ENCRYPTBYPASSPHRASE('ZGVwZXBzYVNob3BpZnkyMDIzLg==', '123456'), '2712394873','cvr');
