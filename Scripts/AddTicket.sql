SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('AddTicket', 'P') IS NOT NULL
	DROP PROC AddTicket
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE AddTicket
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
	@comentarios NVARCHAR(200),
	@id_departamento INT,
	@id_error INT,
	@creado_por NVARCHAR(200)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT [dbo].[Ticket] ( [comentarios], [creado_por], [id_departamento], [status], [id_error])
                VALUES (@comentarios,@creado_por,@id_departamento,0,@id_error)

 SELECT top 1 id_ticket FROM Ticket order by id_ticket desc
END
go


GRANT EXECUTE ON AddTicket TO steren;
GO

