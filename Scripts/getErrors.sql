SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('getErrors', 'P') IS NOT NULL
	DROP PROC getErrors
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE getErrors
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT id_error,paso_uno,paso_dos,paso_tres,descripcion FROM Error
END
go


GRANT EXECUTE ON getErrors TO steren;
GO

