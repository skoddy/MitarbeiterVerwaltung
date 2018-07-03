drop database if exists mitarbeiter;
create database mitarbeiter;
use mitarbeiter;

create table mitarbeiter (
	Id int primary key auto_increment,
	Vorname varchar(100),
    Nachname varchar(100),
    Gebdat date,
    Arbeitszeit_tag int,
    Urlaubszeit int
    
);

create table einsatz (
	Id int primary key auto_increment,
    Ma_id int,
    Datum date,
    Von time,
    Bis time,
    foreign key (Ma_id) references mitarbeiter(Id)
);

create table fehlgrund (
	Id int primary key auto_increment,
    Grund varchar(100)
);

create table fehlzeit (
	Id int primary key auto_increment,
    Ma_id int,
    Von date,
    Bis date,
    Grund_id int,
    Fehltage int,
    foreign key (Ma_id) references mitarbeiter(Id),
    foreign key (Grund_id) references fehlgrund(Id)
);

insert into fehlgrund values(null, 'Krank');
insert into fehlgrund values(null, 'Urlaub');
insert into fehlgrund values(null, 'Kein Bock');