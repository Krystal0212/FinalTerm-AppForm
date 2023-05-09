use master
drop database distributorManage
create database distributorManage
use distributorManage

create table account (
	username nvarchar(30) primary key ,
	pass	nvarchar(100),
	accType nvarchar(30),
	loginID nvarchar(30)
)

insert into account values (N'SmartKelvin0212','hihi','admin',''),
						   (N'admin','admin','admin',''),
						   (N'Dũng Lương','mmb','admin',''),
						   (N'mmb','mmb','agent',''),
						   (N'agent','$2a$11$AuRNoJhvdW/.ZUOYlK4keujYrciuIe0K6sFoypItoNYdmlIQPVweq','agent',N'R0001'),						   
						   (N'Helen','$2a$11$usWJdyUogIDVAHs1v5oSK.zch3HL25yUDkpDa5E7OTtMOzYkeFoSC','agent',''),
						   (N'sk212','$2a$11$4Wzwpt6yI5q70ODiuJmeWuxydhNn2.XGmN.cqoRhlJ23GYf0q6tn2','agent','');

--SELECT username as Account, pass as SerializedPass from account

--select * from account

create table CurrentGoods (
	goodID nvarchar(30) primary key,
	goodName nvarchar(30),
	quantity int,
	price int
)
delete from CurrentGoods
select * from CurrentGoods
insert into CurrentGoods values ('I0001','Iphone X', 0, 1000),
								('I0002','Iphone Xs Max', 23, 1500),
								('I0003','Ipad Pro 2019', 15, 1600),
								('I0004','Ipad Pro 2021', 15, 1700),
								('I0005','Samsung J7 Prime', 15, 2000),
								('I0006','Apple Watch 2020', 15, 1200),
								('I0007','Apple Watch Pro', 15, 1400),
								('I0008','Oppo Reno 8', 15, 1700),
								('I0009','Oppo Reno 7', 15, 1600),
								('I0010','Samsung Note 20', 7, 2300);
--select goodID, goodName, Quantity, price as Price_per_item from CurrentGoods 

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

insert into GoodstoImport values ('GI0001','Samsung Galaxy S23', 5, 2600),
								('GI0002','Ipad Pro 2018', 15, 1500),
								('GI0003','Ipad Pro 2019', 15, 1600),
								('GI0004','Ipad Pro 2021', 15, 1700),
								('GI0005','Samsung J7 Prime', 15, 2000),
								('GI0006','Apple Watch 2020', 15, 1200),
								('GI0007','Apple Watch Pro', 15, 1400),
								('GI0008','Oppo Reno 8', 15, 1700),
								('GI0009','Oppo Reno 7', 15, 1600),
								('GI0010','Samsung Note 20', 7, 2300),
								('GI0011','Iphone X', 7, 2300);
select * from GoodstoImport
delete from GoodstoImport
create table Detail_Ticket(
	ticketID nvarchar(30),
	goodID nvarchar(30),
	goodName nvarchar(30),
	Quantity int,
	Price int,
	added_date date not null default CURRENT_TIMESTAMP
)

Create table Ticket(
	ticketID nvarchar(30),
	username nvarchar(30)
)
select * from Detail_Ticket
select * from ticket
Create table Reseller(
	resellerID nvarchar(30) primary key,
	username nvarchar(30),
	displayname nvarchar(30),
	email nvarchar(30)
)

