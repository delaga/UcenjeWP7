select * from autor order by prezime asc,ime desc;

select prezime,ime from autor order by 1 asc,2 desc;

select top 10 percent * from autor;

select top 10 * from mjesto;

select top 10 * into nova from mjesto;

select * from nova;

drop table nova;

select * from autor;

insert into autor(sifra,ime,prezime,datumrodenja) values (4,'Mirza','Delagić','1975-09-18 16:50:00');


select * from katalog;
select * from katalog where naslov like '%ljubav%'and sifra in (2541,2660,2664,2938);

select count(*) from izdavac where naziv like '%d.o.o.';

select count(*) from izdavac where naziv like '%d.o.o.' or naziv like '%doo';
select top 20 * from izdavac;

select * from izdavac where naziv like '%d.%o%o%' or naziv like '%d%o%o.%';



