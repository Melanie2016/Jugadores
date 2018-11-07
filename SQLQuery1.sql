use jugadoress;


create table equipo (
	id int not null identity,
	nombre varchar(40) not null,
	primary key (id)
);


create table jugador(
	id int not null identity,
	nombre varchar(50) ,
	apellido varchar(50),
	edad int ,
	posicion varchar(50),
	idEquipo int
	primary key (id),
	foreign key (idEquipo) references equipo(id)
);


drop table jugador;
-----------------------------------


SET IDENTITY_INSERT [dbo].[equipo] ON
		insert into equipo (id, nombre) values (1, 'Boca'),(2, 'River');
insert into equipo (id, nombre) values (3, 'Racing'),(4, 'SanLorenzo');
SET IDENTITY_INSERT [dbo].[equipo] OFF
-------------------------------------

SELECT * FROM jugador ;

SELECT * FROM equipo ;
