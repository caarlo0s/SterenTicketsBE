SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('getLogin', 'P') IS NOT NULL
	DROP PROC getLogin
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE getLogin
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
	@usuario  varchar(50),
	@password  varchar(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE 
	@keyPassword varchar(50),
	@date datetime,
	@iuser int
    SET @keyPassword =  'ZGVwZXBzYVNob3BpZnkyMDIzLg=='
	SET @iuser=(SELECT id_empleado FROM Empleado WHERE usuario= @usuario 
				AND convert(varchar(100), DECRYPTBYPASSPHRASE(@keyPassword,password)) = @password)
	IF (@iuser!=0)
	BEGIN 
		

		SELECT id_empleado, nombre, usuario
			FROM Empleado
			WHERE usuario = @usuario
			AND convert(varchar(100), DECRYPTBYPASSPHRASE(@keyPassword,password)) = @password

				
	END
	ELSE
	BEGIN
	print 'Errror'
	END
END
go


GRANT EXECUTE ON getLogin TO steren;
GO

