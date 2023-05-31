create database QLDQ
use QLDQ

create table SANPHAM
(
	MaSP int identity(1,1) primary key,
	TenSP nvarchar(100) unique,
	MaLSP int ,
	DonGiaBan float,
	DonGiaMua float,
	SoLuongTon int
)
create table DONVITINH
(
	MaDVT int identity(1,1) primary key,
	DVT nvarchar(100) unique
)
create table LOAISANPHAM
(
	MaLSP int identity(1,1) primary key,
	TenLSP nvarchar(100) unique, 
	LoiNhuan float,
	MaDVT int
)

create table KHACHHANG 
(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(100),
	SDT varchar(20)
)

create table DICHVU
(
	MaDV int identity(1,1) primary key,
	TenDV nvarchar(100) unique,
	DonGiaDV float
)

create table NHACUNGCAP
(
	MaNCC int identity(1,1) primary key,
	TenNCC nvarchar(100),
	DiaChi nvarchar(100),
	SDT varchar(20)
)

create table TONKHO
(
	Thang smalldatetime,
	MaSP int,
	SLTonDau int,
	SLTonCuoi int,
	SLMuaVao int,
	SLBanRa int

	constraint PK_TONKHO primary key ( MaSP , Thang )
)

create table PHIEUMUAHANG
(
	MaPhieuMH int identity(1,1) primary key,
	MaNCC int,
	NgayLap smalldatetime,
	TongTien float
)
create table CT_PHIEUMUAHANG
(
	MaPhieuMH int,
	MaSP int,
	SL int,
	DonGia float,
	ThanhTien float

	constraint PK_CTPMH primary key (MaPhieuMH , MaSP )
)
create table PHIEUBANHANG
(
	MaPhieuBH int identity(1,1) primary key,
	MaKH int,
	NgayLap smalldatetime,
	TongTien float
)
create table CT_PHIEUBANHANG
(
	MaPhieuBH int,
	MaSP int,
	SL int ,
	DonGia float,
	ThanhTien float

	constraint PK_CTPBH primary key (MaPhieuBH , MaSP )
)
create table PHIEUDICHVU
(
	MaPhieuDV int identity(1,1) primary key,
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
	DonGia float,
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
	MaThamSo int identity(1,1) primary key,
	TenThamSo varchar(100) ,
	GiaTri float
)

set dateformat dmy
--------------Foreign Key-------------------
alter table SanPham add constraint FK_SP_LSP foreign key (MaLSP) references LoaiSanPham ( MaLSP )
alter table LoaiSanPham add constraint FK_LSP_DVT foreign key (MaDVT) references DonViTinh (MaDVT)
alter table TonKho add constraint FK_TK_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuMuaHang add constraint FK_PhieuMH_NCC foreign key (MaNCC) references NhaCungCap (MaNCC)
alter table CT_PhieuMuaHang add constraint FK_CTPMH_PMH foreign key (MaPhieuMH) references PhieuMuaHang (MaPhieuMH)
alter table CT_PhieuMuaHang add constraint FK_CTPMH_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuBanHang add constraint FK_PhieuBH_KH foreign key (MaKH) references KhachHang (MaKH)
alter table CT_PhieuBanHang add constraint FK_CTPBH_PBH foreign key (MaPhieuBH) references PhieuBanHang (MaPhieuBH)
alter table CT_PhieuBanHang add constraint FK_CTPBH_SP foreign key (MaSP) references SanPham (MaSP)
alter table PhieuDichVu add constraint FK_PhieuDV_KH foreign key (MaKH) references KhachHang (MaKH)
alter table CT_PhieuDichVu add constraint FK_CTPDV_PDV foreign key (MaPhieuDV) references PhieuDichVu (MaPhieuDV)
alter table CT_PhieuDichVu add constraint FK_CTPDV_DV foreign key (MaDV) references DichVu (MaDV)

