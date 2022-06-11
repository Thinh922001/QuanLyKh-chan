create database QL_Khach_San


use QL_DVVT_DW
drop database QL_Khach_San
create table LoaiPhong
(
MaLP char(10) primary key(MALP),
TenPhong nvarchar(50),
DonGia bigint,
SoNguoi int,
SoGiuong int
)
create table ThietBi
(
MATB char(10) primary key(MATB),
TenTB nvarchar(20),
DonGia float
)
create table SanPham
(
MASP char(10) primary key(MASP),
TENSP nvarchar(50),
DONGIA float,
)
create table Tang
(
MATANG int primary key(MATANG),
TenTang nvarchar(10)
)
create table KhachHang
(
MAKH char(10) primary key(MAKH),
TenKH nvarchar(50),
CMND nvarchar(50),
DienThoai nvarchar(50),
Email nvarchar(50),
DiaChi nvarchar(50),
)

create table Phong
(
MaPH char(10) primary key(MAPH),
TenPH nvarchar(50),
TrangThai nvarchar(50),
MaTang int not null,
MALP char  (10) not null
)
create table Phong_ThietBi
(
MAPH char(10),
MATB char(10) primary key(MAPH,MATB),
soLuong int,
)
create table NhanVien
(
MaNV char(10) primary key(MANV),
HoTen nvarchar(50),
MatKhau char(50),
quyen nvarchar(50)
)
create table DatPhong
(
MaDatPhong int identity(1,1) primary key(MaDatPhong),
MaKH char(10),
NgayDat datetime,
NgayTra datetime,
SoNguoiO int,
MaNV char(10),
TongTien float,
TinhTrang bit,
Theodoan bit,
ghichu nvarchar(2000),
)

create table CHITIETDATPHONG
(
MaDatPhong  int ,
MAPH char(10) primary key(MaDatPhong,MAPH),
SoNgayO int,
DonGia float,
ThanhTien float,
Ngay date
)
create table DatPhong_SanPham
(
MaDatPhong int ,
MAPH char(10),
MASP char(10) primary key(MaDatPhong,MAPH,MASP),
Ngay date,
SoLuong int,
DonGia float,
ThanhTien float
)



alter table Phong
add constraint FK_P_LoaiPhong foreign key(MALP) references LoaiPhong(MALP),
constraint FK_P_Tang foreign key(MATANG) references Tang(MATANG)

alter table Phong_ThietBi
add  constraint FK_PTB_TB foreign key(MATB) references ThietBi(MATB)
alter table Phong_ThietBi
add constraint FK_PTB_P foreign key(MAPH) references Phong(MAPH)


alter table DatPhong
add constraint FK_DP_KH foreign key(MAKH) references KhachHang(MAKH),
constraint FK_DP_NV foreign key(MANV) references NhanVien(MANV)


alter table CHITIETDATPHONG
add constraint  PK_CTDP_P foreign key(MAPH) references Phong(MAPH),
constraint  PK_CTDP_DP foreign key(MaDatPhong) references DatPhong(MaDatPhong)

alter table DatPhong_SanPham
add constraint  PK_DP_SP_SP foreign key(MASP) references SANPHAM(MASP),
constraint  PK_DP_SP_PH foreign key(MAPH) references Phong(MAPH),
constraint  PK_DP_SP foreign key(MaDatPhong) references DatPhong(MaDatPhong)
insert into Tang
values('1',N'Tầng 1'),
('2',N'Tầng 2'),
('3',N'Tầng 3')

insert into LoaiPhong(MaLP,TenPhong,DonGia,SoNguoi,SoGiuong)
values('LP1','VIP',500000,2,2),
('LP2','SVIP',1000000,4,2),
('LP3','SSVIP',2000000,4,2),
('LP4',N'Thường',200000,2,1)

insert into Phong(MaPH,TenPH,TrangThai,MaTang,MALP)
values('P101',N'Phòng 101',N'Còn','1','LP4'),
('P102',N'Phòng 102',N'Còn','1','LP4'),
('P103',N'Phòng 103',N'Còn','1','LP4'),
('P104',N'Phòng 104',N'Còn','1','LP4'),
('P201',N'Phòng 201',N'Còn','2','LP3'),
('P202',N'Phòng 202',N'Còn','2','LP3'),
('P203',N'Phòng 203',N'Còn','2','LP3'),
('P204',N'Phòng 204',N'Hết','2','LP3'),
('P301',N'Phòng 301',N'Còn','3','LP2'),
('P302',N'Phòng 302',N'Còn','3','LP2'),
('P303',N'Phòng 303',N'Hết','3','LP4'),
('P304',N'Phòng 304',N'Còn','3','LP4')

