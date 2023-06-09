
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('GetTicketsByDepart', 'P') IS NOT NULL
	DROP PROC GetTicketsByDepart
GO
-- =============================================
-- Author:		Carlos Vazquez
-- Create date: 08/06/2023
-- Description:	StorePRocedure for Insert,Update and Delete Users
-- =============================================
CREATE PROCEDURE GetTicketsByDepart
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
	@id_departamento INT


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
-- SELECT     Ticket.id_ticket, Ticket.comentarios, Ticket.fecha_asignacion, Ticket.fecha_cierre, Ticket.creado_por, Ticket.status, Departamento.descripcion + '-' + Departamento.area AS departamento, Error.descripcion AS error, 
--                          Empleado.nombre
-- FROM            Ticket INNER JOIN
--                          Error ON Ticket.id_error = Error.id_error INNER JOIN
--                          Departamento ON Ticket.id_departamento = Departamento.id_departamento INNER JOIN
--                          Empleado ON Ticket.asignado_a = Empleado.id_empleado
-- 						 WHERE        (Ticket.status = @status)

SELECT        Ticket.id_ticket, Ticket.comentarios, Ticket.fecha_asignacion, Ticket.fecha_cierre, Ticket.creado_por,Ticket.status,  Departamento.nombre + '-' + Departamento.area AS departamento, 
                         Error.descripcion AS error , Empleado.nombre
FROM            Ticket INNER JOIN
                         Departamento ON Ticket.id_departamento = Departamento.id_departamento INNER JOIN
                         Error ON Ticket.id_error = Error.id_error LEFT OUTER JOIN
                         Empleado ON Ticket.asignado_a = Empleado.id_empleado
WHERE        (Ticket.id_departamento = @id_departamento) 
END
go


GRANT EXECUTE ON GetTicketsByDepart TO steren;
GO

