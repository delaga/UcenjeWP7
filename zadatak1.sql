use master;
go
drop database if exists RadniNalozi;
go
create database RadniNalozi;
go
use RadniNalozi;
go

create table djelatnik (
	sifra int,
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(50),
	email varchar(80)
);

create table posao (
	sifra int,
	nazivPosla varchar(50),
	datum date,
	izvrsen bit,
	djelatnik int
);