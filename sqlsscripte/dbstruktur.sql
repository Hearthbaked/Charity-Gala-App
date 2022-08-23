create database CharityGalaApp;

create table spenden
( idSpenden int not null auto_increment primary key,
  spender varchar(50) not null, betrag double not null
); 

Select * from spenden Order By idSpenden DESC LIMIT 0,5;