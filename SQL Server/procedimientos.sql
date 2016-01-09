use Proyecto_GPI_GOLF;
go

---procedimiento que valida la sesion del usuario
create Procedure proInicioSesion(@v_usuario varchar(25),@v_clave varchar(15),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='I' and (len(@v_usuario)=0 and len(@v_clave)=0)
		Begin
			Select @vMsgError ='Debe ingresar su usuario y contraseña';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' and (len(@v_usuario)=0 and len(@v_clave)>0)
		Begin
			Select @vMsgError ='Debe ingresar su usuario';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' and (len(@v_usuario)>0 and len(@v_clave)=0)
		Begin
			Select @vMsgError ='Debe ingresar su contraseña';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if len(@v_usuario)>0 and len(@v_clave)>0
		Begin
			if @v_TipoEvento ='I' and 
		    not exists (select * from Usuario u where u.CodUsuario=@v_usuario and u.Estado in ('A','I','B'))
			Begin
				Select @vMsgError ='Usuario no registrado';
				Raiserror (@vMsgError, 16, 1);
				Select @vNroError =1;
			end

			if @v_TipoEvento ='I' and 
			exists (select * from Usuario u where u.CodUsuario=@v_usuario and u.Estado in ('B'))
			Begin
				Select @vMsgError ='Usuario Bloqueado';
				Raiserror (@vMsgError, 16, 1);
				Select @vNroError =1;
			end

			if @v_TipoEvento ='I' and 
			exists (select * from Usuario u where u.CodUsuario=@v_usuario and u.Estado in ('I'))
			Begin
				Select @vMsgError ='Usuario Inactivo';
				Raiserror (@vMsgError, 16, 1);
				Select @vNroError =1;
			end
		
			if @v_TipoEvento ='I' and 
			exists (select * from Usuario u where u.CodUsuario=@v_usuario and dbo.fu_encriptar_contrasenia(@v_clave)!= u.Clave and u.Estado in ('A'))
			Begin
				update Usuario
				set CantidadIntento = (CantidadIntento + 1), FechaUltimoIntento = getDate()
				where CodUsuario=@v_usuario;

				if (select u.CantidadIntento from Usuario u where u.CodUsuario=@v_usuario) >= 5
				Begin
					update Usuario
					set Estado = 'B'
					where CodUsuario=@v_usuario;
				end
				Commit Transaction

				Select @vMsgError ='Contraseña incorrecta';
				Raiserror (@vMsgError, 16, 1);
				Select @vNroError =1;
			end
			--borra la cantidad de intentos si tiene ya cargado
			update Usuario
					set CantidadIntento = 0
					where CodUsuario=@v_usuario;
		end
		Commit Transaction --al final del bloque
		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para recuperar una contraseña para un usuario ya registrado
create Procedure proRecuperarClave(@v_correo varchar(200),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int, @v_usuario varchar;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='R' and 
		not exists (select * from Usuario u inner join Persona p on p.CodUsuario=u.CodUsuario and p.CorreoElectronico=@v_correo)
		Begin
			Select @vMsgError ='Correo electrónico no registrado';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='R' and 
		exists (select * from Usuario u inner join Persona p on p.CodUsuario=u.CodUsuario and p.CorreoElectronico=@v_correo and u.Estado='I')
		Begin
			Select @vMsgError ='Usuario inactivo';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='R' and 
		exists (select * from Usuario u inner join Persona p on p.CodUsuario=u.CodUsuario and p.CorreoElectronico=@v_correo)
		Begin
		    
			select @v_usuario=u.CodUsuario from Usuario u inner join Persona p on p.CodUsuario=u.CodUsuario and u.Estado='B' and p.CorreoElectronico=@v_correo;
			
			update Usuario
			set Estado='A', CantidadIntento=0
			where CodUsuario= (select u.CodUsuario from Usuario u inner join Persona p on p.CodUsuario=u.CodUsuario and u.Estado='B' and p.CorreoElectronico=@v_correo);

			select u.CodUsuario as CodUsuario, dbo.fu_desencriptar_contrasenia(u.Clave) as Clave
			from Usuario u 
			inner join Persona p
			on  p.CodUsuario=u.CodUsuario and p.CorreoElectronico=@v_correo;
		end
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para cambiar una contraseña de un usuario
create Procedure proCambiarClave(@v_usuario varchar(25),@v_clave_actual varchar(15),@v_clave_nueva varchar(15),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and (len(@v_clave_actual)=0 and len(@v_clave_nueva)=0)
		Begin
			Select @vMsgError ='Debe ingresar la Contraseña actual y nueva';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and (len(@v_clave_actual)=0 and len(@v_clave_nueva)>0)
		Begin
			Select @vMsgError ='Debe ingresar la Contraseña actual';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and (len(@v_clave_actual)>0 and len(@v_clave_nueva)=0)
		Begin
			Select @vMsgError ='Debe ingresar la Contraseña nueva ';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and 
		not exists (select * from Usuario u where u.CodUsuario=@v_usuario and dbo.fu_desencriptar_contrasenia(u.Clave)=@v_clave_actual)
		Begin
			Select @vMsgError ='La Contraseña actual ingresada es incorrecta';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and len(@v_clave_nueva) !=6 --and ISNUMERIC(@v_clave_nueva)=0
		Begin
			Select @vMsgError ='La Contraseña nueva ingresada debe tener 6 digitos';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and @v_clave_actual=@v_clave_nueva
		Begin
			Select @vMsgError ='La Contraseña nueva ingresada debe ser diferente a la actual ';
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and len(@v_clave_nueva)=6 and
		exists (select * from Usuario u where u.CodUsuario=@v_usuario and dbo.fu_desencriptar_contrasenia(u.Clave)=@v_clave_actual)
		Begin
			update Usuario
			set Clave = dbo.fu_encriptar_contrasenia(@v_clave_nueva)
			where CodUsuario=@v_usuario
		end
		
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para validar permisos por pantalla para un usuario
create Procedure proPermisoPantalla(@v_usuario varchar(25),@v_pantalla varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='P' and not exists (select * from UsuarioPantalla p where p.CodUsuario=@v_usuario and upper(p.CodPantalla)=upper(@v_pantalla) and p.Estado='A')
		Begin
			Select @vMsgError ='El usuario no tiene permiso a la pantalla: ' + upper(@v_pantalla) ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end		
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar las pantallas a las que un usuario tiene permiso
create Procedure proConsultarPermisoPantalla(@v_usuario varchar(25),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Usuario p where p.CodUsuario=@v_usuario)
		Begin
			Select @vMsgError ='Usuario no registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='C' and not exists (select * from UsuarioPantalla p 
		inner join Usuario u on p.CodUsuario=u.CodUsuario where p.CodUsuario=@v_usuario and p.Estado='A')
		Begin
			Select @vMsgError ='El usuario no tiene permiso a ninguna pantalla' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end		

		if @v_TipoEvento ='C' and exists (select * from UsuarioPantalla p 
		inner join Usuario u on p.CodUsuario=u.CodUsuario where p.CodUsuario=@v_usuario and p.Estado='A')
		Begin
			select UPPER(p.CodPantalla) as Pantalla from UsuarioPantalla p where p.CodUsuario=@v_usuario and p.Estado='A'
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para actualizar las pantallas a las que un usuario tiene permiso o no
create Procedure proActualizarPermisoPantalla(@v_usuario varchar(25),@v_pantalla varchar(50),@v_estado char(1),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='A' and not exists (select * from Usuario p where p.CodUsuario=@v_usuario)
		Begin
			Select @vMsgError ='Usuario no registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end		

		if @v_TipoEvento ='A' and not exists (select * from UsuarioPantalla p 
		inner join Usuario u on p.CodUsuario=u.CodUsuario where p.CodUsuario=@v_usuario and upper(p.CodPantalla)=upper(@v_pantalla) and p.Estado in ('I','A'))
		Begin
			insert into UsuarioPantalla values (@v_usuario,upper(@v_pantalla),@v_estado,null,null,null,null);
		end	

		if @v_TipoEvento ='A' and exists (select * from UsuarioPantalla p 
		inner join Usuario u on p.CodUsuario=u.CodUsuario where p.CodUsuario=@v_usuario and upper(p.CodPantalla)=upper(@v_pantalla) and p.Estado!=@v_estado)
		Begin
			update UsuarioPantalla 
			set Estado=@v_estado
			where CodUsuario=@v_usuario
			and upper(CodPantalla)=upper(@v_pantalla);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que devuelve Pais,Tipo Documento y Tipo de Persona
create Procedure proDevolverDatos(@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction
	
		if @v_TipoEvento ='P'
		Begin
			select upper(p.Descripcion) as Pais from Pais p order by p.Descripcion asc;
		end	
		
		if @v_TipoEvento ='D'
		Begin
			select upper(td.Descripcion) as TipoDocumento from TipoDocumento td order by td.Descripcion asc;
		end	

		if @v_TipoEvento ='T'
		Begin
			select upper(tp.Descripcion) as TipoPersona from TipoPersona tp order by tp.Descripcion asc;
		end	

		if @v_TipoEvento ='F'
		Begin
			select upper(f.NombreFacultad) as facultad from Facultad f order by f.NombreFacultad asc;
		end	

		if @v_TipoEvento ='L'
		Begin
			select upper(l.NombreTipo) as tipolibro from TipoLibro l order by l.NombreTipo asc;
		end	

		if @v_TipoEvento ='E'
		Begin
			select distinct(upper(e.NombreEditorial)) as editorial from Editorial e where e.Estado='A';
		end	

		if @v_TipoEvento ='I'
		Begin
			select upper(i.NombreIdioma) as idioma from Idioma i order by i.NombreIdioma asc;
		end	

		if @v_TipoEvento ='M'
		Begin
			select upper(m.NombreMateria) as materia from Materia m  where m.Estado='A' order by m.NombreMateria asc ;
		end

		if @v_TipoEvento ='S'
		Begin
			select upper(s.Descripcion) as semestre from Semestre s order by s.Descripcion asc ;
		end

		if @v_TipoEvento ='N'
		Begin
			select upper(l.ISBN) as isbn from Libro L where l.Estado='A' order by l.ISBN asc ;
		end

		if @v_TipoEvento ='G'
		Begin
			select upper(tb.Descripcion) as tipobibliografia from TipoBibliografia tb order by Descripcion asc ;
		end

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para agregar una nueva Persona
create Procedure proAgregarPersona(
@v_documento varchar(50),
@v_DcodTipoDocumento varchar(50),
@v_DcodTipoPersona varchar(50),
@v_nombre varchar(50),
@v_apellido varchar(50),
@v_fechaNacimiento date,
@v_DcodPaisNacimiento varchar(50),
@v_direccion varchar(100),
@v_telefono varchar(20),
@v_correoElectronico varchar(200),
@v_usuarioI varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPaisNacimiento int,@v_codTipoDocumento int,@v_estado char(1),@v_codUsuario varchar(50),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_codTipoDocumento = (select td.CodTipoDocumento from TipoDocumento td where upper(td.Descripcion)=upper(@v_DcodTipoDocumento));
			set @v_codPaisNacimiento = (select p.CodPais from Pais p where upper(p.Descripcion)=upper(@v_DcodPaisNacimiento));
			set @v_codTipoPersona = (select tp.CodTipoPersona from TipoPersona tp where upper(tp.Descripcion)=upper(@v_DcodTipoPersona));
			set @v_codUsuario=((select td.Abreviatura from TipoDocumento td where td.CodTipoDocumento=@v_codTipoDocumento) + @v_documento);

		if @v_TipoEvento ='I' and exists (select * from Persona p where upper(p.CorreoElectronico)=upper(@v_correoElectronico))
		Begin
			Select @vMsgError ='El correo electrónico ya esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
		Begin
			Select @vMsgError ='El documento y tipo de documento pertenece a una Persona ya registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and not exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento and
		upper(p.CorreoElectronico)=upper(@v_correoElectronico))
		Begin
			insert into Usuario values (@v_codUsuario,dbo.fu_encriptar_contrasenia(@v_codUsuario),'A',0,null,@v_usuarioI,GETDATE(),null,	null);

			insert into Persona values  (
			@v_documento,
			@v_codTipoDocumento,
			@v_codTipoPersona,
			@v_nombre,
			@v_apellido,
			@v_fechaNacimiento,
			@v_codPaisNacimiento,
			@v_direccion,
			@v_telefono,
			@v_correoElectronico,
			@v_estado,
			@v_codUsuario,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Persona
create Procedure proConsultarPersona(@v_documento varchar(50),@v_DcodTipoDocumento varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPaisNacimiento int,@v_codTipoDocumento int,@v_estado char(1),@v_codUsuario varchar(50),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_codTipoDocumento = (select td.CodTipoDocumento from TipoDocumento td where upper(td.Descripcion)=upper(@v_DcodTipoDocumento));
		
		if @v_TipoEvento ='C' and not exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
		Begin
			Select @vMsgError ='El Documento y tipo de documento no pertene a una Persona' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento and p.Estado='I')
		Begin
			Select @vMsgError ='El Documento y tipo de documento pertenece a una Persona Inactiva' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento and p.Estado='A')
		Begin
			select p.Nombre as nombre,
			p.Apellido as apellido,
			CONVERT(VARCHAR(10), p.FechaNacimiento, 103) as fecnacimiento,
			upper(pp.Descripcion) as pais,
			p.Direccion as direccion,
			p.Telefono as telefono,
			p.CorreoElectronico as correo,
			p.CodUsuario as usuario, 	
			upper(tp.Descripcion) as tipopersona
			from Persona p 
			inner join Pais pp on pp.CodPais=p.CodPaisNacimiento
			inner join TipoPersona tp on tp.CodTipoPersona=p.CodTipoPersona
			where p.Documento=@v_documento 
			and p.CodTipoDocumento=@v_codTipoDocumento;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para eliminar una Persona
create Procedure proEliminarPersona(@v_documento varchar(50),@v_DcodTipoDocumento varchar(50),@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codTipoDocumento int,@v_codUsuario varchar(50), @v_fechaModificacion date,@v_usuarioModificacion varchar(50);
	Begin Try
		Begin Transaction
		set @v_fechaModificacion = GETDATE();
		set @v_usuarioModificacion = @v_usuarioM;
	    set @v_codTipoDocumento = (select td.CodTipoDocumento from TipoDocumento td where upper(td.Descripcion)=upper(@v_DcodTipoDocumento));
		set @v_codUsuario = (select p.CodUsuario from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento and p.Estado='A');

		If @v_TipoEvento ='E'  and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento and p.Estado='A')
		Begin
			update Persona set Estado='I', UsuarioModificacion =@v_usuarioModificacion, FechaModificacion=@v_fechaModificacion
			where upper(Documento)=upper(@v_documento)
			and CodTipoDocumento=@v_codTipoDocumento
			and Estado='A';

			update Usuario set Estado='I'
			where CodUsuario=@v_codUsuario;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

create Procedure proConsultarPersonaEstadoIA(@v_documento varchar(50),@v_DcodTipoDocumento varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPaisNacimiento int,@v_codTipoDocumento int,@v_estado char(1),@v_codUsuario varchar(50),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_codTipoDocumento = (select td.CodTipoDocumento from TipoDocumento td where upper(td.Descripcion)=upper(@v_DcodTipoDocumento));
		
		if @v_TipoEvento ='C' and not exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
		Begin
			Select @vMsgError ='El Documento y tipo de documento no pertene a una Persona' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
		Begin
			select p.Nombre as nombre,
			p.Apellido as apellido,
			CONVERT(VARCHAR(10), p.FechaNacimiento, 103) as fecnacimiento,
			upper(pp.Descripcion) as pais,
			p.Direccion as direccion,
			p.Telefono as telefono,
			p.CorreoElectronico as correo,
			p.CodUsuario as usuario, 	
			upper(tp.Descripcion) as tipopersona,
			p.Estado as estado
			from Persona p 
			inner join Pais pp on pp.CodPais=p.CodPaisNacimiento
			inner join TipoPersona tp on tp.CodTipoPersona=p.CodTipoPersona
			where p.Documento=@v_documento 
			and p.CodTipoDocumento=@v_codTipoDocumento;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para modificar una nueva Persona
create Procedure proModificarPersona(
@v_documento varchar(50),
@v_DcodTipoDocumento varchar(50),
@v_DcodTipoPersona varchar(50),
@v_nombre varchar(50),
@v_apellido varchar(50),
@v_fechaNacimiento date,
@v_DcodPaisNacimiento varchar(50),
@v_direccion varchar(100),
@v_telefono varchar(20),
@v_correoElectronico varchar(200),
@v_estado char(1),
@v_usuarioM varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPaisNacimiento int,@v_codTipoDocumento int,@v_codUsuario varchar(50),@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;			
			set @v_codTipoDocumento = (select td.CodTipoDocumento from TipoDocumento td where upper(td.Descripcion)=upper(@v_DcodTipoDocumento));
			set @v_codPaisNacimiento = (select p.CodPais from Pais p where upper(p.Descripcion)=upper(@v_DcodPaisNacimiento));
			set @v_codTipoPersona = (select tp.CodTipoPersona from TipoPersona tp where upper(tp.Descripcion)=upper(@v_DcodTipoPersona));
						
		if @v_TipoEvento ='M' and exists (select * from Persona p where upper(p.Documento)!=upper(@v_documento) and CodTipoDocumento!=@v_codTipoDocumento and
		upper(p.CorreoElectronico)=upper(@v_correoElectronico))
		Begin
			Select @vMsgError ='El Correo electrónico ya esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end


		if @v_TipoEvento ='M' 
		and exists (select * from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
		Begin

			IF (@v_estado)='A'
			Begin
				update Usuario set Estado='A'
				where CodUsuario=(select p.CodUsuario from Persona p where upper(p.Documento)=upper(@v_documento) and CodTipoDocumento=@v_codTipoDocumento)
				and Estado='I';
			End			

			update Persona set 
			    CodTipoPersona=@v_codTipoPersona,
			    Nombre=@v_nombre,
				Apellido=@v_apellido,
				FechaNacimiento=@v_fechaNacimiento,
				CodPaisNacimiento=@v_codPaisNacimiento,
				Direccion=@v_direccion,
				Telefono=@v_telefono,
				CorreoElectronico=@v_correoElectronico,
				Estado=@v_estado,
				UsuarioModificacion=@v_usuarioM,
				FechaModificacion=@v_fechaModificacion
				where upper(Documento)=upper(@v_documento)
				and CodTipoDocumento=@v_codTipoDocumento;
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Editorial

-------2 entrega
---------EDITORIAL---------
---procedimiento para agregar un nuevo Editorial
create Procedure proAgregarEditorial(@v_nombre varchar(50),@v_Dpais varchar(50),@v_direccion varchar(100),@v_usuarioI varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codPais int,@v_estado char(1),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_codPais = (select p.CodPais from Pais p where upper(p.Descripcion)=upper(@v_Dpais));
			
	
		if @v_TipoEvento ='I' 
		and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El nombre pertenece a una Editorial ya registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and not exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin
			
			insert into Editorial values  (
			@v_nombre,
			@v_codPais,
			@v_direccion,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Editorial
create Procedure proConsultarEditorial(@v_nombre varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction
		
		if @v_TipoEvento ='C' and not exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El Nombre no pertene a una Editorial' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre) and e.Estado='I')
		Begin
			Select @vMsgError ='El Nombre pertene a una Editorial Inactiva' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre) and e.Estado='A')
		Begin
			select e.NombreEditorial as nombre,
			upper(p.Descripcion) as pais,
			e.Direccion as direccion
			from Editorial e
			inner join Pais p on p.CodPais=e.PaisEditorial
			where upper(e.NombreEditorial)=upper(@v_nombre)
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Editorial

---procedimiento para eliminar una Editorial
create Procedure proEliminarEditorial(@v_nombre varchar(50),@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codTipoDocumento int,@v_codUsuario varchar(50), @v_fechaModificacion date,@v_usuarioModificacion varchar(50);
	Begin Try
		Begin Transaction
		set @v_fechaModificacion = GETDATE();
		set @v_usuarioModificacion = @v_usuarioM;

		If @v_TipoEvento ='E'  and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre) and e.Estado='A')
		Begin
			update Editorial set Estado='I', UsuarioModificacion =@v_usuarioModificacion, FechaModificacion=@v_fechaModificacion
			where upper(NombreEditorial)=upper(@v_nombre)
			and Estado='A';
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Editorial Activa o Inactiva
create Procedure proConsultarEditorialIA(@v_nombre varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction
		
		if @v_TipoEvento ='C' and 
		not exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El Nombre no pertene a una Editorial' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end
		
		if @v_TipoEvento ='C'  and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin
			select e.NombreEditorial as nombre,
			upper(p.Descripcion) as pais,
			e.Direccion as direccion,
			e.Estado as estado
			from Editorial e
			inner join Pais p on p.CodPais=e.PaisEditorial
			where upper(e.NombreEditorial)=upper(@v_nombre)
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para modificar un Editorial
create Procedure proModificarEditorial(
@v_nombre varchar(50),
@v_Dpais varchar(50),
@v_direccion varchar(50),
@v_estado char(1),
@v_usuarioM varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codPais int,@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_cantidad int;
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_codPais = (select p.CodPais from Pais p where upper(p.Descripcion)=upper(@v_Dpais));

		if @v_TipoEvento ='M' 
		and exists (select * from Editorial e where upper(e.NombreEditorial)=upper(@v_nombre))
		Begin		

			update Editorial set 
			    NombreEditorial=@v_nombre,
			    PaisEditorial=@v_codPais,
				Direccion=@v_direccion,
				Estado=@v_estado,
				UsuarioModificacion=@v_usuarioM,
				FechaModificacion=@v_fechaModificacion
				where upper(NombreEditorial)=upper(@v_nombre);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---------MATERIA---------
---procedimiento para agregar una nueva Materia
create Procedure proAgregarMateria(@v_nombre varchar(50),
@v_clave varchar(50),
@v_descripcion varchar(500),
@v_Dfacultad varchar(500),
@v_usuarioI varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_estado char(1),@v_facultad int,@v_codFacultad int,@v_permiso char(1),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_facultad=(select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
	
		set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuarioI,@v_facultad) as permiso);

		if @v_TipoEvento ='I' and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para agregar las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad); ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El nombre de la Materia ya esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and exists (select * from Materia m where upper(m.ClaveMateria)=upper(@v_clave))
		Begin
			Select @vMsgError ='La clave de la Materia ya esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and not exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and upper(m.ClaveMateria)=upper(@v_clave))
		Begin
			insert into Materia values  (
			@v_nombre,
			@v_clave,
			@v_descripcion,
			@v_facultad,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Materia
create Procedure proConsultarMateria(@v_nombre varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El Nombre de la Materia no esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and m.Estado='I')
		Begin
			Select @vMsgError ='El Nombre pertenece a una Materia Inactiva' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and m.Estado='A')
		Begin
			select m.NombreMateria as nombre,
			m.ClaveMateria as clave,
			m.DesciptcionMateria as descripcion,
			f.NombreFacultad as facultad			
			from Materia m
			inner join Facultad f
			on f.CodFacultad =m.FacultadMateria
			where upper(m.NombreMateria)=upper(@v_nombre);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Materia Activa o Inactiva
create Procedure proConsultarMateriaAI(@v_nombre varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
		Begin
			Select @vMsgError ='El nombre de la Materia no esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
		Begin
			select m.NombreMateria as nombre,
			m.ClaveMateria as clave,
			m.DesciptcionMateria as descripcion,
			f.NombreFacultad as facultad,
			m.Estado as estado		
			from Materia m
			inner join Facultad f
			on f.CodFacultad =m.FacultadMateria
			where upper(m.NombreMateria)=upper(@v_nombre);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para eliminar una Materia
create Procedure proEliminarMateria(@v_nombre varchar(50),@v_clave varchar(50),@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codPais int, 
	@v_permiso char(1),@v_codFacultad int,@v_Dfacultad varchar(100),
	@v_codTipoDocumento int,@v_codUsuario varchar(50), @v_fechaModificacion date,@v_usuarioModificacion varchar(50);
	Begin Try
		Begin Transaction
		set @v_fechaModificacion = GETDATE();
		set @v_usuarioModificacion = @v_usuarioM;

		set @v_codFacultad =(select m.FacultadMateria from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and upper(m.ClaveMateria)=upper(@v_clave));
		set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuarioM,@v_codFacultad) as permiso);
		set @v_Dfacultad = (select f.NombreFacultad from Facultad f where f.CodFacultad=@v_codFacultad);

		if @v_TipoEvento ='E'  and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para eliminar las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad); 
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		If @v_TipoEvento ='E' 
		and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and upper(m.ClaveMateria)=upper(@v_clave) and m.Estado='A')
		Begin
			update Materia set Estado='I', UsuarioModificacion =@v_usuarioModificacion, FechaModificacion=@v_fechaModificacion
			where upper(NombreMateria)=upper(@v_nombre)
			and upper(ClaveMateria)=upper(@v_clave)
			and Estado='A';
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Materia
--select * from Facultad

---procedimiento para modificar una Materia
create Procedure proModificarMateria(
@v_nombre varchar(50),
@v_clave varchar(50),
@v_descripcion varchar(50),
@v_Dfacultad varchar(500),
@v_estado char(1),
@v_usuarioM varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_facultad int,@v_codFacultad int, @v_permiso char(1),
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_cantidad int,@v_clave_O varchar(50);
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_clave_O = (select m.ClaveMateria from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
			set @v_cantidad = 0;
			set @v_facultad=(select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
		
		set @v_codFacultad =(select m.FacultadMateria from Materia m where upper(m.NombreMateria)=upper(@v_nombre) and upper(m.ClaveMateria)=upper(@v_clave));
		set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuarioM,@v_codFacultad) as permiso);
		set @v_Dfacultad = (select f.NombreFacultad from Facultad f where f.CodFacultad=@v_codFacultad);

			
		if @v_TipoEvento ='M'  and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para modificar las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad);
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_clave_O != @v_clave
		Begin
			set @v_cantidad = (select count(*) from Materia m where upper(m.ClaveMateria)=upper(@v_clave)) + 1;
		end 
		
						
		if @v_TipoEvento ='M' and @v_cantidad > 1
		Begin
			Select @vMsgError ='La Clave pertene a una Materia ya registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end


		if @v_TipoEvento ='M' 
		and exists (select * from Materia m where upper(m.NombreMateria)=upper(@v_nombre))
		Begin		

			update Materia set 
			    NombreMateria=@v_nombre,
			    ClaveMateria=@v_clave,
				DesciptcionMateria=@v_descripcion,
				Estado=@v_estado,
				FacultadMateria=@v_facultad,
				UsuarioModificacion=@v_usuarioM,
				FechaModificacion=@v_fechaModificacion
				where upper(NombreMateria)=upper(@v_nombre);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---------------libro----------------
---procedimiento para agregar un nuevo libro
create Procedure proAgregarLibro(@v_isbn varchar(50),
@v_titulo varchar(50),
@v_Deditorial varchar(50),
@v_Dtipo_libro varchar(50),
@v_autor varchar(50),
@v_edicion varchar(50),
@v_Didioma varchar(50),
@v_año varchar(50),
@v_usuarioI varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_estado char(1),
	@v_editorial int,@v_tipo_libro int, @v_idioma int,
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_editorial = (select e.CodEditorial from Editorial e where upper(e.NombreEditorial)=upper(@v_Deditorial));
			set @v_tipo_libro = (select tp.CodTipoLibro from TipoLibro tp where upper(tp.NombreTipo)=upper(@v_Dtipo_libro));
			set @v_idioma = (select i.CodIdioma from Idioma i where upper(i.NombreIdioma)=upper(@v_Didioma));
	
		if @v_TipoEvento ='I' 
		and exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			Select @vMsgError ='El ISBN ya esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and not exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			insert into Libro values  (
			@v_isbn,
			@v_titulo,
			@v_editorial,
			@v_tipo_libro,
			@v_autor,
			@v_edicion,
			@v_idioma,
			@v_año,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar un Libro
create Procedure proConsultarLibro(@v_isbn varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			Select @vMsgError ='El ISBN del Libro no esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and exists (select * from  Libro l where upper(l.ISBN)=upper(@v_isbn) and l.Estado='I')
		Begin
			Select @vMsgError ='El ISBN perten a un Libro inactivo' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from  Libro l where upper(l.ISBN)=upper(@v_isbn) and l.Estado='A')
		Begin
			select 
			l.ISBN as isbn,
			l.TituloLibro as titulo,
			upper(e.NombreEditorial) as editorial,
			upper(tp.NombreTipo) as tipolibro,
			l.Autor as autor,
			l.Edicion as edicion, 
			upper(i.NombreIdioma)  as idioma, 
			l.Año as año					
			from Libro l
			inner join Editorial e
			on e.CodEditorial =l.CodEditorial
			inner join TipoLibro tp
			on tp.CodTipoLibro=l.CodTipoLibro
			inner join Idioma i
			on i.CodIdioma=l.CodIdioma
			where upper(l.ISBN)=upper(@v_isbn);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar un Libro activo y inactivo
create Procedure proConsultarLibroAI(@v_isbn varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			Select @vMsgError ='El ISBN del Libro no esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from  Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			select 
			l.ISBN as isbn,
			l.TituloLibro as titulo,
			upper(e.NombreEditorial) as editorial,
			upper(tp.NombreTipo) as tipolibro,
			l.Autor as autor,
			l.Edicion as edicion, 
			upper(i.NombreIdioma)  as idioma, 
			l.Año as año,
			l.Estado estado					
			from Libro l
			inner join Editorial e
			on e.CodEditorial =l.CodEditorial
			inner join TipoLibro tp
			on tp.CodTipoLibro=l.CodTipoLibro
			inner join Idioma i
			on i.CodIdioma=l.CodIdioma
			where upper(l.ISBN)=upper(@v_isbn);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Libro

---procedimiento para eliminar un Libro
create Procedure proEliminarLibro(@v_isbn varchar(50),@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codPais int,
	@v_codTipoDocumento int,@v_codUsuario varchar(50), @v_fechaModificacion date,@v_usuarioModificacion varchar(50);
	Begin Try
		Begin Transaction
		set @v_fechaModificacion = GETDATE();
		set @v_usuarioModificacion = @v_usuarioM;

		If @v_TipoEvento ='E' 
		and exists (select * from  Libro l where upper(l.ISBN)=upper(@v_isbn) and l.Estado='A')
		Begin
			update Libro set Estado='I', UsuarioModificacion =@v_usuarioModificacion, FechaModificacion=@v_fechaModificacion
			where upper(ISBN)=upper(@v_isbn)
			and Estado='A';
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para modificar un Libro
create Procedure proModificarLibro(
@v_isbn varchar(50),
@v_titulo varchar(50),
@v_Deditorial varchar(50),
@v_Dtipo_libro varchar(50),
@v_autor varchar(50),
@v_edicion varchar(50),
@v_Didioma varchar(50),
@v_año varchar(50),
@v_estado char(1),
@v_usuarioM varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_editorial int, @v_tipo_libro int ,@v_idioma int,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_cantidad int,@v_clave_O varchar(50);
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_editorial = (select e.CodEditorial from Editorial e where upper(e.NombreEditorial)=upper(@v_Deditorial));
			set @v_tipo_libro = (select tp.CodTipoLibro from TipoLibro tp where upper(tp.NombreTipo)=upper(@v_Dtipo_libro));
			set @v_idioma = (select i.CodIdioma from Idioma i where upper(i.NombreIdioma)=upper(@v_Didioma));
			
		if @v_TipoEvento ='M' 
		and not exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin
			Select @vMsgError ='El ISBN  del Libro no esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='M' 
		and exists (select * from Libro l where upper(l.ISBN)=upper(@v_isbn))
		Begin		
			update Libro set 
			ISBN = @v_isbn,
			TituloLibro = @v_titulo,
			CodEditorial = @v_editorial,
			CodTipoLibro = @v_tipo_libro,
			Autor = @v_autor,
			Edicion = @v_edicion,
			CodIdioma = @v_idioma,
            Año = @v_año,
			Estado = @v_estado,
			UsuarioModificacion=@v_usuarioModificacion,
			FechaModificacion=@v_fechaModificacion
			where upper(ISBN)=upper(@v_isbn);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---------------Carrera----------------------
---procedimiento para agregar una Carrera
create Procedure proAgregarCarrera(
@v_nombre varchar(50),
@v_promocion int,
@v_Dfacultad varchar(50),
@v_descripcion varchar(50),
@v_usuarioI varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_estado char(1), @v_facultad int,
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_facultad = (select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
			
		if @v_TipoEvento ='I' 
		and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin
			Select @vMsgError ='El Nombre y promocion de la Carrera ya esta registrado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='I' 
		and not exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin
			insert into Carrera values  (
			@v_nombre,
			@v_promocion,
			@v_facultad,
			@v_descripcion,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para consultar una Carrera
create Procedure proConsultarCarrera(@v_nombre varchar(50),@v_promocion int,@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin
			Select @vMsgError ='El Nombre y promoción de la Carrera no esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C' and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and c.Promocion=@v_promocion and c.Estado='I')
		Begin
			Select @vMsgError ='El Nombre y promoción pertenece a una Carrera Inactiva' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and c.Promocion=@v_promocion and c.Estado='A')
		Begin
			select c.NombreCarrera as nombre,
			c.Promocion as promocion,
			c.DesciptcionCarrera as descripcion,
			upper(f.NombreFacultad) as facultad			
			from Carrera c
			inner join Facultad f
			on f.CodFacultad =c.CodFacultad
			where upper(c.NombreCarrera)=upper(@v_nombre)
			and c.Promocion=@v_promocion;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Carrera

---procedimiento para consultar una Carrera inactiva activa
create Procedure proConsultarCarreraIA(@v_nombre varchar(50),@v_promocion int,@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codTipoPersona int,
	@v_codPais int;
	Begin Try
		Begin Transaction

		if @v_TipoEvento ='C' and not exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin
			Select @vMsgError ='El Nombre y promoción de la Carrera no esta registrada' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		if @v_TipoEvento ='C'  and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin
			select c.NombreCarrera as nombre,
			c.Promocion as promocion,
			c.DesciptcionCarrera as descripcion,
			f.NombreFacultad as facultad,	
			c.Estado as estado		
			from Carrera c
			inner join Facultad f
			on f.CodFacultad =c.CodFacultad
			where upper(c.NombreCarrera)=upper(@v_nombre)
			and upper(c.Promocion)=upper(@v_promocion);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para eliminar una Carrera
create Procedure proEliminarCarrera(@v_nombre varchar(50),@v_promocion int,@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codPais int,@v_codCarrera int,
	@v_codTipoDocumento int,@v_codUsuario varchar(50), @v_fechaModificacion date,@v_usuarioModificacion varchar(50);
	Begin Try
		Begin Transaction
		set @v_fechaModificacion = GETDATE();
		set @v_usuarioModificacion = @v_usuarioM;
		set @v_codCarrera = (select c.CodCarrera from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and c.Promocion=@v_promocion);

		If @v_TipoEvento ='E' 
		and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion) and c.Estado='A')
		Begin
			update Carrera 
			set Estado='I', 
			UsuarioModificacion=@v_usuarioModificacion, 
			FechaModificacion=@v_fechaModificacion
			where upper(NombreCarrera)=upper(@v_nombre)
			and upper(Promocion)=upper(@v_promocion)
			and Estado='A';

			update CarreraMateria
			set Estado='I',
			UsuarioModificacion=@v_usuarioModificacion, 
			FechaModificacion=@v_fechaModificacion
			where upper(CodCarrera) = upper(@v_codCarrera)
			and upper(Promocion)=upper(@v_promocion);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para modificar una Carrera
create Procedure proModificarCarrera(
@v_nombre varchar(50),
@v_promocion int,
@v_descripcion varchar(50),
@v_Dfacultad varchar(500),
@v_estado char(1),
@v_usuarioM varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_facultad int,@v_codCarrera int,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_cantidad int,@v_clave_O varchar(50);
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_facultad=(select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
			set @v_codCarrera = (select c.CodCarrera from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and c.Promocion=@v_promocion);		
						
		if @v_TipoEvento ='M' 
		and exists (select * from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and upper(c.Promocion)=upper(@v_promocion))
		Begin		

			update Carrera set 
			    NombreCarrera=@v_nombre,
			    Promocion=@v_promocion,
				CodFacultad=@v_facultad,
				DesciptcionCarrera=@v_descripcion,
				Estado=@v_estado,
				UsuarioModificacion=@v_usuarioM,
				FechaModificacion=@v_fechaModificacion
				where upper(NombreCarrera)=upper(@v_nombre)
				and upper(Promocion)=upper(@v_promocion);

			if @v_estado='A'
			begin
				update CarreraMateria
				set Estado='A',
				UsuarioModificacion=@v_usuarioModificacion, 
				FechaModificacion=@v_fechaModificacion
				where upper(CodCarrera) = upper(@v_codCarrera)
				and upper(Promocion)=upper(@v_promocion);
			end

		end	 
		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

------------------------------USUARIO FACULTAD------------------------------------
---procedimiento que devuelve facultad asociado a un usuario
create Procedure proDevolverUsuarioFacultad(@v_usuario varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int;
	Begin Try
		Begin Transaction
	
		if @v_TipoEvento ='U'
		Begin
			select upper(f.NombreFacultad) as facultad
			from UsuarioFacultad ua 
			inner join Facultad f
			on f.CodFacultad = ua.CodFacultad
			where upper(ua.CodUsuario)=upper(@v_usuario)
			and ua.Estado='A'
			order by upper(f.NombreFacultad) asc;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que agregar un usuario y facultad
create Procedure proAgregarUsuarioFacultad(@v_usuario varchar(50),@v_Dfacultad varchar(100),@v_usuarioI varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_facultad int,@v_usuarioInsercion varchar(50),@v_fechaInsercion date,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_estado char(1);
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_facultad = (select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
 
		if @v_TipoEvento ='A' and 
		exists (select * from UsuarioFacultad ua where upper(ua.CodUsuario)=upper(@v_usuario) and upper(ua.CodFacultad)=upper(@v_facultad) and ua.Estado='I')
		Begin
			update UsuarioFacultad
			set Estado='A', 
			UsuarioModificacion=@v_usuarioInsercion,
			FechaModificacion=@v_fechaInsercion
			where upper(CodUsuario)=upper(@v_usuario) 
			and upper(CodFacultad)=upper(@v_facultad);
		end	

		if @v_TipoEvento ='A' and 
		not exists (select * from UsuarioFacultad ua where upper(ua.CodUsuario)=upper(@v_usuario) and upper(ua.CodFacultad)=upper(@v_facultad))
		Begin
			insert into UsuarioFacultad values (
			@v_usuario,
			@v_facultad,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from UsuarioFacultad;

---procedimiento que ELIMINAR un usuario y facultad
create Procedure proEliminarUsuarioFacultad(@v_usuario varchar(50),@v_Dfacultad varchar(100),@v_usuarioM varchar(50),@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_facultad int,@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_facultad = (select f.CodFacultad from Facultad f where upper(f.NombreFacultad)=upper(@v_Dfacultad));
 
		if @v_TipoEvento ='E' and 
		exists (select * from UsuarioFacultad ua where upper(ua.CodUsuario)=upper(@v_usuario) and upper(ua.CodFacultad)=upper(@v_facultad))
		Begin
			update UsuarioFacultad
			set Estado='I', 
			UsuarioModificacion=@v_usuarioModificacion,
			FechaModificacion=@v_fechaModificacion
			where upper(CodUsuario)=upper(@v_usuario) 
			and upper(CodFacultad)=upper(@v_facultad)
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

------------------------------CARRERA MATERIA------------------------------------
---procedimiento que devuelve las materias asociadas a una carrera
create Procedure proDevolverCarreraMateria(@v_nombre varchar(50),@v_promocion int ,@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,@v_codCarrera int ;
	Begin Try
		Begin Transaction
		set @v_codCarrera = (select c.CodCarrera from Carrera c where upper(c.NombreCarrera)=upper(@v_nombre) and c.Promocion=@v_promocion);
	
		if @v_TipoEvento ='M'
		Begin
			select upper(m.NombreMateria) as materia
			from CarreraMateria cm
			inner join Materia m
			on m.CodMateria = cm.CodMateria
			where upper(cm.CodCarrera)=upper(@v_codCarrera)
			and cm.Estado='A'
			order by upper(m.NombreMateria) asc;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Carrera
--select * from Materia
--select * from CarreraMateria
--insert into CarreraMateria values (3,1,'Periodismo','Logica 1',2010,'A',null,null,null,null)

---procedimiento que agregar una carrera y materia
create Procedure proAgregarCarreraMateria(
@v_Dcarrera varchar(50),
@v_promocion int,
@v_Dmateria varchar(100),
@v_usuarioI varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codCarrera int,@v_codMateria int,
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_estado char(1);
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_estado='A';
			set @v_codCarrera = (select c.CodCarrera from Carrera c where upper(c.NombreCarrera)=upper(@v_Dcarrera) and c.Promocion=@v_promocion);
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_Dmateria));

		if @v_TipoEvento ='A' and 
		exists (select * from CarreraMateria cm where 
		upper(cm.CodCarrera)=upper(@v_codCarrera) 
		and upper(cm.CodMateria)=upper(@v_codMateria) 
		and upper(cm.Promocion)=upper(@v_promocion)  
		and cm.Estado='I')
		Begin
			update CarreraMateria
			set Estado='A', 
			UsuarioModificacion=@v_usuarioInsercion,
			FechaModificacion=@v_fechaInsercion
			where upper(CodCarrera)=upper(@v_codCarrera) 
			and upper(CodMateria)=upper(@v_codMateria)
			and upper(Promocion)=upper(@v_promocion) ;
		end	

		if @v_TipoEvento ='A' and 
		not exists (select * from CarreraMateria cm where 
		upper(cm.CodCarrera)=upper(@v_codCarrera) 
		and upper(cm.CodMateria)=upper(@v_codMateria) 
		and upper(cm.Promocion)=upper(@v_promocion))
		Begin
			insert into CarreraMateria values (
			@v_codCarrera,
			@v_codMateria,
			@v_Dcarrera,
			@v_Dmateria,
			@v_promocion,
			@v_estado,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que ELIMINAR una carrera y materia
create Procedure proEliminarCarreraMateria(
@v_Dcarrera varchar(50),
@v_promocion int,
@v_Dmateria varchar(100),
@v_usuarioM varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codCarrera int ,@v_codMateria int,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date;
	Begin Try
		Begin Transaction
			set @v_fechaModificacion = GETDATE();
			set @v_usuarioModificacion = @v_usuarioM;
			set @v_codCarrera = (select c.CodCarrera from Carrera c where upper(c.NombreCarrera)=upper(@v_Dcarrera) and c.Promocion=@v_promocion);
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_Dmateria));
		
		if @v_TipoEvento ='E' and 
		exists 
		(select * from CarreraMateria cm where 
		upper(cm.CodCarrera)=upper(@v_codCarrera) 
		and upper(cm.CodMateria)=upper(@v_codMateria) 
		and upper(cm.Promocion)=upper(@v_promocion))
		Begin
			update CarreraMateria
			set Estado='I', 
			UsuarioModificacion=@v_usuarioModificacion,
			FechaModificacion=@v_fechaModificacion
			where upper(CodCarrera)=upper(@v_codCarrera) 
			and upper(CodMateria)=upper(@v_codMateria) 
			and upper(Promocion)=upper(@v_promocion)
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from Carrera
--select * from CarreraMateria;

------------3 entregar--------------

---procedimiento para verificar una Bibliografia
create Procedure proVerificarBibliografia(
@v_DnombreMateria varchar(50),
@v_año int,
@v_Dsemestre varchar(50),
@v_usuario_i varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int,@v_codSemestre int,
	@v_facultad int,@v_Dfacultad varchar(500),@v_permiso char(1);
	Begin Try
		Begin Transaction
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
			set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));
			
			set @v_facultad=(select m.FacultadMateria from Materia m where m.CodMateria=@v_codMateria);
	        set @v_Dfacultad=(select f.NombreFacultad from Facultad f where f.CodFacultad=@v_facultad);
			set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuario_i,@v_facultad) as permiso);

		if @v_TipoEvento ='V' and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para realizar solicitudes de las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad); ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='V' and 
		exists 
		(select * from MateriaLibro MT where 
		mt.CodMateria=@v_codMateria 
		and mt.Año=@v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('S')		
		)
		Begin
		    Select @vMsgError ='El año y semestre de la Materia ya pertenecen a una solicitud en estado Solicitado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='V' and 
		exists 
		(select * from MateriaLibro MT where 
		mt.CodMateria=@v_codMateria 
		and mt.Año=@v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('A')		
		)
		Begin
		    Select @vMsgError ='El año y semestre de la Materia ya pertenecen a una solicitud en estado Aprobado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='V' and 
		exists 
		(select * from MateriaLibro MT where 
		mt.CodMateria=@v_codMateria 
		and mt.Año=@v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('I')		
		)
		Begin
		    Select @vMsgError ='El año y semestre de la Materia ya pertenecen a una solicitud en estado Inactivo' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end

		select 1 as OK;

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que agregar una materia libro estado P
create Procedure proSolicitarAgregarMateriaLibroP(
@v_DnombreMateria varchar(500),
@v_Disbn varchar(50),
@v_DtipoBibliografia varchar(50),
@v_año int,
@v_Dsemestre varchar(50),
@v_descripcion varchar(500),
@v_usuarioI varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int,@v_codLibro int,@v_codTipoBibliografia int,@v_codSemestre int,
	@v_usuarioSolicitante varchar(50),@v_usuarioAutorizador varchar(50), @v_usuarioInactivador varchar(50),
	@v_usuarioInsercion varchar(50),@v_fechaInsercion date,
	@v_usuarioModificacion varchar(50),@v_fechaModificacion date,@v_estado char(1);
	Begin Try
		Begin Transaction
			set @v_fechaInsercion = GETDATE();
			set @v_fechaModificacion = null;
			set @v_usuarioInsercion = @v_usuarioI;
			set @v_usuarioSolicitante= @v_usuarioI;
			set @v_usuarioModificacion = null;
			set @v_usuarioAutorizador = null;
			set @v_usuarioInactivador = null;
			set @v_estado='P';

			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
			set @v_codLibro = (select l.CodLibro from Libro l where upper(l.ISBN)=upper(@v_Disbn));
			set @v_codTipoBibliografia = (select tb.CodTipoBibliografia from TipoBibliografia tb where upper(tb.Descripcion)=upper(@v_DtipoBibliografia));
			set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));


		if @v_TipoEvento ='P' and 
		not exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.CodLibro = @v_codLibro
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado='P')	
		Begin

			insert into MateriaLibro values (
			@v_codMateria,
			@v_codLibro,
			@v_codTipoBibliografia,
			@v_año,
			@v_codSemestre,
			@v_descripcion,
			@v_estado,
			@v_usuarioSolicitante,
			@v_usuarioAutorizador,
			@v_usuarioInactivador,
			@v_usuarioInsercion,
			@v_fechaInsercion,
			@v_usuarioModificacion,
			@v_fechaModificacion
			);
		end	

		if @v_TipoEvento ='P' and 
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.CodLibro = @v_codLibro
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.CodTipoBibliografia!=@v_codTipoBibliografia
		and mt.Estado='P')	
		Begin
		  update MateriaLibro
		  set CodTipoBibliografia=@v_codTipoBibliografia
		  where CodMateria = @v_codMateria
		  and CodLibro = @v_codLibro
		  and Año = @v_año
		  and CodSemestre=@v_codSemestre
		  and CodTipoBibliografia!=@v_codTipoBibliografia
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que devuelve las materias asociadas a una carrera
create Procedure proDevolverMateriaLibro(
@v_DnombreMateria varchar(500),
@v_año int ,
@v_Dsemestre varchar(50),
@v_usuario varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int, @v_codSemestre int;
	Begin Try
		Begin Transaction
		set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria) );
		set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre) );

		if @v_TipoEvento ='P'
		Begin
			select 
			'TIPO: '+upper(tb.Descripcion)
			+', ISBN: '+upper(l.ISBN)
			+', TITULO: '+upper(l.TituloLibro)
			+', AUTOR: '+upper(l.Autor)
			+', EDICION: '+upper(l.Edicion)
			+', EDITORIAL: '+upper(e.NombreEditorial) as datos
			from MateriaLibro mt
			inner join Libro l
			on l.CodLibro = mt.CodLibro
			inner join TipoBibliografia tb
			on tb.CodTipoBibliografia=mt.CodTipoBibliografia
			inner join Editorial e
			on e.CodEditorial=l.CodEditorial
			where mt.CodMateria=@v_codMateria
			and mt.Año=@v_año
			and mt.CodSemestre=@v_codSemestre
			and mt.UsuarioInsercion=@v_usuario
			and mt.Estado in('P')
			order by upper(tb.Descripcion) asc;
		end	

		if @v_TipoEvento ='S'
		Begin
			select 
			'TIPO: '+upper(tb.Descripcion)
			+', ISBN: '+upper(l.ISBN)
			+', TITULO: '+upper(l.TituloLibro)
			+', AUTOR: '+upper(l.Autor)
			+', EDICION: '+upper(l.Edicion)
			+', EDITORIAL: '+upper(e.NombreEditorial) as datos
			from MateriaLibro mt
			inner join Libro l
			on l.CodLibro = mt.CodLibro
			inner join TipoBibliografia tb
			on tb.CodTipoBibliografia=mt.CodTipoBibliografia
			inner join Editorial e
			on e.CodEditorial=l.CodEditorial
			where mt.CodMateria=@v_codMateria
			and mt.Año=@v_año
			and mt.CodSemestre=@v_codSemestre
			and mt.UsuarioInsercion=@v_usuario
			and mt.Estado in('S')
			order by upper(tb.Descripcion) asc;
		end	

		if @v_TipoEvento ='G'
		Begin
			select 
			'TIPO: '+upper(tb.Descripcion)
			+', ISBN: '+upper(l.ISBN)
			+', TITULO: '+upper(l.TituloLibro)
			+', AUTOR: '+upper(l.Autor)
			+', EDICION: '+upper(l.Edicion)
			+', EDITORIAL: '+upper(e.NombreEditorial) as datos
			from MateriaLibro mt
			inner join Libro l
			on l.CodLibro = mt.CodLibro
			inner join TipoBibliografia tb
			on tb.CodTipoBibliografia=mt.CodTipoBibliografia
			inner join Editorial e
			on e.CodEditorial=l.CodEditorial
			where mt.CodMateria=@v_codMateria
			and mt.Año=@v_año
			and mt.CodSemestre=@v_codSemestre
			and mt.UsuarioInsercion=@v_usuario
			and mt.Estado in('S','A','I')
			order by upper(tb.Descripcion) asc;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que eliminar una materia libro estado P
create Procedure proSolicitarEliminarMateriaLibroP(
@v_DnombreMateria varchar(500),
@v_Disbn varchar(50),
@v_DtipoBibliografia varchar(50),
@v_año int,
@v_Dsemestre varchar(50),
@v_descripcion varchar(500),
@v_usuarioI varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int,@v_codLibro int,@v_codTipoBibliografia int,@v_codSemestre int,
	@v_usuarioSolicitante varchar(50),@v_usuarioAutorizador varchar(50), @v_usuarioInactivador varchar(50);
	Begin Try
		Begin Transaction
			
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
			set @v_codLibro = (select l.CodLibro from Libro l where upper(l.ISBN)=upper(@v_Disbn));
			set @v_codTipoBibliografia = (select tb.CodTipoBibliografia from TipoBibliografia tb where upper(tb.Descripcion)=upper(@v_DtipoBibliografia));
			set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));

		if @v_TipoEvento ='E' and 
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.CodLibro = @v_codLibro
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.CodTipoBibliografia=@v_codTipoBibliografia
		and mt.Estado='P'
		and mt.UsuarioInsercion=@v_usuarioI)
		Begin
		  delete from MateriaLibro
		  where CodMateria = @v_codMateria
		  and CodLibro = @v_codLibro
		  and Año = @v_año
		  and CodSemestre=@v_codSemestre
		  and CodTipoBibliografia=@v_codTipoBibliografia
		  and Estado='P'
		  and UsuarioInsercion=@v_usuarioI
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que cambiar el estado de una solicitud de Bibliografia a estado S
create Procedure proSolicitarBibliografiaS(
@v_DnombreMateria varchar(500),
@v_año int,
@v_Dsemestre varchar(50),
@v_descripcion varchar(500),
@v_usuarioI varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int,@v_codSemestre int;
	Begin Try
		Begin Transaction
		set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
		set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));

		if @v_TipoEvento ='S' and 
		not exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.UsuarioInsercion=@v_usuarioI
		and mt.Estado='P'
		and mt.CodTipoBibliografia=1)	
		Begin
		    Select @vMsgError ='Debe Asignar almenos un libro cuyo tipo de bibliografia sea básica a la materia' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='S' and 
		not exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.UsuarioInsercion=@v_usuarioI
		and mt.Estado='P')	
		Begin
		    Select @vMsgError ='Debe Asignar libros a la materia' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	


		if @v_TipoEvento ='S' and 
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.UsuarioInsercion=@v_usuarioI
		and mt.Estado='P')	
		Begin
		  update MateriaLibro
		  set Estado='S',
		  Descripcion=@v_descripcion
		  where CodMateria = @v_codMateria
		  and Año = @v_año
		  and CodSemestre=@v_codSemestre
		  and UsuarioInsercion=@v_usuarioI
		  and Estado='P';
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que cambiar eliminar una solicitud de Bibliografia en estado P
create Procedure proEliminarBibliografiaE(
@v_DnombreMateria varchar(500),
--@v_año int,
@v_Dsemestre varchar(50),
@v_usuarioI varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int,@v_codSemestre int;
	Begin Try
		Begin Transaction
		set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
		set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));

		if @v_TipoEvento ='E' and 
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		--and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.UsuarioInsercion=@v_usuarioI
		and mt.Estado='P')	
		Begin
		  delete 
		  from MateriaLibro
		  where CodMateria = @v_codMateria
		  --and Año = @v_año
		  and CodSemestre=@v_codSemestre
		  and UsuarioInsercion=@v_usuarioI
		  and Estado='P';
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento que devuelve los libtos asociadas a una materia
create Procedure proDevolverBibliografia(
@v_DnombreMateria varchar(500),
@v_año int ,
@v_Dsemestre varchar(50),
@v_TipoEvento char(1)
)
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_codMateria int, @v_codSemestre int;
	Begin Try
		Begin Transaction
		set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria) );
		set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre) );

		if @v_TipoEvento ='G' and
		not exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('S','A','I'))	
		Begin
			Select @vMsgError ='El año y semestre de la Materia no pertenecen a un Solicitod en estado Solicitado, Activo o Inactivo' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		End

		if @v_TipoEvento ='G' and
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('S','A','I'))	
		Begin
			select 
			upper(m.NombreMateria) as materia,
			upper(mt.Año) as año,
			upper(s.Descripcion) as semestre,
			mt.Descripcion as descripcion,
			upper(mt.Estado) as estado,
			upper(mt.UsuarioSolicitante) as solicitante,
			upper(mt.UsuarioAutorizador) as autorizador,
			upper(mt.UsuarioInactivador) as inactivador
			from MateriaLibro mt
			inner join Semestre s
			on s.CodSemestre = mt.CodSemestre
			inner join Materia m
			on m.CodMateria = mt.CodMateria
			where mt.CodMateria=@v_codMateria
			and mt.Año=@v_año
			and mt.CodSemestre=@v_codSemestre
			and mt.Estado in ('S','A','I');
		End

		if @v_TipoEvento ='S' and
		not exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('S'))	
		Begin
			Select @vMsgError ='El año y semestre de la Materia no pertenecen a un Solicitod en estado Solicitado' ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		End

		if @v_TipoEvento ='S' and
		exists (select * from MateriaLibro mt where 
		mt.CodMateria = @v_codMateria
		and mt.Año = @v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Estado in ('S'))	
		Begin
			select 
			upper(m.NombreMateria) as materia,
			upper(mt.Año) as año,
			upper(s.Descripcion) as semestre,
			mt.Descripcion as descripcion,
			upper(mt.Estado) as estado,
			upper(mt.UsuarioSolicitante) as solicitante,
			upper(mt.UsuarioAutorizador) as autorizador,
			upper(mt.UsuarioInactivador) as inactivador
			from MateriaLibro mt
			inner join Semestre s
			on s.CodSemestre = mt.CodSemestre
			inner join Materia m
			on m.CodMateria = mt.CodMateria
			where mt.CodMateria=@v_codMateria
			and mt.Año=@v_año
			and mt.CodSemestre=@v_codSemestre
			and mt.Estado in ('S');
		end		

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para autorizar una Bibliografia
create Procedure proAutorizarBibliografiaS(
@v_DnombreMateria varchar(50),
@v_año int,
@v_Dsemestre varchar(50),
@v_descripcion varchar(500),
@v_usuario_s varchar(50),
@v_usuario_m varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_usuarioModificacion varchar(50),@v_usuarioAutorizador varchar(50), @v_usuarioInactivador varchar(50),
	@v_fechaModificacion date,	@v_codMateria int,@v_codSemestre int,
	@v_facultad int,@v_Dfacultad varchar(500),@v_permiso char(1);
	Begin Try
		Begin Transaction
			set @v_usuarioModificacion = @v_usuario_m;
			set @v_usuarioAutorizador = @v_usuario_m; 
			set @v_usuarioInactivador = @v_usuario_m; 
			set @v_fechaModificacion = GETDATE(); 
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
			set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));
		
			set @v_facultad=(select m.FacultadMateria from Materia m where m.CodMateria=@v_codMateria);
	        set @v_Dfacultad=(select f.NombreFacultad from Facultad f where f.CodFacultad=@v_facultad);
			set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuario_m,@v_facultad) as permiso);

		if @v_TipoEvento ='A' and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para autorizar las solicitudes de las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad); ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='A' and 
		exists 
		(select * from MateriaLibro MT
		where mt.CodMateria=@v_codMateria 
		and (mt.Año!=@v_año or mt.CodSemestre!=@v_codSemestre)
		and mt.Estado in ('A')		
		and mt.UsuarioAutorizador is not null
		and mt.UsuarioInactivador is null
		)
		Begin
		    update MateriaLibro
			set Estado='I',
			UsuarioInactivador=@v_usuarioInactivador, 
			UsuarioModificacion=@v_usuarioModificacion, 
			FechaModificacion=@v_fechaModificacion
			where CodMateria=@v_codMateria
			and (Año!=@v_año or CodSemestre!=@v_codSemestre)
			and Estado in ('A')		
			and UsuarioAutorizador is not null
			and UsuarioInactivador is null;
		end	
		
		if @v_TipoEvento ='A' and 
		exists 
		(select * from MateriaLibro MT
		where mt.CodMateria=@v_codMateria 
		and mt.Año=@v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Descripcion=@v_descripcion
		and mt.Estado in ('S')		
		and mt.UsuarioSolicitante=@v_usuario_s
		)
		Begin
		    update MateriaLibro
			set Estado='A',
			UsuarioAutorizador=@v_usuarioAutorizador, 
			UsuarioModificacion=@v_usuarioModificacion, 
			FechaModificacion=@v_fechaModificacion
			where CodMateria=@v_codMateria
			and Año=@v_año
			and CodSemestre=@v_codSemestre
			and Descripcion=@v_descripcion
			and Estado in ('S')
			and UsuarioSolicitante=@v_usuario_s;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go

