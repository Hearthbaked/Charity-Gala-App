select idSpenden,spender from spenden;
insert into spenden(spender, betrag) values ('Ingeborg','10,00');
insert into spenden(spender, betrag) values ('Daniel','15,50');

Select sum (betrag) from spenden;