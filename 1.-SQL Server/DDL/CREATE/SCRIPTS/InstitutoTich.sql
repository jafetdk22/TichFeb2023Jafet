create table Estados(id int primary key not null,nombre varchar(100) null)
create table EstatusAlumnos(id smallint primary key not null ,clave char(10) not null,nombre varchar(100) not null)
create table CatCursos(id smallint primary key identity , clave varchar(15) not null , nombre varchar(50) not null,descripcion varchar(1000) null,horas tinyint not null,idPreRequisito smallint null,activo bit not null)
create table Cursos (id smallint primary key identity,idCatCurso smallint null,fechaInicio date null, fechatermino date null,activo bit null)
create table Alumnos(id int primary key identity , nombre varchar(60) not null,primerApellido varchar(50) not null,segundoApellido varchar(50) null,correo varchar(80) not null,telefono nchar(10) not null ,fechaNacimiento date not null,curp char(18) not null,sueldo decimal(9,2) null,idEstadoOrigen int not null,idEstatus smallint not null)

create table Instructores(id smallint primary key identity, nombre varchar(60) , primerApellido varchar(50) not null, segundoApellido varchar(50) null,correo varchar(80) not null,telefono nchar(10) not null,fechaNacimiento date not null,rfc char(13) not null,curp char(18) not null,cuotaHora decimal(9,2) not null,activo bit not null) 
create table CursoAlumnos(id int primary key identity,idCurso smallint not null,idAlumno int not null,fechaInscripcion date not null ,fechaBaja date null,calificacion tinyint null)

create table CursosInstructores(id int primary key identity,idcurso smallint not null,idInstructor smallint not null,fechaContratacion date null)














