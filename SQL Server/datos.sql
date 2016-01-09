use Proyecto_GPI_GOLF;
go

insert into Pantalla values (upper('frm_menu_pri'),'Pantalla-Menu Principal');
insert into Pantalla values (upper('frm_usuario_per'),'Pantalla-Usuario-Permiso');

insert into Pantalla values (upper('frm_persona_agr'),'Pantalla-Persona-Agregar');
insert into Pantalla values (upper('frm_persona_eli'),'Pantalla-Persona-Eliminar');
insert into Pantalla values (upper('frm_persona_mod'),'Pantalla-Persona-Modificar');
insert into Pantalla values (upper('frm_persona_con'),'Pantalla-Persona-Consultar');


insert into Pantalla values ('FRM_EDITORIAL_ELI','Pantalla-Editorial-Eliminar');
insert into Pantalla values ('FRM_EDITORIAL_MOD','Pantalla-Editorial-Modificar');
insert into Pantalla values ('FRM_EDITORIAL_CON','Pantalla-Editorial-Consultar');
insert into Pantalla values ('FRM_EDITORIAL_AGR','Pantalla-Editorial-Agregar');

insert into Pantalla values ('FRM_LIBRO_ELI','Pantalla-Libro-Eliminar');
insert into Pantalla values ('FRM_LIBRO_MOD','Pantalla-Libro-Modificar');
insert into Pantalla values ('FRM_LIBRO_CON','Pantalla-Libro-Consultar');
insert into Pantalla values ('FRM_LIBRO_AGR','Pantalla-Libro-Agregar');

insert into Pantalla values ('FRM_MATERIA_ELI','Pantalla-Materia-Eliminar');
insert into Pantalla values ('FRM_MATERIA_MOD','Pantalla-Materia-Modificar');
insert into Pantalla values ('FRM_MATERIA_CON','Pantalla-Materia-Consultar');
insert into Pantalla values ('FRM_MATERIA_AGR','Pantalla-Materia-Agregar');

insert into Pantalla values ('FRM_CARRERA_ELI','Pantalla-Carrera-Eliminar');
insert into Pantalla values ('FRM_CARRERA_MOD','Pantalla-Carrera-Modificar');
insert into Pantalla values ('FRM_CARRERA_CON','Pantalla-Carrera-Consultar');
insert into Pantalla values ('FRM_CARRERA_AGR','Pantalla-Carrera-Agregar');

insert into Pantalla values ('FRM_BIBLIOGRAFIA_SOL','Pantalla-Bibliograf�a-Solicitar');
insert into Pantalla values ('FRM_BIBLIOGRAFIA_CON','Pantalla-Bibliograf�a-Consultar');
insert into Pantalla values ('FRM_BIBLIOGRAFIA_AUT','Pantalla-Bibliograf�a-Autorizar');

insert into Facultad values ('CIENCIAS JUR�DICAS, POL�TICAS Y DE LA COMUNICACI�N');
insert into Facultad values ('CIENCIAS Y TECNOLOG�A');
insert into Facultad values ('CIENCIAS ECON�MICAS Y EMPRESARIALES');
insert into Facultad values ('CIENCIAS DE LA SALUD');


insert into Semestre values (upper('OT'),upper('OTO�O'));
insert into Semestre values (upper('PR'),upper('Primavera'));
insert into Semestre values (upper('VE'),upper('Verano'));

insert into TipoBibliografia values (upper('BA'),upper('BASICA'));
insert into TipoBibliografia values (upper('cO'),upper('COMPLEMENTARIA'));

insert into TipoDocumento values ('CEDULA DE IDENTIDAD','CI');
insert into TipoDocumento values ('DNI','DN');
insert into TipoDocumento values ('PASAPORTE','PA');
insert into TipoDocumento values ('DOCUMENTO BRASILE�O','DB');

insert into TipoPersona values ('Profesor');
insert into TipoPersona values ('Decano');

--para que pueda ingresar el Admin, OJO una vez creado ya no se puede borrar este usuario
insert into Usuario values ('Admin',dbo.fu_encriptar_contrasenia(1992),'A',0,'05/01/2016','Admin','05/01/2016','Admin','05/01/2016');

insert into UsuarioPantalla values ('Admin','FRM_MENU_PRI','A','Admin','05/01/2016','Admin','05/01/2016');
insert into UsuarioPantalla values ('Admin',upper('frm_usuario_per'),'A','Admin','05/01/2016','Admin','05/01/2016');