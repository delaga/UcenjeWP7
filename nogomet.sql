use master;
go
drop database if exists Nogomet;
go
create database Nogomet;
go
use Nogomet;
go

create table klubovi(
	sifra int not null primary key identity(1,1),
	naziv varchar(100) not null,
	osnovan date,
	stadion varchar (100),
	predsjednik varchar(100),
	drzava varchar(50),
	liga varchar(50)
);

create table utakmice(
	
);