--reset identity---
--DBCC CHECKIDENT ( DONVITINH , RESEED , 0 )
--DBCC CHECKIDENT ( LOAISANPHAM , RESEED , 0)
--DBCC CHECKIDENT (SANPHAM , RESEED , 0)
--trigger---
go
create trigger trg_THEMSANPHAM
on SANPHAM
for insert , update
as begin
	declare @LOINHUAN float
	declare @MaSP int
	select @MaSP = MaSP from inserted
	select @LOINHUAN = LoiNhuan from LOAISANPHAM , inserted where inserted.MaLSP = LOAISANPHAM.MaLSP
	update SANPHAM
	set DonGiaBan = DonGiaMua * ( 100 + @LOINHUAN ) /100
	where MaSP = @MaSP
end
--select *
select * from DONVITINH
select * from LOAISANPHAM
select * from SANPHAM
delete from SANPHAM
--DONVITINH
insert into DONVITINH values (N'Cặp')
insert into DONVITINH values (N'Chiếc')
--LOAISANPHAM
insert into LOAISANPHAM values 
(N'Lắc' , 5 , 1), -- MALSP = 1
(N'Vòng' , 5 , 1), -- 2
(N'Dây cổ' , 5 , 1), -- 3
(N'Dây chuyền', 5 , 1), -- 4
(N'Kiềng' , 5 , 1 ), -- 5
(N'Bông tai' , 5 , 2), -- 6
(N'Nhẫn' , 5 , 1), -- 7
(N'Mặt dây chuyền' , 5 , 1), -- 8
(N'Đồng hồ' , 5 , 1), -- 9
(N'Đồng hồ cặp' , 5 , 2) -- 10
---DICHVU--
insert into DICHVU values (N'Kiểm định chất lượng đá quý' , 200000)
insert into DICHVU values (N'Kiểm định chất lượng vàng bạc' , 100000)
insert into DICHVU values (N'Vệ sinh sản phẩm' , 100000)
insert into DICHVU values (N'Sửa chữa' , 100000)
insert into DICHVU values (N'Đánh bóng' , 100000)
insert into DICHVU values (N'Khắc tên , họa tiết' , 200000)
insert into DICHVU values (N'Trả/Đổi hàng' , 100000)

---SANPHAM
--Lắc--
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay bạc đính ngọc trai STYLE x CHOU CHOU NHNHY000001' , 1 , 910000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay bạc Ý 0000W000050' , 1 , 500000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay Bạc đính đá XMXMW000019', 1 , 1400000, 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay bạc Ý 0000W060094' , 1 , 1000000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay trẻ em bạc Disney hình chuột Mickey đen 0000Y060009' , 1 , 480000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc bạc DIY 0000W060029' , 1 , 350000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc bạc đính đá Disney Frozen NHMXW000002' , 1 , 1000000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay Bạc đính đá CZ XM00W000011' , 1 , 1800000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc tay Bạc đính đá XMXMW060061' , 1 , 800000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Lắc charm nam bạc My Man 0000K060015' , 1 , 500000 , 0)
---Vòng---
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay Vàng 18K đính đá Ruby RB00Y000008' , 2 , 9000000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay Vàng trắng 14K đính đá Topaz TPXMW000021' , 2 , 41254000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay Vàng 18K đính ngọc trai Freshwater PFXMY000010' , 2 , 27410000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay Vàng trắng Ý 18K PNJ 0000W060385' , 2 , 21990000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay Kim cương Vàng trắng 14K DDDDW060048' , 2 , 114500000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Vòng tay trẻ em Vàng 14K HELLO KITTY 0000C060046' , 2 , 6290000 , 0)
--Dây cổ
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây cổ Bạc 0000Y060036' , 3 , 975000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây cổ Vàng Ý 18K 0000Z000035' , 3 , 39538000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây cổ Vàng 18K đính đá Citrine CTMXY000012' , 3 , 130134000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây cổ Vàng trắng 14K đính đá Sapphire SPMXW000001' , 3 , 143184000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây cổ Vàng 18K đính đá Ruby RBMXY000012' , 3 , 99682000, 0)
--Dây chuyền
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây chuyền Vàng 18K 0000Y060475' , 4 , 19334000, 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây chuyền Vàng trắng Ý 18K 0000W060970' , 4 , 32590000, 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây chuyền nam Vàng Ý 18K 0000Y060509' , 4 , 41990000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây chuyền nam Vàng trắng Ý 18K 0000W061215' , 4 , 11590000, 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Dây chuyền Bạc 0000W000022' , 4 , 1295000, 0)


