use master
drop database distributorManage
create database distributorManage
use distributorManage

create table account (
	username nvarchar(30) ,
	pass	nvarchar(30),
	accType nvarchar(30)
)

insert into account values ('SmartKelvin0212','hihi','admin'),
						   ('admin','admin','admin'),
						   (N'Dũng Lương','mmb','admin'),
						   ('helen','123','agent'),
						   ('Main che mắt','allgirlsaremine','agent'),
						   (N'Anh Hai Ếch Tiền Giang','123','agent');

SELECT username as Account, CONVERT(VARCHAR(32), HashBytes('MD5', pass), 2)as SerializedPass from account