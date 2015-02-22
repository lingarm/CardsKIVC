USE CardsKIVC

CREATE TABLE building (
id int not null identity (1,1) primary key,
building int,
)

CREATE TABLE RAM (
id int not null identity (1,1) primary key,
RAM varchar(50),
)

CREATE TABLE HDD (
id int not null identity (1,1) primary key,
HDD varchar(50),
)

CREATE TABLE CD_DVD (
id int not null identity (1,1) primary key,
CD_DVD varchar(50),
)

CREATE TABLE printer (
id int not null identity (1,1) primary key,
printer varchar(50),
)

CREATE TABLE OC (
id int not null identity (1,1) primary key,
OC varchar (50),
)

CREATE TABLE antivirus (
id int not null identity (1,1) primary key,
antivirus varchar(50),
)

CREATE TABLE office (
id int not null identity (1,1) primary key,
office varchar(50),
)

CREATE TABLE ext_program (
id int not null identity (1,1) primary key,
ext_program varchar(50),
)
DROP TABLE work_place

CREATE TABLE work_place (
id int not null identity (1,1) primary key,
username varchar(50),
building int foreign key (building) references building(id) on update cascade,
cabinet int,
comp_inv int,
CPU varchar(50),
RAM int foreign key (RAM) references RAM(id) on update cascade,
HDD int foreign key (HDD) references HDD(id) on update cascade,
CD_DVD int foreign key (CD_DVD) references CD_DVD(id) on update cascade,
ext_board varchar(50),
monitor varchar(50),
monitor_inv int,
printer1 int foreign key (printer1) references printer(id),
printer1_inv int,
printer2 int foreign key (printer2) references printer(id),
printer2_inv int,
UPC varchar(50),
UPC_inv int,
ext_unit1 varchar(50),
ext_unit1_inv int,
ext_unit2 varchar(50),
ext_unit2_inv int,
ext_unit3 varchar(50),
ext_unit3_inv int,

OC int foreign key (OC) references OC(id) on update cascade,
antivirus int foreign key (antivirus) references antivirus(id) on update cascade,
office int foreign key (office) references office(id) on update cascade,
skype varchar(50),
archiver varchar(50),
PDF varchar(50),
ext_program1 int foreign key (ext_program1) references ext_program(id),
ext_program2 int foreign key (ext_program2) references ext_program(id),
ext_program3 int foreign key (ext_program3) references ext_program(id),
ext_program4 int foreign key (ext_program4) references ext_program(id),
ext_info text,
)

INSERT INTO RAM (RAM) VALUES ('128 MB')
INSERT INTO RAM (RAM) VALUES ('256 MB')
INSERT INTO RAM (RAM) VALUES ('512 MB')
INSERT INTO RAM (RAM) VALUES ('1 GB')
INSERT INTO RAM (RAM) VALUES ('2 GB')
INSERT INTO RAM (RAM) VALUES ('4 GB')
INSERT INTO RAM (RAM) VALUES ('8 GB')

DELETE FROM RAM WHERE id = 4

select * FROM RAM

CREATE TABLE test (
id int not null identity (1,1) primary key,
t1 int foreign key (t1) references RAM(id) on update cascade,
t2 int foreign key (t2) references RAM(id) on update no action,
)

INSERT INTO test (t1, t2) VALUES (1, 2)
INSERT INTO test (t1, t2) VALUES (3, 4)

SELECT * FROM test

SELECT t.id, r.ram, r.ram
FROM RAM as r, test as t
WHERE r.id = t.t3

UPDATE test SET t3 = 1 WHERE id = 1

UPDATE RAM SET RAM = 700 WHERE id = 7
UPDATE RAM SET RAM = 111 WHERE id = 4
UPDATE RAM SET RAM = 444 WHERE id = 5
update RAM set RAM = 555 where id = 5

ALTER TABLE test ADD t3 INT foreign key (t3) references RAM(id)
ALTER TABLE test ADD t5 INT foreign key (t5) references RAM(id)


UPDATE test SET t5 = 12 where id = 2

DELETE FROM RAM WHERE id = 12