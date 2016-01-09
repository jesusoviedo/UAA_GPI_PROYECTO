--0 crear base
create database Proyecto_GPI_GOLF;
go
--0.1 usar la base de datos
use Proyecto_GPI_GOLF;
go --stop un rato

--1 creamos la tabla pais
create table Pais  (CodPais int IDENTITY(1,1),
					Descripcion varchar(50) not null,
Constraint PK_Pais_CodPais primary key (CodPais),
Constraint UK_Pais_Descripcion unique(Descripcion));

--2 creamos la tabla ciudad
create table Ciudad  (CodCiudad int IDENTITY(1,1),
					  Descripcion varchar(50) not null,
					  CodPais int not null,
Constraint PK_Ciudad_CodCiudad primary key (CodCiudad),
Constraint FK_Ciudad_CodPais foreign key (CodPais) references Pais (CodPais));

--3 creamos la tabla tipodocumento
create table TipoDocumento  (CodTipoDocumento int IDENTITY(1,1),
							 Descripcion varchar(50) not null,
							 Abreviatura varchar(50) not null,
Constraint PK_TipoDocumento_CodTipoDocumento primary key (CodTipoDocumento),
Constraint UK_TipoDocumento_Descripcion unique(Descripcion),
Constraint UK_TipoDocumento_Abreviatura unique(Abreviatura)
);

--4 creamos la tabla tipopersona
create table TipoPersona  (CodTipoPersona int IDENTITY(1,1),
						   Descripcion varchar(50) not null,
Constraint PK_TipoPersona_CodTipoPersona primary key (CodTipoPersona),
Constraint UK_TipoPersona_Descripcion unique(Descripcion));

--5 creamos la tabla Pantalla
create table Pantalla (CodPantalla varchar(50),
					  Descripcion varchar(100) not null,
Constraint PK_Pantalla_CodPantalla primary key (CodPantalla));

--6 creamos la tabla usuario
create table Usuario  (CodUsuario varchar(50),
					   Clave VarBinary(8000) not null,
					   Estado char(1) not null,
					   CantidadIntento int default 0,
					   FechaUltimoIntento date, 
					   UsuarioInsercion varchar(50),
					   FechaInsercion date,
					   UsuarioModificacion varchar(50),
					   FechaModificacion date,
Constraint PK_Usuario_CodUsuario primary key (CodUsuario),
Constraint CK_Usuario_Estado check (Estado in('A','I','B')),
Constraint FK_Usuario_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Usuario_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario));

--7 creamos la tabla persona
create table Persona  (CodPersona int IDENTITY(1,1),
					   Documento varchar(50) not null,
					   CodTipoDocumento int not null,
					   CodTipoPersona int not null,
					   Nombre varchar(50) not null,
					   Apellido varchar(50) not null,
					   FechaNacimiento date not null,
					   CodPaisNacimiento int not null,
					   Direccion varchar(100),
					   Telefono varchar(20),
					   CorreoElectronico varchar(200) not null,
					   Estado char(1) not null,
					   CodUsuario varchar(50) not null,
					   UsuarioInsercion varchar(50),
					   FechaInsercion date,
					   UsuarioModificacion varchar(50),
					   FechaModificacion date,
Constraint PK_Persona_CodPersona primary key (CodPersona),
Constraint UK_Persona_Documento_CodTipoDocumento unique(Documento,CodTipoDocumento),
Constraint FK_Persona_CodTipoDocumento foreign key (CodTipoDocumento) references TipoDocumento (CodTipoDocumento),
Constraint FK_Persona_CodTipoPersona foreign key (CodTipoPersona) references TipoPersona (CodTipoPersona),
Constraint FK_Persona_CodPaisNacimiento foreign key (CodPaisNacimiento) references Pais (CodPais),
Constraint CK_Persona_Estado check (Estado in('A','I')),
Constraint UK_Persona_CorreoElectronico unique(CorreoElectronico),
Constraint FK_Persona_CodUsuario foreign key (CodUsuario) references Usuario (CodUsuario),
Constraint FK_Persona_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Persona_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario));

--8 creamos la tabla UsuarioPantalla
create table UsuarioPantalla (CodUsuario varchar(50) not null,
					  CodPantalla varchar(50) not null,
					  Estado char(1) not null,
					  UsuarioInsercion varchar(50),
					  FechaInsercion date,
					  UsuarioModificacion varchar(50),
					  FechaModificacion date,
Constraint PK_UsuarioPantalla_CodPersona_CodPantalla primary key (CodUsuario,CodPantalla),
Constraint FK_UsuarioPantalla_CodUsuario foreign key (CodUsuario) references Usuario (CodUsuario),
Constraint FK_UsuarioPantalla_CodPantalla foreign key (CodPantalla) references Pantalla (CodPantalla),
Constraint FK_UsuarioPantalla_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_UsuarioPantalla_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario),
Constraint CK_UsuarioPantalla_Estado check (Estado in('A','I')));

