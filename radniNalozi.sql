use master;
go
drop database if exists RadniNalozi;
go
create database RadniNalozi collate Croatian_CI_AS;
go
use RadniNalozi;
go

create table djelatnici (
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(50),
	email varchar(80),
	brutto2Placa decimal(18,2)
);

create table poslovi (
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	nazivPosla varchar(50),
	vrijednost decimal(18,2)
	);

create table klijenti(
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	Naziv varchar(50) not null,
	oib char(11),
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
	vrijemeZavrsetka datetime,
	radnihSati decimal (18,2) not null,
	napomena text
);

create table vrstaTroskova(
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	naziv varchar(100),
);

create table troskovi(
	sifra int not null PRIMARY KEY IDENTITY(1,1),
	naziv varchar(100),
	vrsta int not null references vrstaTroskova(sifra),
	djelo int not null references djelo(sifra),
	kolicina decimal(18,2),
	vrijednost decimal(18,2)
);

insert into djelatnici(ime,prezime) values
('Rade','Janković'),('Dino','Dizdarević'),('Milan','Drača'),('Mirza','Delagić');

insert into klijenti(naziv,oib,adresa,email,odgovornaOsoba) values
('Murder Inc.','98765432155','Tamo nekud bb','uf@uf.com','Vrlo neodgovorna osoba'),
('Lopuže d.d.','12345678901','Prva desno 10a','mail@mail.hr','Neki HDZovac');

insert into poslovi(nazivPosla,vrijednost) values
('Postavljanje nosača',99.99),
('Programiranje HomeAssistant',249.99);

insert into djelo(djelatnik,klijent,posao,vrijemePocetka,vrijemeZavrsetka,radnihSati,napomena) values
(1,1,1,'2024-10-02 08:00:00','2024-12-03 10:00:00',40,'Nosač postavljen po uputi ISP-a');

insert into vrstaTroskova(naziv) values
('Cestarina'),
('Sitni potrošni materijal'),
('Kabliranje');


insert into troskovi(naziv,vrsta,djelo,kolicina,vrijednost) values
('Osijek-SB',1,1,1,3.60),
('UTP CAt6',3,1,50,1.22),
('Izolirka',2,1,3,1.99);