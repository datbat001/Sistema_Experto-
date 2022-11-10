CREATE DATABASE [Habitos_Estudio]

create table objetos(
	[Id] [int] not null IDENTITY(1,1) primary key,
	[Nombre] [varchar](50) not null, 
	[Descripcion] [varchar](max) null,
	[Imagen] [varchar](max) null
);

insert into objetos (Nombre,Descripcion,Imagen)
values ('habito1','test del habito 1','imagen.jpg');

select * from objetos;