--2 entrega
--9 creamos la tabla Facultad
create table Facultad (CodFacultad int IDENTITY(1,1),
					 NombreFacultad varchar(500) not null,
Constraint PK_Facultad_CodUniversisdad primary key (CodFacultad),
Constraint UK_Facultad_NombreUniversisdad unique(NombreFacultad)
);

--10 creamos la tabla UsuarioFacultad
create table UsuarioFacultad (CodUsuario varchar(50) not null,
					  CodFacultad int not null,
					  Estado char(1) not null,
					  UsuarioInsercion varchar(50),
					  FechaInsercion date,
					  UsuarioModificacion varchar(50),
					  FechaModificacion date,
Constraint PK_UsuarioCarrera_CodUsuario_CodFacultad primary key (CodUsuario,CodFacultad),
Constraint FK_UsuarioCarrera_CodUsuario foreign key (CodUsuario) references Usuario (CodUsuario),
Constraint FK_UsuarioCarrera_CodFacultad foreign key (CodFacultad) references Facultad (CodFacultad),
Constraint FK_UsuarioCarrera_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_UsuarioCarrera_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario),
Constraint CK_UsuarioCarrera_Estado check (Estado in('A','I')));

--insert into UsuarioFacultad values ('jo712',1,'A',null,null,null,null);

--11 creamos la tabla TipoLibro
create table TipoLibro (CodTipoLibro int IDENTITY(1,1),
					    NombreTipo varchar(50) not null,
Constraint PK_TipoLibro_CodTipoLibro primary key (CodTipoLibro),
Constraint UK_TipoLibro_NombreTipo unique(NombreTipo)
);

--12 creamos la tabla Idioma
create table Idioma (CodIdioma int IDENTITY(1,1),
					 NombreIdioma varchar(50) not null,
Constraint PK_Idioma_CodIdioma primary key (CodIdioma),
Constraint UK_Idioma_NombreIdioma unique(NombreIdioma)
);

--13 creamos la tabla Editorial
create table Editorial (CodEditorial int IDENTITY(1,1),
					 NombreEditorial varchar(50) not null,
					 PaisEditorial int not null,
					 Direccion varchar(50),
					 Estado char(1) not null,
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_Editorial_CodEditorial primary key (CodEditorial),
Constraint UK_Editorial_NombreEditorial unique(NombreEditorial),
Constraint FK_Editorial_PaisEditorial foreign key (PaisEditorial) references Pais (CodPais),
Constraint CK_Editorial_Estado check (Estado in('A','I')),
Constraint FK_Editorial_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Editorial_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);

--14 creamos la tabla Libro
create table Libro  (CodLibro int IDENTITY(1,1),
					 ISBN varchar(50) not null,
					 TituloLibro varchar(50) not null,
					 CodEditorial int not null,
					 CodTipoLibro int not null,
					 Autor varchar(50) not null,
					 Edicion varchar(50) not null,
					 CodIdioma int not null,
					 Año int not null,					 
					 Estado char(1) not null,
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_Libro_CodLibro primary key (CodLibro),
Constraint FK_Libro_CodEditorial foreign key (CodEditorial) references Editorial (CodEditorial),
Constraint FK_Libro_CodTipoLibro foreign key (CodTipoLibro) references TipoLibro (CodTipoLibro),
Constraint FK_Libro_CodIdioma foreign key (CodIdioma) references Idioma (CodIdioma),
Constraint UK_Libro_ISBN unique(ISBN),
Constraint CK_Libro_Estado check (Estado in('A','I')),
Constraint FK_Libro_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Libro_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);

--15 creamos la tabla Carrera
create table Carrera  (CodCarrera int IDENTITY(1,1),
					 NombreCarrera varchar(50) not null,
					 Promocion int not null,
					 CodFacultad int not null,
					 DesciptcionCarrera varchar(500),			 
					 Estado char(1) not null,
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_Carrera_CodCarrera primary key (CodCarrera),
Constraint FK_Carrera_CodUniversisdad foreign key (CodFacultad) references Facultad (CodFacultad),
Constraint UK_Carrera_NombreCarrera_Promocion unique(NombreCarrera,Promocion),
Constraint CK_Carrera_Estado check (Estado in('A','I')),
Constraint FK_Carrera_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Carrera_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);

