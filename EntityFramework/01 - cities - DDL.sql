--use cities;

drop table if exists cities;
drop table if exists countries;

create table countries
(
	country_code char(2),
	country_name varchar(100) not null,
	primary key (country_code)
);

create table cities
(
	city_id int identity,
	city_name varchar (100),
	country_code char(2) not null,
	primary key (city_id)
);

alter table cities
	add constraint FK_cities
	foreign key (country_code)
	references countries(country_code);

insert into countries
(country_code,country_name)
values
('FR','France'),('RU','Russian Federation'),('US','United States');

insert into cities
(city_name, country_code)
values
('Paris','FR'),
('Lyon','FR'),
('Toulouse','FR'),
('Marseille','FR'),
('Mulhouse','FR'),
('Boston','US'),
('Los Angeles','US'),
('Washington','US'),
('New York','US'),
('Moscou','RU'),
('Saint-Pétersbourg','RU');