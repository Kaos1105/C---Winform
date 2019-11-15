create database CoffeShop
go

use CoffeShop
go

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

create table FoodTable
(
id int identity primary key,
name nvarchar(100) not null default N'Bàn chưa đặt tên',
status nvarchar(100) not null default N'Trống'--Trống || Có người || Đã đặt
)
go

create table Account
(
UserName nvarchar(100) primary key,
DisplayName nvarchar(100) not null default  N'KaosLord',
password nvarchar(1000)  not null default 0,
AccType int default 0--1 admin, 0: staff
)
go

create table FoodCategory
(
id int identity primary key,
Name nvarchar(100) not null default N'Chưa đặt tên',
)
go

create table Food
(
id int identity primary key,
Name nvarchar(100) not null default N'Chưa đặt tên' ,
idCategory int not null,
price float not null default 0
foreign key (idCategory) references FoodCategory(id)
)
go

create table Bill
(
id int identity primary key,
DateCheckIn Date not null default getdate(),
DateCheckOut Date,
idTable int not null,
status int not null default 0 --1: đã thanh toán, 0: chưa thanh toán
foreign key (idTable) references FoodTable(id)
)
go

create table BillInfo
(
id int identity primary key,
idBill int not null,
idFood int not null,
count int not null default 0
foreign key (idBill) references Bill(id),
foreign key (idFood) references Food(id)
)
go
insert into dbo.Account 
(
UserName,
DisplayName,
password,
AccType
)
values ( 
N'KaosLord',
N'Kaos1105',
N'11051999',
1
)
insert into Account 
(
UserName,
DisplayName,
password,
AccType
)
values ( 
N'staff.01',
N'staff.no1',
N'1',
1
)
go


select * from Account
go

create PROC USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select *from Account where UserName=@userName
end
go
exec USP_GetAccountByUserName @userName = N'KaosLord'
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as 
begin 
	select * from Account where UserName=@userName and PassWord=@passWord
end
go

-- thêm bàn
declare @i int =0
while @i <= 20
begin
	insert FoodTable(name)
	values  (N'Bàn ' + cast(@i as nvarchar(100)))
	set @i=@i+1
end
go
delete from FoodTable
 dbcc checkident ('FoodTable', reseed, 0)

select *from FoodTable

create proc USP_GetTableList
as select* from FoodTable
go

exec USP_GetTableList

delete from FoodTable
 update FoodTable set status = N'Có người' where id =10
 select * from FoodTable
  
 -- thêm food category 
 insert FoodCategory
 values (N'Hải sản')
 insert FoodCategory
 values (N'Thịt')
  insert FoodCategory
 values (N'Rau củ')
 insert FoodCategory
 values (N'Trái cây')
  insert FoodCategory
 values (N'Giải khát')

 select * from FoodCategory
 delete from FoodCategory
 dbcc checkident ('FoodCategory', reseed, 0)

 -- thêm food
 insert Food
 values (N'Mực xảo xả ớt', 1, 150000)
  insert Food
 values (N'Ngêu hấp xả', 1, 120000)
   insert Food
 values (N'Tôm xú', 1, 200000)
   insert Food
 values (N'Heo rừng nướng muối ớt', 2, 100000)
    insert Food
 values (N'Bò nướng lá lốt', 2, 140000)
  insert Food
 values (N'Gà chiên mắm', 2, 120000)
     insert Food
 values (N'Cơm chấm kho quẹt', 3, 50000)
    insert Food
 values (N'Lẩu nấm', 3, 50000)
  insert Food
 values (N'Cơm chiên Dương Châu', 3, 50000)
     insert Food
 values (N'Măng cụt', 4, 60000)
      insert Food
 values (N'Sầu riêng', 4, 80000)
   insert Food
 values (N'Cam', 4, 30000)
       insert Food
 values (N'Bia Saigon', 5, 20000)
       insert Food
 values (N'Cocacola', 5, 10000)
       insert Food
 values (N'Pepsi', 5, 10000)
 select * from Food
 delete from Food
 dbcc checkident ('Food', reseed, 0)

 --thêm bill
 insert Bill
 values(
 GETDATE(),
 null,
 2,
 0
 )
  insert Bill
 values(
 GETDATE(),
 GETDATE(),
 2,
 1
 )
   insert Bill
 values(
 GETDATE(),
 GETDATE(),
 3,
 0  
 )
    insert Bill
 values(
 GETDATE(),
 GETDATE(),
 4,
 0  
 )
     insert Bill
 values(
 GETDATE(),
 GETDATE(),
 5,
 0  
 )
 select * from Bill

 --thêm bil info
 insert BillInfo
 values 
 (
 1,
 1,
 3
 )
  insert BillInfo
 values 
 (
 1,
 2,
 2
 )
   insert BillInfo
 values 
 (
 1,
 5,
 3
 )
  insert BillInfo
 values 
 (
 2,
 1,
 3
 )
   insert BillInfo
 values 
 (
 2,
 2,
 4
 )
    insert BillInfo
 values 
 (
 2,
 5,
 3
 )
     insert BillInfo
 values 
 (
 3,
 2,
 4
 )
      insert BillInfo
 values 
 (
 3,
 1,
 3
 )
       insert BillInfo
 values 
 (
 3,
 5,
 2
 )
    insert BillInfo
 values 
 (
 4,
 1,
 4
 )
      insert BillInfo
 values 
 (
 4,
 2,
 4
 )
       insert BillInfo
 values 
 (
 4,
 5,
 3
 )
   insert BillInfo
 values 
 (
 5,
 1,
 2
 )
      insert BillInfo
 values 
 (
 5,
 3,
 2
 )
       insert BillInfo
 values 
 (
 5,
 5,
 1
 )
 select * from BillInfo

 --GetUncheckedBillIDByTableID
 Select * from Bill where idTable = 3 and status =0;
 --Get Bill info form bill ID
 select * from BillInfo where idBill = 3
 -- Get Menu by table
 select f.Name, bi.count, f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b, Food as f
 where bi.idBill=b.id and bi.idFood=f.id and b.idTable=2 and b.status=0;

 --
