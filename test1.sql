-- Provjeri postoji li baza podataka i ako postoji, obriši je
use master;
go
drop database if exists test1;
go
create database test1;
go
use Test1;
go

-- Kreiraj tablicu smjerovi
CREATE TABLE smjerovi (
    sifra INT PRIMARY KEY,
    naziv VARCHAR(50) NOT NULL,
    trajanje INT,
    cijena DECIMAL(18, 2),
    vaucer BIT,
    izvodiseod DATETIME
);

-- Kreiraj tablicu polaznici
CREATE TABLE polaznici (
    sifra INT PRIMARY KEY,
    ime VARCHAR(50) NOT NULL,
    prezime VARCHAR(50) NOT NULL,
    oib CHAR(11) UNIQUE,
    email VARCHAR(100)
);

-- Kreiraj tablicu grupe
CREATE TABLE grupe (
    sifra INT PRIMARY KEY,
    naziv VARCHAR(20) NOT NULL,
    smjer INT,
    predavac VARCHAR(50),
    FOREIGN KEY (smjer) REFERENCES smjerovi(sifra)
);

-- Kreiraj tablicu clanovi sa samo FOREIGN KEY-ovima
CREATE TABLE clanovi (
	grupa INT,
    polaznik INT,
    FOREIGN KEY (grupa) REFERENCES grupe(sifra),
    FOREIGN KEY (polaznik) REFERENCES polaznici(sifra)
);
GO
