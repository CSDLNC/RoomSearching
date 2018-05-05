CREATE DATABASE demo02

USE demo02;

CREATE TABLE KhachSan
(
	maKS 			int 			NOT NULL IDENTITY(1,1),
	tenKS 			nvarchar(50) 	NOT NULL,
	soSao 			int 			NOT NULL,
	soNha 			int 			NOT NULL,
	duong 			nvarchar(50) 	NOT NULL,
	quan 			nvarchar(30) 	NOT NULL,
	thanhPho 		nvarchar(30) 	NOT NULL,
	giaTB 			money 			NOT NULL,
	moTa 			nvarchar(200),
	
	PRIMARY KEY (maKS)
);

SET IDENTITY_INSERT KhachSan ON
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('001',N'Đông Dương',5,123, N'Nguyễn Trãi',N'Q. Bình Thạnh', N'Hồ Chí Minh', 3000000,N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('002',N'Ánh Sao',4,1267, N'Nguyễn Bỉnh Khiêm',N'Quận 3', N'Đà Nẵng', 5000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('003',N'Thanh Tùng',5,12, N'Lê Lợi',N'Q. Hoàn Kiếm', N'Hà Nội', 1000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('004',N'Riverside',3,133, N'Nguyễn Tất Thành', N'Quận 1', N'Hồ Chí Minh', 7000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('005',N'Đồng Khởi',2,123, N'Ông Bích Khiêm', N'Q. Hà Đông', N'Hà Nội', 2000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('006',N'Hanoi Dream',1,123, N'Phạm Ngũ Lão', N'Q. Cầu Giấy', N'Hà Nội', 3000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('007',N'Hoàng Phú Gia',5,123, N'Trần Hưng Đạo', N'Quận 2', N'Đà Nẵng', 4000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('008',N'Ocean Vilas',5,123, N'',N'Quận 3', N'Đà Nẵng', 3500000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('009',N'Đông Hà',4,123, N'Lê Lai',N'Quận 1', N'Đà Nẵng', 4500000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('010',N'Viền Đông',3,123, N'Lý Thường Kiệt', N'Q. Tân Bình', N'Hồ Chí Minh', 2500000, N'abcxyz')
SET IDENTITY_INSERT KhachSan OFF


/********************************/

go
SELECT * FROM dbo.KhachSan KS WHERE KS.soSao = 4 AND KS.thanhPho = N'Đà Nẵng';

select count(*), thanhPho 
from KhachSan 
group by thanhPho
having count(*) > 1



CREATE VIEW ChonThanhPho AS 
SELECT thanhPho
FROM KhachSan
GROUP BY thanhPho
HAVING count(*) >= 1; 

select * from ChonThanhPho;

CREATE VIEW ChonSoSao AS
SELECT soSao
FROM KhachSan
GROUP BY soSao
HAVING count(*) >= 1;

select * from ChonSoSao;

CREATE VIEW ChonGiaTB AS
SELECT giaTB
FROM KhachSan
GROUP BY giaTB
HAVING count(*) >= 1;

select * from ChonGiaTB;

CREATE PROCEDURE SP_ChonThanhPho
AS
BEGIN
SELECT * FROM ChonThanhPho
END;

exec SP_ChonThanhPho


CREATE PROCEDURE SP_ChonSoSao
AS
BEGIN
SELECT * FROM ChonSoSao
END;

exec SP_ChonSoSao


CREATE PROCEDURE SP_ChonGiaTB
AS
BEGIN
SELECT * FROM ChonGiaTB
END;

exec SP_ChonGiaTB


