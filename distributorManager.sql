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
						   (N'Main che mắt','allgirlsaremine','agent'),
						   (N'Anh Hai Ếch Tiền Giang','123','agent');

SELECT username as Account, CONVERT(VARCHAR(32), HashBytes('MD5', pass), 2)as SerializedPass from account

create table CurrentGoods (
	goodID nvarchar(30) ,
	goodName nvarchar(30),
	Quantity int,
	Price int
)

insert into CurrentGoods values ('I0001','Iphone X', 12, 10000000),
								('I0002','Iphone Xs Max', 23, 15000000),
								('I0003','ASUS ROG Phone 7', 5, 35000000);
select goodID, goodName, Quantity, price as Price_per_item from CurrentGoods 

create table ImportedGoods(
	goodID nvarchar(30),
	goodName nvarchar(30),
	Quantity int,
	Price int,
	added_date date not null default CURRENT_TIMESTAMP
)

create table GoodstoImport(
	goodID nvarchar(30),
	goodName nvarchar(30),
	Quantity int,
	Price int,
)

insert into GoodstoImport values ('GI0001','Samsung Galaxy S23', 5, 26000000),
								('GI0002','Ipad Pro 2018', 15, 15000000),
								('GI0003','Samsung Note 20', 7, 23000000);	 

create table Detail_Ticket(
	ticketID nvarchar(30),
	goodID nvarchar(30),
	goodName nvarchar(30),
	Quantity int,
	Price int,
	added_date date not null default CURRENT_TIMESTAMP
)

select goodId, goodName, Quantity, Price as Price_per_item from CurrentGoods
select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Price / Item' from CurrentGoods
select goodId as 'Good ID', goodName as 'Good Name', Quantity, Price as 'Price / Item', added_date from ImportedGoods

select * from GoodstoImport
delete from GoodstoImport

select * from ImportedGoods order by goodID asc

Select Price from GoodstoImport

insert into ImportedGoods values ('I0004','Samsung Galaxy S23','12','312000000','2023/11/01')
select * from ImportedGoods where goodID = N'I0001'
