create database QLDQ
use QLDQ

create table SANPHAM
(
	MaSP int identity(0,1) primary key,
	TenSP nvarchar(100),
	MaLSP int ,
	DonGiaBan float,
	DonGiaMua float
)
create table DONVITINH
(
	MaDVT int identity(0,1) primary key,
	DVT nvarchar(100)
)
create table LOAISANPHAM
(
	MaLSP int identity(0,1) primary key,
	TenLSP nvarchar(100) , 
	LoiNhuan float,
	MaDVT int
)

create table KHACHHANG 
(
	MaKH int identity(0,1) primary key,
	TenKH nvarchar(100),
	SDT varchar(20)
)

create table DICHVU
(
	MaDV int identity(0,1) primary key,
	TenDV nvarchar(100),
	DonGiaDV float
)

create table NHACUNGCAP
(
	MaNCC int identity(0,1) primary key,
	TenNCC nvarchar(100),
	DiaChi nvarchar(100),
	SDT varchar(20)
)

create table TONKHO
(
	MaTonKho int identity(0,1) primary key,
	Ngay smalldatetime,
)
create table CT_TONKHO
(
	MaTonKho int,
	MaSP int,
	SLTonDau int,
	SLTonCuoi int,
	SLMuaVao int,
	SLBanRa int

	constraint PK_CTTK primary key ( MaTonKho , MaSP )
)

create table PHIEUMUAHANG
(
	MaPhieuMH int identity(0,1) primary key,
	MaNCC int,
	NgayLap smalldatetime
)
create table CT_PHIEUMUAHANG
(
	MaPhieuMH int,
	MaSP int,
	SL int,
	ThanhTien float

	constraint PK_CTPMH primary key (MaPhieuMH , MaSP )
)
create table PHIEUBANHANG
(
	MaPhieuBH int identity(0,1) primary key,
	MaKH int,
	NgayLap smalldatetime
)
create table CT_PHIEUBANHANG
(
	MaPhieuBH int,
	MaSP int,
	SL int ,
	ThanhTien float

	constraint PK_CTPBH primary key (MaPhieuBH , MaSP )
)
create table PHIEUDICHVU
(
	MaPhieuDV int identity(0,1) primary key,
	MaKH int,
	NgayLap smalldatetime,
	TongTien float,
	TraTruoc float,
	ConLai float,
	TinhTrang nvarchar(100)

)
create table CT_PHIEUDICHVU
(
	MaPhieuDV int ,
	MaDV int,
	DonGiaDuocTinh float,
	SL int,
	ThanhTien float,
	TraTruoc float,
	ConLai float,
	NgayGiao smalldatetime,
	TinhTrang nvarchar(100)

	constraint PK_CTPDV primary key ( MaPhieuDV , MaDV )
)
create table THAMSO
(
	MaThamSo int identity(0,1) primary key,
	TenThamSo varchar(100) ,
	GiaTri float
)
--------------Foreign Key-------------------
alter table SanPham add constraint FK_SP_LSP foreign key (MaLSP) references LoaiSanPham ( MaLSP )
alter table LoaiSanPham add constraint FK_LSP_DVT foreign key (MaDVT) references DonViTinh (MaDVT)
alter table CT_TonKho add constraint FK_CTTK_TK foreign key (MaTonKho) references TonKho (MaTonKho)
alter table CT_TonKho add constraint FK_CTTK_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuMuaHang add constraint FK_PhieuMH_NCC foreign key (MaNCC) references NhaCungCap (MaNCC)
alter table CT_PhieuMuaHang add constraint FK_CTPMH_PMH foreign key (MaPhieuMH) references PhieuMuaHang (MaPhieuMH)
alter table CT_PhieuMuaHang add constraint FK_CTPMH_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuBanHang add constraint FK_PhieuBH_KH foreign key (MaKH) references KhachHang (MaKH)
alter table CT_PhieuBanHang add constraint FK_CTPBH_PBH foreign key (MaPhieuBH) references PhieuBanHang (MaPhieuBH)
alter table CT_PhieuBanHang add constraint FK_CTPBH_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuDichVu add constraint FK_PhieuDV_KH foreign key (MaKH) references KhachHang (MaKH)
alter table CT_PhieuDichVu add constraint FK_CTPDV_PDV foreign key (MaPhieuDV) references PhieuDichVu (MaPhieuDV)
alter table CT_PhieuDichVu add constraint FK_CTPDV_DV foreign key (MaDV) references DichVu (MaDV)




