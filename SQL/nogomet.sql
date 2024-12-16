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
	sifra int not null primary key identity(1,1),
	datum date not null,
	vrijeme time,
	lokacija varchar(100),
	stadion varchar(100),
	domaciKlub int not null references klubovi(sifra),
	gostujuciKlub int not null references klubovi(sifra) 
);

create table igraci (
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	datumRodjenja date,
	pozicija varchar(50),
	brojDresa int,
	klub int not null references klubovi(sifra)
);

create table treneri (
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	nacionalnost varchar(50),
	klub int not null references klubovi(sifra),
	iskustvo int
);