create table Cart(
	cartNumber nvarchar(30) primary key,
	orderID nvarchar(30),
	itemID nvarchar(30),
	itemname nvarchar(30),
	pricePerItem int,
	quantity int,
	totalPrice int,
	resellerID nvarchar(30),
)
drop table cart
insert into Reseller values (N'R0001',N'',N'Cellphone Z','cellphonez@gmail.com'),
						    (N'R0002',N'',N'Ech Studio','luongchidung123@gmail.com'),
							(N'R0003',N'',N'An Hub','anhub3@gmail.com'),
							(N'R0004',N'',N'An Duy Studio','anduystudio@gmail.com'),
							(N'R0005',N'',N'Thế giới điện thoại','thegioidienthoai@gmail.com'),
							(N'R0006',N'',N'V Tech','vtech@gmail.com'),
							(N'R0007',N'',N'Modern Tech','mtech@gmail.com'),
							(N'R0008',N'agent',N'LCD GamingHub','tridungluong123@gmail.com'),
							(N'R0009',N'',N'Đại lý điện thoại sỉ lẻ An Tâm','antamdaily@gmail.com'),
							(N'R0010',N'',N'Future Tech Light','ftl@gmail.com'),
							(N'R0011',N'',N'A Khải Mobile Shop','akhaimb@gmail.com'),
							(N'R0012',N'',N'Báo Studio','baostudio@gmail.com'),
							(N'R0013',N'',N'Tech Leader','tld@gmail.com'),
							(N'R0014',N'',N'Đại lý Song Tú','dailysongtu@gmail.com'),
							(N'R0015',N'',N'Anh Tư GearPhone','anh4gearphone@gmail.com'),
							(N'R0016',N'',N'Đại lý Duy Tâm','duytamshop@gmail.com'),
							(N'R0017',N'',N'Samsin','ss123@gmail.com'),
							(N'R0018',N'',N'Mi Shop','mishopphonestore@gmail.com'),
							(N'R0019',N'',N'Starlight Mobile','starlightmobile@gmail.com'),
							(N'R0020',N'',N'Anh Tú Gaming Phone Shop','ntu4318@gmail.com');
--create table orderList(
--	orderID nvarchar(30) primary key,
--	resellerID nvarchar(30),
--	foreign key(resellerID) references Reseller(resellerID),
--	createdDay date 
--)

create table orderList(
	orderID nvarchar(30) primary key,
	resellerID nvarchar(30),
	createdDay date ,
	_status nvarchar(30) ,
	paymentMethod nvarchar(30),
	_address nvarchar(30),
	phoneNumber nvarchar(30),
	email nvarchar(30),
	totalPrice int,
	paymentStatus nvarchar(30)
)
drop table orderlist

delete from orderlist

select * from orderList 
where resellerID = 'R0002' 
order by createdDay asc

select totalprice from orderlist where orderID = 'O0001'

insert into orderList values	('O0002', 'R0002', GETDATE(),'a','a','a','a','a'),
								('O0002', 'R0001', '2023/03/07'),
								('O0003', 'R0001', '2023/02/07'),
								('O0004', 'R0003', '2023/01/12'),
								('O0005', 'R0003', '2023/04/23'),
								('O0006', 'R0011', '2023/05/01'),
								('O0007', 'R0020', '2023/05/02'),
								('O0008', 'R0012', '2023/04/11'),
								('O0009', 'R0013', '2023/04/24'),
								('O0010', 'R0005', '2023/04/26'),
								('O0011', 'R0002', '2023/04/05'),
								('O0012', 'R0001', '2023/04/04'),
								('O0013', 'R0014', '2023/03/03'),
								('O0014', 'R0015', '2023/01/02'),
								('O0015', 'R0018', '2023/05/01'),
								('O0016', 'R0007', '2023/05/03'),
								('O0017', 'R0008', '2023/04/02'),
								('O0018', 'R0008', '2023/04/21'),
								('O0019', 'R0002', '2023/04/21'),
								('O0020', 'R0003', '2023/04/21');
--create table orderDetail(
--	ordernumber nvarchar(30) primary key,
--	orderID nvarchar(30),
--	foreign key(orderID) references orderList(orderID),
--	itemID nvarchar(30),
--	foreign key(itemID) references CurrentGoods(goodID),
--)

