

create database QuanLyChiTieu

GO

use QuanLyChiTieu

GO

set dateformat dmy


create table LoaiChiTieu
(
	MaLoai int identity ,
	TenChiTieu nvarchar(50) primary key,
	
)

go



--drop table danhsachchitieu

create table DanhSachChiTieu
(
	MaChiTieu int identity(1,1) primary key,
	TenChiTieu nvarchar(50) not null,
	GiaTien money,
	NgayNhap smalldatetime default getdate() ,
	GhiChu nvarchar(100),
	foreign key (TenChiTieu) references dbo.LoaiChiTieu(TenChiTieu)
)

insert into LoaiChiTieu
values  (N'Ăn Uống')

insert into LoaiChiTieu
values (N'Cà Phê')

insert into DanhSachChiTieu
values (N'Ăn Uống',20000,6/10/2017,N'Ăn sáng')


insert into DanhSachChiTieu
values (N'Ăn uống',35000,06/10/2017,N'Cafe với bạn bè')

insert into DanhSachChiTieu
values (N'Di Chuyển',50000,08/10/2017,N'Đổ xăng')

insert into DanhSachChiTieu
values (N'Mua sắm',3500000,06/10/2017,N'Mua giày mới')

