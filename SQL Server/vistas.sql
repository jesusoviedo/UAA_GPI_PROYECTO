use Proyecto_GPI_GOLF;
go

--creo una vista para generar la contraseña
CREATE VIEW VW_Random
AS
    SELECT ROUND(((999999 - 100000) * RAND() + 100000), 0) as Round
    --SELECT ROUND(((limiteMayor - limiteMenor) * RAND() + limiteMenor), espaciosDecimales)
GO 

--creo una vista para generar la contraseña
create VIEW VW_Random2
AS
    SELECT ROUND(((999 - 100) * RAND() + 100), 0) as Round
    --SELECT ROUND(((limiteMayor - limiteMenor) * RAND() + limiteMenor), espaciosDecimales)
GO 