create table orderDetail(
	orderNumber int IDENTITY(1,1) primary key,
	orderID nvarchar(30),
	itemID nvarchar(30),
	itemname nvarchar(30),
	pricePerItem int,
	quantity int,
	totalPrice int
)
drop table orderdetail
select * from orderdetail
insert into orderDetail values	('1',  'O0001', 'I0001', 2, 10000000, 2*10000000),
								('2',  'O0001', 'I0002', 3, 15000000, 3*15000000),
								('3',  'O0001', 'I0004', 1, 17000000, 1*17000000),
								('4',  'O0004', 'I0005', 1, 20000000, 1*20000000),
								('5',  'O0004', 'I0005', 1, 20000000, 1*20000000),
								('6',  'O0006', 'I0004', 3, 17000000, 3*17000000),
								('7',  'O0007', 'I0010', 3, 23000000, 3*23000000),
								('8',  'O0008', 'I0010', 5, 23000000, 5*23000000),
								('9',  'O0009', 'I0004', 6, 17000000, 6*17000000),
								('10', 'O0011', 'I0007', 5, 14000000, 5*14000000),
								('11', 'O0011', 'I0007', 6, 14000000, 6*14000000),
								('12', 'O0012', 'I0008', 9, 17000000, 9*17000000),
								('13', 'O0012', 'I0006', 5, 12000000, 5*12000000),
								('14', 'O0014', 'I0009', 2, 16000000, 2*16000000),
								('15', 'O0014', 'I0007', 3, 14000000, 3*14000000),
								('16', 'O0015', 'I0008', 1, 17000000, 1*17000000),
								('17', 'O0015', 'I0004', 3, 17000000, 3*17000000),
								('18', 'O0016', 'I0007', 5, 14000000, 5*14000000),
								('19', 'O0016', 'I0002', 3, 15000000, 3*15000000),
								('20', 'O0020', 'I0008', 9, 17000000, 9*17000000);


--select * from account where username = N'hihi'
--select * from orderList
--select * from currentGoods
	select * from cart
	select * from orderdetail

	select goodID,quantity,goodName from CurrentGoods
	select itemID,quantity from orderDetail where orderID = 'O0001'

	insert into orderDetail(orderNumber) values  ('CR0002')

	insert into orderdetail( orderID, itemID, itemname, pricePerItem, quantity, totalPrice)
	select orderID, itemID, itemname,  pricePerItem, quantity, totalPrice from cart where resellerID = 'R0001'

	select SUM(totalPrice) from Cart where resellerID = 'R0001' and orderID = 'O0001'
delete from cart
delete from orderdetail

select orderID from cart where resellerId = 'R0001' order by orderID desc

--select * from orderList order by orderID

--select goodName,price from CurrentGoods where goodID = 'I0010'

--insert into Cart values ('C0001','O0021','I0002','Iphone Xs Max',15000000,3,45000000)
update cart set resellerID = 'R0003' where cartNumber = 'CR0001'
delete from cart where cartNumber = 'C0001' and itemID = 'I0001'

create table ExportedSlips(
	orderID nvarchar(30) primary key,
	resellerID nvarchar(30),
	createdDay date ,
	_status nvarchar(30) ,
	paymentMethod nvarchar(30),
	_address nvarchar(30),
	phoneNumber nvarchar(30),
	email nvarchar(30),
	totalPrice int,
	paymentStatus nvarchar(30)
)

select * from ExportedSlips
delete from ExportedSlips

insert into ExportedSlips(orderID,resellerID,createdDay,_status,paymentMethod,_address,phoneNumber,email,totalPrice,paymentStatus)
select orderID,resellerID,createdDay,_status,paymentMethod,_address,phoneNumber,email,totalPrice,paymentStatus from orderList where orderID = 'O0001'

create table ExportedSlipsDetail(
	orderID nvarchar(30),
	itemID nvarchar(30),
	itemname nvarchar(30),
	pricePerItem int,
	quantity int,
	totalPrice int,
)
drop table exportedslipsdetail

delete from ExportedSlipsDetail
delete from ExportedSlips
delete from cart
delete from orderlist
delete from orderDetail

select * from ExportedSlipsDetail

select TOP 1 itemName
from ExportedSlipsDetail
group by itemname
order by Count(quantity) DESC

select cast(SUM(totalPrice) as nvarchar(30)) + ' $' as Revenue from ExportedSlips where MONTH(createdDay) = '5'

select * from ExportedSlips

select MONTH(createdDay), orderID  from ExportedSlips where MONTH(createdDay) = '05'

select * from cart
select * from orderlist
select * from orderDetail

select * from ExportedSlipsDetail

select distinct orderID from orderdetail

insert into ExportedSlipsDetail(orderID,itemID,itemname,pricePerItem,quantity,totalPrice)
select orderID,itemID,itemname,pricePerItem,quantity,totalPrice from orderDetail where orderID = 'O0001'