---procedimiento para rechazar una Bibliografia
create Procedure proRechazarBibliografiaS(
@v_DnombreMateria varchar(50),
@v_año int,
@v_Dsemestre varchar(50),
@v_descripcion varchar(500),
@v_usuario_s varchar(50),
@v_usuario_m varchar(50),
@v_TipoEvento char(1))
As
Begin
	Declare @vNroError int, @vMsgError varchar(255), @ErrorSeverity int,
	@v_usuarioModificacion varchar(50),@v_usuarioAutorizador varchar(50), @v_usuarioInactivador varchar(50),
	@v_fechaModificacion date,	@v_codMateria int,@v_codSemestre int, 
	@v_facultad int,@v_Dfacultad varchar(500),@v_permiso char(1);
	Begin Try
		Begin Transaction
			set @v_usuarioModificacion = @v_usuario_m;
			set @v_usuarioAutorizador = @v_usuario_m; 
			set @v_fechaModificacion = GETDATE(); 
			set @v_codMateria = (select m.CodMateria from Materia m where upper(m.NombreMateria)=upper(@v_DnombreMateria));
			set @v_codSemestre = (select s.CodSemestre from Semestre s where upper(s.Descripcion)=upper(@v_Dsemestre));
			
			set @v_facultad=(select m.FacultadMateria from Materia m where m.CodMateria=@v_codMateria);
	        set @v_Dfacultad=(select f.NombreFacultad from Facultad f where f.CodFacultad=@v_facultad);
			set @v_permiso=(select dbo.fu_verificar_permiso(@v_usuario_m,@v_facultad) as permiso);

		if @v_TipoEvento ='R' and @v_permiso='N'
		Begin
			Select @vMsgError ='El Usuario no tiene permiso para rechazar las solicitudes de las Materias que pertenescan a la Facultad ' + upper(@v_Dfacultad); ;
		    Raiserror (@vMsgError, 16, 1);
			Select @vNroError =1;
		end	

		if @v_TipoEvento ='R' and 
		exists 
		(select * from MateriaLibro MT
		where mt.CodMateria=@v_codMateria 
		and mt.Año=@v_año
		and mt.CodSemestre=@v_codSemestre
		and mt.Descripcion=@v_descripcion
		and mt.Estado in ('S')		
		and mt.UsuarioSolicitante=@v_usuario_s
		)
		Begin
		    update MateriaLibro
			set Estado='R',
			UsuarioAutorizador=@v_usuarioAutorizador, 
			UsuarioModificacion=@v_usuarioModificacion, 
			FechaModificacion=@v_fechaModificacion
			where CodMateria=@v_codMateria
			and Año=@v_año
			and CodSemestre=@v_codSemestre
			and Descripcion=@v_descripcion
			and Estado in ('S')
			and UsuarioSolicitante=@v_usuario_s;
		end	

		Commit Transaction		
	End Try
	Begin Catch
		Select @vMsgError = Error_Message()
		Raiserror (@vMsgError, 16, 1)
		Rollback Transaction
	End Catch
End;
go
--select * from MateriaLibro
