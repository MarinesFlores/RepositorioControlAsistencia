create database planilla;
go

use planilla ;
go


create table empleado(
	id int identity(1,1) not null primary key,
	ci varchar(15),
	nombre varchar(30),
	APaterno varchar(30),
	AMaterno varchar(30),
	fechaNac datetime,
	Genero char,
	estadoCivil varchar(30),
	profesion varchar (50),
	nacionalidad varchar (50),
	telefono1 varchar (10),
	telefenoInterno varchar (12),
	direccion varchar (50),
	nroAsegurado varchar (50),
	NUA varchar (30),
	activo int
);

create table tipoContrato(
	id int identity(1,1) not null primary key,
	descripcion varchar(150),
	activo int,
);

create table turno(
	id int identity(1,1) not null primary key,
	descricion varchar(150),
);

create table horario(
	id int identity(1,1) not null primary key,
	dia varchar(15),
	horaEntrada datetime,
	horaSalida datetime,
	idTurno int,
	
	foreign key(idTurno) references turno(id)
);

create table cronograma(
	id int identity(1,1) not null primary key,
	descripcion varchar(150),
	fechaIni datetime,
	fechaFin datetime,
);

create table cronogramaTurno(
	id int identity(1,1) not null primary key,
	fecha datetime,
	activo int,
	idCronograma int,
	idTurno int,
	
	foreign key(idCronograma) references cronograma(id),
	foreign key(idTurno) references turno(id)
);

create table asistencia(
	id int identity(1,1) not null primary key,
	hora datetime,
	evento int,
	tipo int,
	idEmpleado int,
	
	foreign key(idEmpleado) references empleado(id)
);

create table contrato(
	id int 	identity(1,1) not null primary key,
	fecha datetime,
	fechaIni datetime,
	vigente int,
	idEmpleado int,
	
	foreign key(idEmpleado) references empleado(id)
);


create table feriado(
	id int identity(1,1) not null primary key,
	descripcion varchar(150),
	fecha datetime ,
);

create table sucursal(
	id int identity(1,1) not null primary key,
	descripcion varchar(150),
	activo int
);

create table sucursalFeriado(
	id int identity(1,1) not null primary key,
	idSucursal int,
	idFeriado int,
	
	foreign key(idSucursal) references sucursal(id),
	foreign key(idFeriado) references feriado(id)
);




create table adendas(
	id int identity(1,1) not null primary key,
	fechaFin datetime,
	salario float, 
	fecha datetime,
	idContrato int,
	idTipoContrato int,
	idCronograma int, 
	idSucursal int,	
	activo int,
	
	foreign key(idContrato) references contrato(id),
	foreign key(idCronograma) references cronograma(id),
	foreign key(idTipoCOntrato) references tipoContrato(id),
	foreign key(idSucursal) references sucursal(id)
);