insert into KhachHang(MAKH,TenKH,CMND,DienThoai,Email,DiaChi)
values('KH01',N'Lê Cường Thịnh','301783161','0967611122','lecuongthinh2001@gmail.com',N'Long An')


insert into NhanVien
values('NV01',N'Nguyễn Cường Lê','123','NV'),
('NV02',N'Lê Cường Thịnh','123','admin')

insert into SanPham
values('SP01',N'Thanh Long',5000),
('SP02',N'CoCa',8000),
('SP03',N'PepSi',8000),
('SP04',N'Trà Đá',1000)
set dateformat DMY
insert into DatPhong(MaKH,MaNV,MAPH,SoNguoiO,NgayDat,NgayTra,TongTien,TinhTrang,Theodoan)
values('KH01','NV01','P304',3,'24/4/2020','25/4/2020',224000,1,0)

insert into CHITIETDATPHONG(MaDatPhong,MAPH,SoNgayO,DonGia,ThanhTien)
values(1,'P304',1,200000,200000)

insert into DatPhong_SanPham(MaDatPhong,MASP,MAPH,SoLuong,DonGia,ThanhTien)
values(1,'SP02',3,8000,24000)

select TenPH,TenTang,DonGia,MaPH,t.MATANG  from Phong p, Tang t,LoaiPhong lp where p.MaTang=t.MATANG and p.MALP=lp.MaLP and p.TrangThai=N'Còn' and p.MaPH='P101'
select * from DatPhong

select * from CHITIETDATPHONG
set IDENTITY_INSERT CHITIETDATPHONG on

set IDENTITY_INSERT DatPhong_SanPham on
set dateformat DMY
insert into CHITIETDATPHONG(MaDatPhong,MAPH,SoNgayO,DonGia,ThanhTien,Ngay)
values(1,'P304',3,1000000,3000000,'23/5/2022')


select dp.MaDatPhong,kh.TenKH,dp_sp.MASP,sp.TENSP,ct.ThanhTien as CT_Thanhtien,kh.DienThoai,kh.DiaChi,dp.NgayDat,dp.NgayTra,dp.SoNguoiO,dp_sp.SoLuong,dp_sp.MASP,p.TenPH,sp.DONGIA as SP_DonGia,dp.TongTien as dp_TongTien,lp.DonGia as DGLP from KhachHang kh,DatPhong dp,DatPhong_SanPham dp_sp,SanPham sp,CHITIETDATPHONG ct,Phong p,LoaiPhong lp 
where  kh.MAKH=dp.MaKH and dp_sp.MaDatPhong=dp.MaDatPhong and dp_sp.MASP=dp_sp.MASP and ct.MaDatPhong=dp.MaDatPhong and ct.MAPH=p.MaPH and p.MALP=lp.MaLP  and dp.MaDatPhong=8
go
create proc PHIEUDATPHONG
(
@MADATPHONG int
)
as
begin
SELECT dbo.DatPhong_SanPham.SoLuong, dbo.DatPhong_SanPham.DonGia, dbo.DatPhong_SanPham.MASP, dbo.Phong.TenPH, dbo.Phong.MaPH, dbo.DatPhong.MaKH, dbo.DatPhong.NgayDat, dbo.DatPhong.NgayTra, dbo.DatPhong.TongTien, 
                  dbo.CHITIETDATPHONG.SoNgayO, dbo.CHITIETDATPHONG.DonGia AS Expr1, dbo.CHITIETDATPHONG.ThanhTien, dbo.SanPham.TENSP, dbo.SanPham.DONGIA AS Expr2, dbo.DatPhong.ghichu, dbo.KhachHang.TenKH, 
                  dbo.KhachHang.DienThoai, dbo.KhachHang.DiaChi, dbo.LoaiPhong.DonGia AS Expr3
FROM     dbo.KhachHang INNER JOIN
                  dbo.CHITIETDATPHONG INNER JOIN
                  dbo.DatPhong ON dbo.CHITIETDATPHONG.MaDatPhong = dbo.DatPhong.MaDatPhong INNER JOIN
                  dbo.DatPhong_SanPham ON dbo.DatPhong.MaDatPhong = dbo.DatPhong_SanPham.MaDatPhong INNER JOIN
                  dbo.SanPham ON dbo.DatPhong_SanPham.MASP = dbo.SanPham.MASP ON dbo.KhachHang.MAKH = dbo.DatPhong.MaKH INNER JOIN
                  dbo.LoaiPhong INNER JOIN
                  dbo.Phong ON dbo.LoaiPhong.MaLP = dbo.Phong.MALP ON dbo.CHITIETDATPHONG.MAPH = dbo.Phong.MaPH AND dbo.DatPhong_SanPham.MAPH = dbo.Phong.MaPH
				  where DatPhong.MaDatPhong=@MADATPHONG
