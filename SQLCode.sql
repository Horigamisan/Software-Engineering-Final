create database FinalProjectDb

use FinalProjectDb
create table Account
(
	username varchar(10) NOT NULL PRIMARY KEY,
	[password] varchar(30) NOT NULL,
	phonenumber varchar(10),
	homeaddress varchar(40)
)

insert into Account values ('admin', 'admin',NULL, NULL)
insert into Account values ('trongphuc', '070102', '093124584', 'Dong Nai')

create table Teams
(
	TPID varchar(5) NOT NULL PRIMARY KEY,
	team_name varchar(40) NOT NULL,
	abbreviation varchar(6) NOT NULL,
	phone_number_team varchar(11) not null,
	date_create DATE default GETDATE(),
	state_check varchar(10) default 'checking'
)

insert into Teams values ('TP001', 'Ton Duc Thang UNI', 'TDTU','0931276760','2022-12-05', 'confirmed');
insert into Teams values ('TP002', 'Havard UNI', 'HVU','0931276766','2022-12-05', 'confirmed');
insert into Teams values ('TP003', 'Dong Nai UNI', 'DNU','0931276760','2022-12-05', 'confirmed');
insert into Teams values ('TP004', 'RMIT UNI', 'RMT','0931276766','2022-12-05', 'confirmed');
insert into Teams values ('TP005', 'Nguyen Tat Thanh UNI', 'NTTU','0931276760','2022-12-05', 'confirmed');
insert into Teams values ('TP006', 'Cambride UNI', 'CBU','0931276766','2022-12-05', 'confirmed');

create table Tournament
(
	TMID varchar(5) NOT NULL PRIMARY KEY,
	team_name_one varchar(40) NOT NULL,
	team_name_two varchar(40) NOT NULL,
	score_one int default 0,
	score_two int default 0,
	date_start DATE default GETDATE(),
	is_finished varchar(10) default 'false',
	match_state varchar(10) default 'Home'
)

insert into Tournament values ('TM001', 'Ton Duc Thang UNI', 'Havard UNI','0','0', '2022-12-07', 'false','Home');
insert into Tournament values ('TM002', 'Dong Nai UNI', 'Nguyen Tat Thanh UNI','0','0', '2022-12-07', 'false','Home');
insert into Tournament values ('TM003', 'RMIT UNI', 'Cambride UNI','0','0', '2022-12-07', 'false','Home');

create table Leaderboard
(
	LBID varchar(5) NOT NULL PRIMARY KEY,
	team_name varchar(40) NOT NULL,
	score_home int default 0,
	score_away int default 0,
	sum_score int default 0
)

insert into Leaderboard values ('LB001', 'Ton Duc Thang UNI', 5, 3, 8);
insert into Leaderboard values ('LB002', 'Dong Nai UNI', 6, 1, 7);
insert into Leaderboard values ('LB003', 'RMIT UNI', 2, 3, 5);
insert into Leaderboard values ('LB004', 'Nguyen Tat Thanh UNI', 3, 1, 4);
insert into Leaderboard values ('LB005', 'Cambride UNI', 2, 2, 4);
insert into Leaderboard values ('LB006', 'Havard UNI', 1, 1, 2);
