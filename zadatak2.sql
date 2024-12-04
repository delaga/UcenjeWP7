use master;
go
drop database if exists RadniNalozi;
go
create database RadniNalozi;
go
use RadniNalozi;
go

create table djelatnici (
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(50),
	email varchar(80)
);

create table poslovi (
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	nazivPosla varchar(50),
	vrijednost decimal(18,2)
	);

create table klijenti(
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	Naziv varchar(50) not null,
	oib varchar(11),
	adresa varchar (100),
	email varchar (100),
	odgovornaOsoba varchar(100)
);

create table djelo (
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	djelatnik int not null references djelatnici(sifra),
	klijent int not null references klijenti(sifra),
	posao int not null references poslovi(sifra),
	vrijemePocetka datetime,
	zapocet bit,
	zavrsen bit,
	vrijemeZavrsetka datetime,
	radnihSati decimal (18,2) not null,
);

create table troskovi(
	sifra int not null PRIMARY KEY IDENTITY(1,1),

);