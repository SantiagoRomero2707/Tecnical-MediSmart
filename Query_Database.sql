CREATE DATABASE Tecnical_MediSmart;
USE Tecnical_MediSmart;
CREATE TABLE dbo.user_medical(
	id_user int identity(1,1) not null primary key,
	first_name varchar(100) not null,
	first_last_name varchar(10) not null,
	second_last_name varchar(10) not null,
	address_user char(20) not null,
	birth date not null,
	rol varchar(10)
)

select * from dbo.user_medical