SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('AllotTicket', 'P') IS NOT NULL
	DROP PROC AllotTicket
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE AllotTicket
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
	@id_ticket INT,
	@asignado_a INT


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	
	UPDATE Ticket set
	asignado_a=@asignado_a,
	fecha_asignacion=GETDATE(),
	status=1
	WHERE id_ticket=@id_ticket

END
go


GRANT EXECUTE ON AllotTicket TO steren;
GO

