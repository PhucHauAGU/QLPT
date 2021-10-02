﻿CREATE DATABASE QLPT
GO


USE QLPT

CREATE TABLE TAIKHOAN
(
	
	ten VARCHAR(20) not null,
	matkhau VARCHAR(50),
	quyen tinyint,

	PRIMARY KEY(ten)
)




CREATE TABLE KHU
(
	MAKHU		VARCHAR(9) NOT NULL,
	TENKHU		NVARCHAR(40),
	SOPHONG		INT,
	PRIMARY KEY(MAKHU)
)

CREATE TABLE PHONG
(
	MAPHONG		VARCHAR(9) NOT NULL,
	MAKHU		VARCHAR(9),
	SOLUONG		INT,
	SOLUONGTOIDA INT,
	

	PRIMARY KEY(MAPHONG)
)

CREATE TABLE HOADON
(
	MAHOADON	VARCHAR(9) NOT NULL,
	MAPHONG		VARCHAR(9) NOT NULL,
	TIENDIEN INT,
	TIENNUOC INT,
	TIENPHONG INT,
	THANHTIEN INT,
	TRANGTHAI NVARCHAR(50),

	PRIMARY KEY(MAHOADON),
)


CREATE TABLE THONGTIN
(
	MASO		VARCHAR(9) NOT NULL,
	HOTEN		NVARCHAR(50) NOT NULL,
	NAMSINH		INT,
	GIOITINH	NVARCHAR(3) NOT	NULL,
	CMND		VARCHAR(10) NOT NULL,
	NGUYENQUAN	NVARCHAR(100) NOT NULL,
	DIENTHOAI	VARCHAR(13) NOT NULL,
	MAKHU		VARCHAR(9) NOT NULL,
	MAPHONG		VARCHAR(9) NOT NULL,
		

	PRIMARY KEY(MASO)
)

INSERT INTO TAIKHOAN VALUES('admin','21232f297a57a5a743894a0e4a801fc3',1);	/* Mật khẩu admin */
INSERT INTO TAIKHOAN VALUES('user','ee11cbb19052e40b07aac0ca060c23ee',2);	/* Mật khẩu user */
--THÊM FOREIGN KEY CHO CÁC TABLE

ALTER TABLE dbo.PHONG ADD CONSTRAINT FK_PHONG FOREIGN KEY(MAKHU) REFERENCES dbo.KHU(MAKHU)
ALTER TABLE dbo.THONGTIN ADD CONSTRAINT FK_THONGTIN FOREIGN KEY(MAKHU) REFERENCES dbo.KHU(MAKHU)
ALTER TABLE dbo.THONGTIN ADD CONSTRAINT FK_THONGTIN1 FOREIGN KEY(MAPHONG) REFERENCES dbo.PHONG(MAPHONG)
ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_HOADON FOREIGN KEY(MAPHONG) REFERENCES dbo.PHONG(MAPHONG)



--USE	master
--DROP DATABASE QLPT




--XEM DỮ LIÊU TRONG TABLE

SELECT * FROM dbo.KHU
SELECT * FROM PHONG

SELECT * FROM dbo.THONGTIN

SELECT * FROM dbo.TAIKHOAN