end

exec PHIEUDATPHONG 1

SELECT dbo.DatPhong_SanPham.SoLuong, dbo.DatPhong_SanPham.DonGia, dbo.DatPhong_SanPham.MASP, dbo.Phong.TenPH, dbo.Phong.MaPH, dbo.DatPhong.MaKH, dbo.DatPhong.NgayDat, dbo.DatPhong.NgayTra, dbo.DatPhong.TongTien, 
                  dbo.CHITIETDATPHONG.SoNgayO, dbo.CHITIETDATPHONG.DonGia AS donGiaCTDP, dbo.CHITIETDATPHONG.ThanhTien, dbo.SanPham.TENSP, dbo.SanPham.DONGIA AS DONGIA_SANPHAM, dbo.DatPhong.ghichu, dbo.KhachHang.TenKH, 
                  dbo.KhachHang.DienThoai, dbo.KhachHang.DiaChi
FROM     dbo.KhachHang INNER JOIN
                  dbo.CHITIETDATPHONG INNER JOIN
                  dbo.DatPhong ON dbo.CHITIETDATPHONG.MaDatPhong = dbo.DatPhong.MaDatPhong INNER JOIN
                  dbo.DatPhong_SanPham ON dbo.DatPhong.MaDatPhong = dbo.DatPhong_SanPham.MaDatPhong INNER JOIN
                  dbo.SanPham ON dbo.DatPhong_SanPham.MASP = dbo.SanPham.MASP ON dbo.KhachHang.MAKH = dbo.DatPhong.MaKH LEFT OUTER JOIN
                  dbo.LoaiPhong INNER JOIN
                  dbo.Phong ON dbo.LoaiPhong.MaLP = dbo.Phong.MALP ON dbo.CHITIETDATPHONG.MAPH = dbo.Phong.MaPH AND dbo.DatPhong_SanPham.MAPH = dbo.Phong.MaPH
				  where DatPhong.MaDatPhong=1

set dateformat DMY
SELECT dbo.DatPhong.MaDatPhong, dbo.DatPhong.NgayDat, dbo.DatPhong.NgayTra, dbo.DatPhong.SoNguoiO, dbo.DatPhong.TongTien, dbo.DatPhong.ghichu, dbo.CHITIETDATPHONG.MAPH, dbo.Phong.TenPH, 
                  dbo.CHITIETDATPHONG.SoNgayO, dbo.CHITIETDATPHONG.ThanhTien, dbo.CHITIETDATPHONG.DonGia
FROM     dbo.CHITIETDATPHONG INNER JOIN
                  dbo.DatPhong ON dbo.CHITIETDATPHONG.MaDatPhong = dbo.DatPhong.MaDatPhong INNER JOIN
                  dbo.Phong ON dbo.CHITIETDATPHONG.MAPH = dbo.Phong.MaPH INNER JOIN
                  dbo.LoaiPhong ON dbo.Phong.MALP = dbo.LoaiPhong.MaLP
where DatPhong.NgayDat>='27-05-2022' and DatPhong.NgayDat<'29-5-2022'

alter proc DoanhThuCongTyNgay
@ngayD datetime,
@ngayC datetime
as
begin
set nocount on;
declare @q varchar(max)
  set @q='SELECT dbo.DatPhong.MaDatPhong, dbo.DatPhong.NgayDat, dbo.DatPhong.NgayTra, dbo.DatPhong.SoNguoiO, dbo.DatPhong.TongTien, dbo.DatPhong.ghichu, dbo.CHITIETDATPHONG.MAPH, dbo.Phong.TenPH, 
                  dbo.CHITIETDATPHONG.SoNgayO, dbo.CHITIETDATPHONG.ThanhTien, dbo.CHITIETDATPHONG.DonGia
FROM     dbo.CHITIETDATPHONG INNER JOIN
                  dbo.DatPhong ON dbo.CHITIETDATPHONG.MaDatPhong = dbo.DatPhong.MaDatPhong INNER JOIN
                  dbo.Phong ON dbo.CHITIETDATPHONG.MAPH = dbo.Phong.MaPH INNER JOIN
                  dbo.LoaiPhong ON dbo.Phong.MALP = dbo.LoaiPhong.MaLP
where DatPhong.NgayDat>='''+CONVERT(varchar,@ngayD,103)+''' and DatPhong.NgayDat<'''+CONVERT(varchar,@ngayC,103)+''''
exec (@q)
end
go
DoanhThuCongTyNgay   '27-05-2022', '29/5/2022'