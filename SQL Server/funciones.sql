use Proyecto_GPI_GOLF;
go

--funcion para encriptar contraseña
create FUNCTION fu_encriptar_contrasenia(@clave VARCHAR(50))
RETURNS VarBinary(8000)
AS
BEGIN
    DECLARE @pass AS VarBinary(8000)
    SET @pass = HASHBYTES('MD5', @clave);
    RETURN @pass
END;
go

create FUNCTION fu_verificar_permiso(@v_usuario varchar(50),@v_facultad int )
RETURNS varchar(1)
AS
BEGIN
    DECLARE @v_permiso AS varchar(1)

    SET @v_permiso = 'N'
    
	if exists (select * from UsuarioFacultad ua 
			   where upper(ua.CodUsuario)=upper(@v_usuario) 
			   and upper(ua.CodFacultad)=upper(@v_facultad) 
			   and ua.Estado='A')
	begin
		SET @v_permiso = 'S'
	end
		
	RETURN @v_permiso
END;
go





