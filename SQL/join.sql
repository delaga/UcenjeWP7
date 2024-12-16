update grupe set predavac='Babo Atif' where sifra=1;
update grupe set predavac='Joža Broz' where sifra=2;
update grupe set predavac='Zagor Tenej' where sifra=3;
update grupe set predavac='Pero Staltika' where sifra=4;

select b.naziv as grupa, a.naziv as smjer, b.predavac
from smjerovi a inner join grupe b
on a.sifra =b.smjer;

select a.naziv, b.naziv as grupa, b.predavac
from smjerovi a left join grupe b
on a.sifra =b.smjer;

select b.naziv as Grupa,
a.naziv as Smjer,
d.ime, d.prezime
from smjerovi a 
inner join grupe b on a.sifra=b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on d.sifra=c.polaznik;

select b.naziv as Grupa,
a.naziv as Smjer,
d.ime, d.prezime
from smjerovi a 
left join grupe b on a.sifra=b.smjer
left join clanovi c on b.sifra=c.grupa
left join polaznici d on d.sifra=c.polaznik;


