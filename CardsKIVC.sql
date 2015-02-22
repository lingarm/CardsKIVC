USE CardsKIVC

CREATE TABLE building (
id int not null identity (1,1) primary key,
building int,
)

CREATE TABLE RAM_type (
id int not null identity (1,1) primary key,
RAM_type varchar(50),
)

CREATE TABLE RAM_value (
id int not null identity (1,1) primary key,
RAM_value varchar(50),
)

CREATE TABLE HDD_interface (
id int not null identity (1,1) primary key,
HDD_interface varchar(50),
)

CREATE TABLE videocard_type (
id int not null identity (1,1) primary key,
videocard_type varchar(50),
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

CREATE TABLE work_place (
id int not null identity (1,1) primary key,
username varchar(50),
building int foreign key (building) references building(id) on update cascade,
cabinet int,
comp_inv int,
CPU varchar(50),
RAM_value1 int foreign key (RAM_value1) references RAM_value(id),
RAM_type1 int foreign key (RAM_type1) references RAM_type(id),
RAM_value2 int foreign key (RAM_value2) references RAM_value(id),
RAM_type2 int foreign key (RAM_type2) references RAM_type(id),
RAM_value3 int foreign key (RAM_value3) references RAM_value(id),
RAM_type3 int foreign key (RAM_type3) references RAM_type(id),
RAM_value4 int foreign key (RAM_value4) references RAM_value(id),
RAM_type4 int foreign key (RAM_type4) references RAM_type(id),
HDD_value1 varchar(50),
HDD_interface1 int foreign key (HDD_interface1) references HDD_interface(id),
HDD_value2 varchar(50),
HDD_interface2 int foreign key (HDD_interface2) references HDD_interface(id),
HDD_value3 varchar(50),
HDD_interface3 int foreign key (HDD_interface3) references HDD_interface(id),
HDD_value4 varchar(50),
HDD_interface4 int foreign key (HDD_interface4) references HDD_interface(id),
CD_DVD1 int foreign key (CD_DVD1) references CD_DVD(id),
CD_DVD2 int foreign key (CD_DVD2) references CD_DVD(id),
ext_board_video varchar(50),
ext_board_video_type int foreign key (ext_board_video_type) references videocard_type(id) on update cascade,
ext_board_LAN1 varchar(50),
ext_board_LAN2 varchar(50),
ext_board_audio varchar(50),
ext_board_FM varchar(50),
ext_board_TV varchar(50),
monitor1 varchar(50),
monitor_inv1 int,
monitor2 varchar(50),
monitor_inv2 int,
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