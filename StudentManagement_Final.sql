go 
Create database StudentMagement_Final

go 
use StudentMagement_Final

go 
create table [User]
(
userId int Identity Primary key,
fullName nvarchar(50),
gender bit,
DOB date,
username varchar (50) ,
[password] varchar(50),
[role] varchar(50),
[status] bit, 
[classId] int,
)

go 
create table [Class]
(
classId int Identity Primary key,
[subject] nvarchar(50),
)

go
ALTER TABLE [User]
ADD FOREIGN KEY ([classId]) REFERENCES Class([classId]);

go 
INSERT INTO Class ([subject])
VALUES 
(N'PRN221'), 
(N'SWD392');



go 
INSERT INTO [User] (fullName,gender, DOB, username, [password], [role], [status], classId)
VALUES 
(N'Nguyen Huynh Phi', 1, '5-26-2001', 'SE150972', '123456',  'AD', 1, Null), 

(N'Nguyen Van A', 1, '5-27-1976', 'CE160513', '123456',  'TC', 1, 1), 
(N'Nguyen Van B', 0, '3-29-1978', 'SE140017', '123456',  'TC', 1, 2),


(N'Tran Trong Nhan', 1, '12-1-2001', 'CE160513', '123456',  'ST', 1, 1), 
(N'Nguyen Thanh Tan', 1, '1-2-2001', 'SE140017', '123456',  'ST', 1, 1),
(N'Tran Tan Tai', 1, '1-6-2001', 'SE140283', '123456',  'ST', 1, 1), 
(N'Pham Duc Thang', 1, '5-9-2001', 'SE140534', '123456',  'ST', 1, 1), 
(N'Ho Bao Anh', 1, '7-12-2001', 'SE150101', '123456',  'ST', 1, 1), 
(N'Vu Duc Minh Nhat', 1, '8-6-2001', 'SE150371', '123456',  'ST', 1, 1), 

(N'Pham Trung Hieu', 0, '1-3-2001', 'SE150404', '123456',  'ST', 1, 2), 
(N'Nguyen Minh Tri', 1, '4-5-2001', 'SE150418', '123456',  'ST', 1, 2), 
(N'Vo Thi Kim Trang', 0, '3-6-2001', 'SE150476', '123456',  'ST', 1, 2), 
(N'Tran Nhut Hao', 1, '6-1-2001', 'SE150564', '123456',  'ST', 1, 2), 
(N'Nguyen Do Cao Kien', 1, '5-8-2001', 'SE150577', '123456',  'ST', 1, 2), 
(N'Tran Quoc Long', 1, '7-7-2001', 'SE150593', '123456',  'ST', 1, 2);


