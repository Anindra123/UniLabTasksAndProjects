create table LOGIN_TBL
(
USERNAME VARCHAR(50) NOT NULL,
PASS NVARCHAR(50) NOT NULL
);

INSERT INTO LOGIN_TBL VALUES ('abc@gmail.com', '123');

select * from login_tbl