--update Usuario set Estado='A', CantidadIntento=0 where CodUsuario='jo712'

--16 creamos la tabla Materia
create table Materia  (CodMateria int IDENTITY(1,1),
					 NombreMateria varchar(500) not null,	
					 ClaveMateria varchar(50) not null,
					 DesciptcionMateria varchar(500),
					 FacultadMateria int,		 
					 Estado char(1) not null,
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_Materia_CodMateria primary key (CodMateria),
Constraint UK_Materia_NombreMateria unique(NombreMateria),
Constraint UK_Materia_ClaveMateria unique(ClaveMateria),
Constraint FK_Materia_FacultadMateria foreign key (FacultadMateria) references Facultad (CodFacultad),
Constraint CK_Materia_Estado check (Estado in('A','I')),
Constraint FK_Materia_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_Materia_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);

--17 creamos la tabla CarreraMateria
create table CarreraMateria  (CodCarrera int not null,
					 CodMateria int not null,
					 NombreCarrera varchar(50) not null,
					 NombreMateria varchar(500) not null,
					 Promocion int not null,	 
					 Estado char(1) not null,
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_CarreraMateria_CodCarrera_CodMateria_Promocion primary key (CodCarrera,CodMateria,Promocion),
Constraint FK_CarreraMateria_CodCarrera foreign key (CodCarrera) references Carrera (CodCarrera),
Constraint FK_CarreraMateria_CodMateria foreign key (CodMateria) references Materia (CodMateria),
Constraint CK_CarreraMateria_Estado check (Estado in('A','I')),
Constraint FK_CarreraMateria_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_CarreraMateria_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);

------------3 entrega--------------
--18 creamos la tabla Semestre
create table Semestre       (CodSemestre int IDENTITY(1,1),
							 Abreviatura varchar(50) not null,
							 Descripcion varchar(50) not null,
Constraint PK_Semestre_CodSemestre primary key (CodSemestre),
Constraint UK_Semestre_Descripcion unique(Descripcion),
Constraint UK_Semestre_Abreviatura unique(Abreviatura)
);

--19 creamos la tabla TipoBibliografia
create table TipoBibliografia(CodTipoBibliografia int IDENTITY(1,1),
							 Abreviatura varchar(50) not null,
							 Descripcion varchar(50) not null,
Constraint PK_TipoBibliografia_CodTipoBibliografia primary key (CodTipoBibliografia),
Constraint UK_TipoBibliografia_Descripcion unique(Descripcion),
Constraint UK_TipoBibliografia_Abreviatura unique(Abreviatura)
);

--20 creamos la tabla MateriaLibro
create table MateriaLibro  (CodSolicitud int IDENTITY(1,1) not null,
					 CodMateria int not null,
					 CodLibro int not null,
					 CodTipoBibliografia int not null,
					 Año int not null,
					 CodSemestre int not null,
					 Descripcion varchar(500),
					 Estado char(1) not null,
					 UsuarioSolicitante varchar(50),
					 UsuarioAutorizador varchar(50),
					 UsuarioInactivador varchar(50),
					 UsuarioInsercion varchar(50),
					 FechaInsercion date,
					 UsuarioModificacion varchar(50),
					 FechaModificacion date,
Constraint PK_MateriaLibro_CodSolicitud_CodMateria_CodLibro_Año_CodSemestre primary key (CodSolicitud,CodMateria,CodLibro,Año,CodSemestre),
Constraint FK_MateriaLibro_CodMateria foreign key (CodMateria) references Materia (CodMateria),
Constraint FK_MateriaLibro_CodLibro foreign key (CodLibro) references Libro (CodLibro),
Constraint FK_MateriaLibro_CodTipoBibliografia foreign key (CodTipoBibliografia) references TipoBibliografia (CodTipoBibliografia),
Constraint FK_MateriaLibro_CodSemestre foreign key (CodSemestre) references Semestre (CodSemestre),
Constraint CK_MateriaLibro_Estado check (Estado in('P','S','A','R','I')),
Constraint FK_MateriaLibro_UsuarioSolicitante foreign key (UsuarioSolicitante) references Usuario (CodUsuario),
Constraint FK_MateriaLibro_UsuarioAutorizador foreign key (UsuarioAutorizador) references Usuario (CodUsuario),
Constraint FK_MateriaLibro_UsuarioInactivador foreign key (UsuarioInactivador) references Usuario (CodUsuario),
Constraint FK_MateriaLibro_UsuarioInsercion foreign key (UsuarioInsercion) references Usuario (CodUsuario),
Constraint FK_MateriaLibro_UsuarioModificacion foreign key (UsuarioModificacion) references Usuario (CodUsuario)
);
