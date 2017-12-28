create database school;

CREATE TABLE  school.user_status(
status_id Int not null auto_increment,
status_mean varchar(30) not null,
primary key (status_id)
);

create table school.authorization
(
user_id Int not null auto_increment,
user_login varchar(65)not null,
user_password varchar(65)not null,
user_status_id Int not null default 2,
foreign key (user_status_id)
references school.user_status(status_id),
primary key(user_id)
 );
 CREATE TABLE school.user_profile
(
user_profile_id int not null auto_increment,
profile_user_id int not null,

profile_user_secondname varchar (65) not null,
profile_user_firstname varchar (65) not null,
profile_user_middlename varchar (65) not null,
profile_user_telephone int not null,
foreign key (user_profile_id)
references school.authorization(user_id),

primary key(user_profile_id) 

);
CREATE TABLE school.user_work
(
user_work_id int not null auto_increment,
work_user_id int not null,
work_user_secondname varchar (65) not null,
work_user_firstname varchar (65) not null,
work_direction_user varchar (65) not null,
work_user_year_experience varchar (65) not null,
work_user_prise varchar (65) not null,
foreign key (user_work_id)
references school.authorization(user_id),
primary key(user_work_id) 
);
