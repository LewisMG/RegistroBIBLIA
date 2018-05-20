CREATE DATABASE BibliaLibros
GO	
USE BibliaLibros
Go
CREATE TABLE Libros
(
	TipoId int primary key identity(1,1),
	LibroId int,
	Descripcion varchar(40),
	Siglas varchar(20)
);