alter proc USP_InsertBill
 @idTable int
 as 
 begin
	insert Bill
	values(GETDATE(), null, @idTable, 0 , 0)
 end
 go

-- USP_InsertBillInfo
alter proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as 
begin
declare @isFoodExistInBillInfo int;
declare @foodCount int =1;
select  @isFoodExistInBillInfo = id, @foodCount = b.Count 
from BillInfo as b where idBill= @idBill and idFood = @idFood
if(@isFoodExistInBillInfo>0)
	begin
	declare @newCount int = @foodCount+ @count
	if(@newCount>0)
		update BillInfo set count=@foodCount+@count where idBill= @idBill and idFood = @idFood
    else
		delete BillInfo where idBill= @idBill and idFood = @idFood
	end
else  
	begin
	if(@count >0)
	begin
		insert BillInfo
		values(@idBill, @idFood, @count)
	end
	else 
	begin
		insert BillInfo
		values(@idBill, @idFood, 1)
	end
	end
end
go

EXEC sp_rename 'USB_InsertBillInfo', 'USP_InsertBillInfo'; 
 --GetLastestIDBill
 select max(id) from Bill

 --trigger UTG_UpdateBillInfo
alter trigger UTG__UpdateBillInfo
 on BillInfo for insert, update
 as 
 Begin
	declare @idBill int
	select @idBill = idBill from inserted
	declare @idTable int
	select @idTable=idTable from Bill where id=@idBill and status =0
	update FoodTable set status = N'Có người' where id =@idTable
end
go

alter trigger UTG_UpdatebBill
on Bill for insert, update
as 
begin 
	declare @idBill int
	select @idBill = id from inserted
	declare @idTable int
	select @idTable=idTable from Bill where id=@idBill
	declare @count int =0
	select @count = Count(*) from bill where idTable=@idTable and status =0
	if(@count = 0)
		update FoodTable set status =N'Trống' where id = @idTable
end
go

delete FoodTable
delete BillInfo
dbcc checkident ('BillInfo', reseed, 0)
delete Bill
dbcc checkident ('Bill', reseed, 0)
select * from FoodCategory
select * from Food
select * from FoodTable
select * from Bill
select * from BillInfo
select f.Name, bi.count, f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status =0 and b.idTable = 1
select f.Name, bi.count, f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status =0 and b.id = 19

--edit Bill
alter table bill
add discount int 

update bill
set discount =0 
go

create proc USP_SwtichTable
@idTable1 int, @idTable2 int
as begin
	declare @idBill1 int
	declare @idBill2 int
	select @idBill1=id from Bill where idTable = @idTable1 and status =0
	select @idBill2=id from Bill where idTable = @idTable2 and status =0
	if(@idBill1 is null)
		begin
			insert Bill (DateCheckIn, DateCheckOut, idTable, status)
			values (GETDATE(), null, @idTable1, 0)
			select @idBill1=max(id) from Bill where idTable = @idTable1 and status =0
		end
	if(@idBill2 is null)
		begin
			insert Bill (DateCheckIn, DateCheckOut, idTable, status)
			values (GETDATE(), null, @idTable2, 0)
			select @idBill2=max(id) from Bill where idTable = @idTable2 and status =0
		end
	select id into IDBillInfoTable from BillInfo where idBill = @idBill2
	update BillInfo set idBill = @idBill2 where idBill = @idBill1
	update BillInfo set idBill = @idBill1 where id in (Select * from IDBillInfoTable)
	drop table IDBillInfoTable
end
go
