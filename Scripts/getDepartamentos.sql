SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('getDepartamentos', 'P') IS NOT NULL
	DROP PROC getDepartamentos
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE getDepartamentos
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT id_departamento, nombre, descripcion, area
FROM            Departamento
END
go


GRANT EXECUTE ON getDepartamentos TO steren;
GO

