use svastara;


select c.redniBroj, a.dugiNaziv, b.cijena, b.kolicina,
b.cijena * b.kolicina as vrijednost
from Artikli a
inner join ArtikliNaPrimci b on a.sifra=b.artikl
inner join Primke c on c.sifra=b.primka
where c.redniBroj='1/2008';


select sum (b.cijena * b.kolicina) as vrijednost
from Artikli a
inner join ArtikliNaPrimci b on a.sifra=b.artikl
inner join Primke c on c.sifra=b.primka
where c.redniBroj='1/2008';

select c.redniBroj, d.naziv, sum (b.cijena * b.kolicina) as vrijednost
from Artikli a
inner join ArtikliNaPrimci b on a.sifra=b.artikl
inner join Primke c on c.sifra=b.primka
inner join Dobavljaci d on c.dobavljac=d.sifra
group by c.redniBroj, d.naziv
having sum (b.cijena * b.kolicina)>13000000
order by 2 desc;

select COUNT(*) from Artikli;

select distinct Artikl from ArtikliNaPrimci;

select * from Artikli where sifra not in(
select distinct Artikl from ArtikliNaPrimci
);