--Nhẫn
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Nhẫn trẻ em Bạc PNJSilver 0000W060019' , 7 , 495000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Nhẫn bạc đính ngọc trai PNJSilver Euphoria PFXMH000002' , 7 , 875000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Nhẫn bạc đính đá STYLE By PNJ XMXMY060016' , 7 , 575000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'NNhẫn Vàng 18K đính đá Citrine PNJ CTXMY000460' , 7 , 13477000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Nhẫn Vàng trắng 10K đính đá ECZ PNJ XMXMW002392' , 7 , 9264000 , 0)

--Mặt dây chuyền
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Mặt dây chuyền Bạc đính đá PNJSilver XMXMW060056' , 8 , 1895000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Mặt dây chuyền Bạc đính đá PNJSilver XMXMW060051' , 8 , 1595000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Mặt dây chuyền Vàng 18K đính đá CZ PNJ XMXMY005462' , 8 , 8384000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Mặt dây chuyền Kim cương Vàng 14K PNJ DDDDY060010' , 8 , 19900000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Mặt dây chuyền Kim cương Kim tiền Vàng trắng 14K PNJ DDDDW060341' , 8 , 19900000 , 0)

--Kiềng--
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Kiềng Vàng trắng Ý 18K PNJ 0000W060270' , 5 , 40490000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Kiềng cưới vàng 24K PNJ 0000Y060011' , 5 , 29663000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Kiềng Vàng Ý 18K PNJ kiểu đan bi tròn 0000Z060136', 5 , 54065000, 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Kiềng bạc đính đá STYLE by PNJ DNA XMXMH000001' , 5 , 987000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Kiềng Bạc Ý PNJSilver 0000W060020' , 5 , 1295000 , 0)
---Bông tai---
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Bông tai Vàng 10K Style By PNJ DNA ZTMXY000093' , 6 , 3152000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Bông tai Vàng trắng 10K đính đá ECZ STYLE by PNJ XMXMW002238' , 6 , 2218000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Bông tai Kim Tiền Vàng trắng Ý 18K PNJ 0000W002163' , 6 , 6374000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Bông tai nam Bạc đính đá PNJSilver XMXMW060142' , 6 , 325000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Bông tai Kim cương Vàng trắng 14K PNJ DDDDW001753' , 6 , 37840000 , 0)

---Đồng hồ---
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Tissot Nam T063.617.36.037.00 Dây Da 42mm' , 9 , 14700000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Skagen Nữ SKW2340 Dây Thép Không Gỉ 30mm' , 9 , 4650000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Tissot Unisex T109.410.33.021.00 Dây Thép Không Gỉ 38mm' , 9 , 9975000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Fossil Nữ ES5286 Dây Cao Su 36 mm' , 9 , 3650000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Fossil Nam FS4656 Dây Da 42 mm' , 9 , 4890000 , 0)
---Đồng hồ cặp---
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Cặp Jowissa J2.195.L Và J2.309.S 45 mm - 26 mm' ,  10 , 12980000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Cặp Tissot T134.410.27.011.00 Và T134.210.27.011.00 41 mm - 34 mm' ,  10 , 24500000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Cặp Tissot T109.410.33.031.00 Và T109.210.33.031.00 38 mm - 30 mm' ,  10 , 19425000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Cặp Tissot T101.410.22.031.00 Và T101.210.22.031.00 39 mm - 33 mm' ,  10 , 22400000 , 0)
insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values
(N'Đồng Hồ Cặp Longines L4.960.2.11.7 Và L4.360.2.11.7 38.5 mm - 25 mm' ,  10 , 78016000 , 0)


insert into THAMSO values ('SoTienTraTruoc' , 0.5)