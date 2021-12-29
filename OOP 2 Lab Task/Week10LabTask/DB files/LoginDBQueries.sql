create table LOGIN_TBL(
NAME varchar(100) not null,
EMAIL varchar(50) not null,
PASSWORD nvarchar(8) not null
)
insert into LOGIN_TBL 
(NAME,EMAIL,PASSWORD)
values ('Bivas','bivasdas911@gmail.com','1234')

insert into LOGIN_TBL 
(NAME,EMAIL,PASSWORD)
values ('20-41848-1','20-41848-1@student.aiub.edu','4567')

insert into LOGIN_TBL 
(NAME,EMAIL,PASSWORD)
values ('abc','abc@yahoo.com','9999')


select * from LOGIN_TBL where lower(name) = 'bivas' and
email  = 'bivas@mail.com' and PASSWORD = '5555'