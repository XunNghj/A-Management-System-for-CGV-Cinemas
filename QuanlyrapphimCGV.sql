CREATE DATABASE QuanLyRapChieuPhim;
GO

USE QuanLyRapChieuPhim;

CREATE TABLE NhaCungCap 
(
    MaNCC CHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(100),
    SDT VARCHAR(15)
);

CREATE TABLE Combo 
(
    MaCombo CHAR(10) PRIMARY KEY,
    TenCombo NVARCHAR(100),
    Gia INT
);

CREATE TABLE Cungcap 
(
    MaNCC CHAR(10),
    MaCombo CHAR(10),
    PRIMARY KEY (MaNCC, MaCombo),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (MaCombo) REFERENCES Combo(MaCombo)
);

CREATE TABLE TaiKhoan 
(
    MaTK CHAR(10) PRIMARY KEY,
    TenND NVARCHAR(100),
    Email VARCHAR(100),
    Mk VARCHAR(100),
    LoaiQuyen VARCHAR(10),
    SDT VARCHAR(15)
);


CREATE TABLE ThanhToan 
(
    MaTT CHAR(10) PRIMARY KEY,
    MaTK CHAR(10),
    SoTien MONEY,
    PhuongThuc VARCHAR(20),
    TrangThaiTT VARCHAR(20),
    ThoiGianTT TIME,
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);
ALTER TABLE ThanhToan
ALTER COLUMN PhuongThuc NVARCHAR(100);
ALTER TABLE ThanhToan
ALTER COLUMN TrangThaiTT NVARCHAR(100);

CREATE TABLE DonCombo 
(
    MaDon CHAR(10) PRIMARY KEY,
    ThoiGian DATETIME,
    TrangThaiDon VARCHAR(10),
	MaTT CHAR(10),
	MaTK CHAR(10),
	FOREIGN KEY (MaTT) REFERENCES ThanhToan(MaTT),
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);
ALTER TABLE DonCombo
ALTER COLUMN TrangThaiDon NVARCHAR(100);

CREATE TABLE ChiTietCombo 
(
    MaCombo CHAR(10),
    MaDon CHAR(10),
    SoLuong INT,
    PRIMARY KEY (MaCombo, MaDon),
    FOREIGN KEY (MaCombo) REFERENCES Combo(MaCombo),
    FOREIGN KEY (MaDon) REFERENCES DonCombo(MaDon)
);

CREATE TABLE NhanVien 
(
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100),
    ViTri VARCHAR(100)
);
ALTER TABLE NhanVien
ALTER COLUMN ViTri NVARCHAR(100);

CREATE TABLE PhanHoi 
(
    MaPH CHAR(10) PRIMARY KEY,
    NoiDung NVARCHAR(255),
    NgayGui DATETIME,
    MaTK CHAR(10),
	MaNV CHAR(10),
    TrangThaiPH VARCHAR(10),
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK),
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
ALTER TABLE PhanHoi
ALTER COLUMN TrangThaiPH NVARCHAR(100);

CREATE TABLE BaoCao 
(
    MaBC CHAR(10) PRIMARY KEY,
    TieuDeBC NVARCHAR(100),
    NoiDungBC NVARCHAR(100),
    LoaiBC VARCHAR(20),
    NgayLapBC DATE,
    NguoiLapBC NVARCHAR(100),
    MaNV CHAR(10),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
ALTER TABLE BaoCao
ALTER COLUMN LoaiBC NVARCHAR(100);

CREATE TABLE KhuyenMai 
(
    MaKM CHAR(10) PRIMARY KEY,
    NoiDungKM NVARCHAR(100),
    NgayBD DATE,
    NgayKT DATE,
    DoiTuongApDung VARCHAR(20),
    TrangThaiKM VARCHAR(20)
);
ALTER TABLE KhuyenMai
ALTER COLUMN DoiTuongApDung NVARCHAR(100);
ALTER TABLE KhuyenMai
ALTER COLUMN TrangThaiKM NVARCHAR(100);

CREATE TABLE NhanKhuyenMai 
(
    MaKM CHAR(10),
    MaTK CHAR(10),
    ThoiGianNhan TIME,
    PRIMARY KEY (MaKM, MaTK),
    FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM),
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);

CREATE TABLE PhongChieu 
(
    MaPhong CHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SoGhe INT,
    TrangThaiPhong NVARCHAR(100)
);


CREATE TABLE Ghe 
(
    MaGhe CHAR(10) PRIMARY KEY,
    TenGhe NVARCHAR(100),
    TrangThai VARCHAR(10),
    MaPhong CHAR(10),
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong)
);
ALTER TABLE Ghe
ALTER COLUMN TrangThai NVARCHAR(100);

CREATE TABLE Phim 
(
    MaPhim CHAR(10) PRIMARY KEY,
    TenPhim NVARCHAR(100),
    TieuDe NVARCHAR(100),
    TheLoai NVARCHAR(100),
	MoTa NVARCHAR(100),
    ThoiLuong INT
);

CREATE TABLE SuatChieu 
(
    MaSuat CHAR(10) PRIMARY KEY,
    MaPhim CHAR(10),
    NgayChieu DATE,
    GioBatDau TIME,
    GioKetThuc TIME,
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim),
);

CREATE TABLE Ve 
(
    MaVe CHAR(10) PRIMARY KEY,
    MaQR IMAGE,
    TrangThaiVe VARCHAR(20),
    MaGhe CHAR(10),
    MaSuat CHAR(10),
	MaTT CHAR(10),
	FOREIGN KEY (MaTT) REFERENCES ThanhToan(MaTT),
    FOREIGN KEY (MaGhe) REFERENCES Ghe(MaGhe),
    FOREIGN KEY (MaSuat) REFERENCES SuatChieu(MaSuat)
);

CREATE TABLE TaiPhong 
(
    MaPhong CHAR(10),
    MaSuat CHAR(10),
    PRIMARY KEY (MaPhong, MaSuat),
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong),
    FOREIGN KEY (MaSuat) REFERENCES SuatChieu(MaSuat)
);
DELETE FROM NhaCungCap;
--Nhập data cho bảng NCC
Insert Into NhaCungCap (MaNCC, TenNCC, DiaChi, SDT) 
values 
('NCC001', N'Công ty TNHH Bắp Rang Việt', N'Quận 10, TP.HCM', '0909123456'),
('NCC002', N'Công ty Nước Ngọt Pepsi VN', N'Quận Tân Bình, TP.HCM', '0911223344'),
('NCC003', N'Công ty TNHH Ghế Ngồi Rạp Việt', N'Biên Hòa, Đồng Nai', '0933778899'),
('NCC004', N'Công ty TNHH Thiết Bị Âm Thanh Rạp', N'Quận 5, TP.HCM', '0909112233'),
('NCC005', N'Công ty Đồ Ăn Nhanh MovieSnack', N'Thủ Đức, TP.HCM', '0909554433'),
('NCC006', N'Công ty TNHH Vé Xem Phim Thông Minh', N'Quận 3, TP.HCM', '0966889900'),
('NCC007', N'Công ty TNHH Bắp Caramel ABC', N'Mỹ Tho, Tiền Giang', '0977886655'),
('NCC008', N'Nhà Cung Cấp Quà Lưu Niệm Galaxy', N'Gò Vấp, TP.HCM', '0909887766'),
('NCC009', N'Công ty Dịch Vụ Thanh Toán Vé Online', N'Quận 1, TP.HCM', '0911335577'),
('NCC010', N'Công ty TNHH Snack Khoai Tây 123', N'Bình Thạnh, TP.HCM', '0909111222');

DELETE FROM Combo;
--Nhập data cho bảng Combo
Insert Into Combo (MaCombo, TenCombo, Gia) 
values
('CB001', N'Combo 1 vé + 1 bắp + 1 nước', 85000),
('CB002', N'Combo 2 vé + 1 bắp lớn + 2 nước', 160000),
('CB003', N'Combo 1 vé VIP + bắp caramel + nước lạnh', 120000),
('CB004', N'Combo học sinh - sinh viên (1 vé + nước)', 60000),
('CB005', N'Combo 2 vé ghế đôi + snack + 2 nước', 175000),
('CB006', N'Combo 1 vé + snack khoai tây', 70000),
('CB007', N'Combo gia đình (4 vé + 2 bắp + 4 nước)', 320000),
('CB008', N'Combo siêu tiết kiệm (1 vé + nước nhỏ)', 55000),
('CB009', N'Combo 3 vé + bắp vị phô mai + 3 nước', 245000),
('CB010', N'Combo người yêu: 2 vé đôi + 1 bắp + 2 nước', 180000);

--Nhập data cho bảng CungCap
INSERT INTO Cungcap (MaNCC, MaCombo) 
VALUES
('NCC001', 'CB001'),
('NCC002', 'CB002'),
('NCC003', 'CB003'),
('NCC004', 'CB004'),
('NCC005', 'CB005'),
('NCC006', 'CB006'),
('NCC007', 'CB007'),
('NCC008', 'CB008'),
('NCC009', 'CB009'),
('NCC010', 'CB010');

DELETE FROM DonCombo;
--Nhập data cho bảng DonCombo///
INSERT INTO DonCombo (MaDon, ThoiGian, TrangThaiDon, MaTT, MaTK) 
VALUES
('DC001', '2025-08-01 10:30:00', N'Đã thanh toán', 'TT001', 'TK001'),
('DC002', '2025-08-02 15:45:00', N'Chờ xử lý',     'TT002', 'TK002'),
('DC003', '2025-08-03 18:20:00', N'Đã huỷ',        'TT003', 'TK003'),
('DC004', '2025-08-04 12:00:00', N'Đã thanh toán', 'TT004', 'TK004'),
('DC005', '2025-08-05 20:15:00', N'Đã thanh toán', 'TT005', 'TK005'),
('DC006', '2025-08-06 08:50:00', N'Chờ xử lý',     'TT006', 'TK006'),
('DC007', '2025-08-07 11:10:00', N'Đã huỷ',        'TT007', 'TK007'),
('DC008', '2025-08-07 13:25:00', N'Đã thanh toán', 'TT008', 'TK008'),
('DC009', '2025-08-07 14:00:00', N'Chờ xử lý',     'TT009', 'TK009'),
('DC010', '2025-08-07 15:20:00', N'Đã thanh toán', 'TT010', 'TK010');

DELETE FROM TaiKhoan;
--Nhập data cho bảng TaiKhoan
INSERT INTO TaiKhoan (MaTK, TenND, Email, Mk, LoaiQuyen, SDT) 
VALUES
('TK001', N'Lê Minh Tuấn', 'tuanle@gmail.com', '123abc', 'User', '0901234567'),
('TK002', N'Nguyễn Thị Mai', 'mainguyen@yahoo.com', '123abc', 'User', '0912345678'),
('TK003', N'Phạm Văn Nam', 'nampham@gmail.com', '123abc', 'User', '0987654321'),
('TK004', N'Trần Quốc Bảo', 'quocbao@gmail.com', '123abc', 'Admin', '0909123123'),
('TK005', N'Đỗ Kim Ngân', 'kimngan@gmail.com', '123abc', 'User', '0977665544'),
('TK006', N'Hồ Thị Hồng', 'hongho@gmail.com', '123abc', 'User', '0938551122'),
('TK007', N'Ngô Văn Tùng', 'tungngo@gmail.com', '123abc', 'User', '0945123789'),
('TK008', N'Võ Thị Hạnh', 'hanhvo@gmail.com', '123abc', 'User', '0967888999'),
('TK009', N'Bùi Gia Hưng', 'hungbui@gmail.com', '123abc', 'User', '0923456789'),
('TK010', N'Lý Thị Ngọc', 'ngocly@gmail.com', '123abc', 'User', '0911223344');

DELETE FROM ThanhToan;
--Nhập data cho bảng ThanhToan
INSERT INTO ThanhToan (MaTT, MaTK, SoTien, PhuongThuc, TrangThaiTT, ThoiGianTT)
VALUES
('TT001', 'TK001', 85000, N'Momo', 'Đã thanh toán', '2025-08-01 14:25:00'),
('TT002', 'TK002', 160000, N'ZaloPay', 'Đã thanh toán', '2025-08-02 15:10:00'),
('TT003', 'TK003', 245000, N'Thẻ ATM', 'Đã thanh toán', '2025-08-03 12:45:00'),
('TT004', 'TK004', 60000, N'Tiền mặt', 'Đã thanh toán', '2025-08-04 16:05:00'),
('TT005', 'TK005', 175000, N'Momo', 'Chưa thanh toán', '2025-08-05 10:00:00'),
('TT006', 'TK006', 92000, N'Thẻ ATM', 'Đã thanh toán', '2025-08-06 09:30:00'),
('TT007', 'TK007', 135000, N'ZaloPay', 'Đã thanh toán', '2025-08-07 11:15:00'),
('TT008', 'TK008', 185000, N'Momo', 'Đã thanh toán', '2025-08-08 13:40:00'),
('TT009', 'TK009', 102000, N'Tiền mặt', 'Chưa thanh toán', '2025-08-09 17:55:00'),
('TT010', 'TK010', 158000, N'Thẻ ATM', 'Đã thanh toán', '2025-08-10 14:20:00');

DELETE FROM ChiTietCombo;
--Nhập data cho bảng ChiTietCombo
INSERT INTO ChiTietCombo (MaCombo, MaDon, SoLuong) 
VALUES
('CB001', 'DC001', 1),
('CB002', 'DC002', 1),
('CB003', 'DC003', 2),
('CB004', 'DC004', 1),
('CB005', 'DC005', 2),
('CB006', 'DC006', 1),
('CB007', 'DC007', 1),
('CB008', 'DC008', 1),
('CB009', 'DC009', 1),
('CB010', 'DC010', 3);

DELETE FROM NhanVien;
--Nhập data cho bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, ViTri) 
VALUES
('NV001', N'Lê Hồng Phúc', N'Quản lý'),
('NV002', N'Nguyễn Văn Hùng', N'Tiếp tân'),
('NV003', N'Phạm Thị Hoa', N'Hỗ trợ khách hàng'),
('NV004', N'Trần Văn Khánh', N'Nhân viên bán vé'),
('NV005', N'Đặng Thị Linh', N'Kỹ thuật viên máy chiếu'),
('NV006', N'Ngô Văn Bình', N'Nhân viên phục vụ'),
('NV007', N'Lý Thị Trang', N'Nhân viên kiểm soát vé'),
('NV008', N'Tạ Minh Tâm', N'Nhân viên thu ngân'),
('NV009', N'Vũ Quang Hải', N'Bảo vệ'),
('NV010', N'Hoàng Thị Ngọc', N'Quản trị hệ thống');

DELETE FROM PhanHoi;
--Nhập data cho bảng PhanHoi
INSERT INTO PhanHoi (MaPH, NoiDung, NgayGui, MaTK, MaNV, TrangThaiPH) 
VALUES
('PH001', N'Dịch vụ tốt, nhân viên thân thiện.', '2025-08-01 14:40:00', 'TK001', 'NV003', N'Đã xử lý'),
('PH002', N'Tôi gặp lỗi khi thanh toán.', '2025-08-02 15:30:00', 'TK002', 'NV003', N'Đang xử lý'),
('PH003', N'Trải nghiệm xem phim rất tuyệt!', '2025-08-03 10:00:00', 'TK003', 'NV001', N'Đã xử lý'),
('PH004', N'Phòng chiếu bị lạnh quá mức.', '2025-08-03 17:45:00', 'TK005', 'NV004', N'Đang xử lý'),
('PH005', N'Mong có thêm suất chiếu ban đêm.', '2025-08-04 09:15:00', 'TK001', 'NV002', N'Chưa xử lý'),
('PH006', N'Nhân viên bán vé chưa thân thiện.', '2025-08-04 12:00:00', 'TK002', 'NV004', N'Đã xử lý'),
('PH007', N'Máy lạnh hoạt động không đều.', '2025-08-05 14:30:00', 'TK003', 'NV005', N'Đang xử lý'),
('PH008', N'Tôi không nhận được vé qua email.', '2025-08-05 15:50:00', 'TK005', 'NV006', N'Chưa xử lý'),
('PH009', N'Thức ăn hơi đắt so với chất lượng.', '2025-08-06 13:00:00', 'TK004', 'NV007', N'Đã xử lý'),
('PH010', N'Hệ thống đặt vé online bị lỗi.', '2025-08-06 20:10:00', 'TK001', 'NV010', N'Đang xử lý');

DELETE FROM BaoCao;
--Nhập data cho bảng BaoCao
INSERT INTO BaoCao (MaBC, TieuDeBC, NoiDungBC, LoaiBC, NgayLapBC, NguoiLapBC, MaNV) 
VALUES
('BC001', N'Báo cáo doanh thu tháng 8', N'Doanh thu tăng 15%', N'Doanh thu', '2025-08-05', N'Lê Hồng Phúc', 'NV001'),
('BC002', N'Phản hồi khách hàng tuần 1', N'Chủ yếu hài lòng với dịch vụ', N'Khách hàng', '2025-08-06', N'Phạm Thị Hoa', 'NV003'),
('BC003', N'Tình trạng thiết bị chiếu', N'Máy chiếu phòng 2 cần bảo trì', N'Kỹ thuật', '2025-08-06', N'Đặng Thị Linh', 'NV005'),
('BC004', N'Báo cáo sự cố hệ thống', N'Lỗi đặt vé online ngày 5/8', N'Kỹ thuật', '2025-08-06', N'Hoàng Thị Ngọc', 'NV010'),
('BC005', N'Thống kê bán vé tuần 1', N'Đã bán 350 vé từ 1-7/8', N'Doanh thu', '2025-08-07', N'Tạ Minh Tâm', 'NV008'),
('BC006', N'Phản hồi tiêu cực từ khách hàng', N'4 ý kiến chưa hài lòng dịch vụ', N'Khách hàng', '2025-08-07', N'Nguyễn Văn Hùng', 'NV002'),
('BC007', N'Hiệu suất làm việc nhân viên', N'Nhân viên bán vé phản hồi chậm', N'Nhân sự', '2025-08-07', N'Trần Văn Khánh', 'NV004'),
('BC008', N'Tình hình ghế hỏng', N'3 ghế phòng 1 bị hư chốt lưng', N'Kỹ thuật', '2025-08-07', N'Ngô Văn Bình', 'NV006'),
('BC009', N'Kiểm kê vật tư tháng 8', N'Thức ăn kho chưa được bổ sung', N'Kho', '2025-08-07', N'Lý Thị Trang', 'NV007'),
('BC010', N'Phân tích suất chiếu hiệu quả', N'Suất 18h có lượng khách cao nhất', N'Kinh doanh', '2025-08-07', N'Vũ Quang Hải', 'NV009');

DELETE FROM KhuyenMai;
--Nhập data cho bảng KhuyenMai
INSERT INTO KhuyenMai (MaKM, NoiDungKM, NgayBD, NgayKT, DoiTuongApDung, TrangThaiKM) 
VALUES
('KM001', N'Giảm 10% cho học sinh', '2025-08-01', '2025-08-31', N'Học sinh', N'Còn hiệu lực'),
('KM002', N'Tặng nước miễn phí cho đơn trên 150k', '2025-08-01', '2025-08-20', N'Tất cả', N'Hết hạn'),
('KM003', N'Mua 1 tặng 1 vé xem phim', '2025-08-05', '2025-08-15', N'Sinh viên', N'Còn hiệu lực'),
('KM004', N'Giảm 20% cho vé nhóm từ 4 người', '2025-08-01', '2025-08-31', N'Khách nhóm', N'Còn hiệu lực'),
('KM005', N'Ưu đãi 15% cho thành viên mới', '2025-08-10', '2025-08-25', N'Thành viên mới', N'Còn hiệu lực'),
('KM006', N'Vé xem phim chỉ 39k vào thứ 3', '2025-08-01', '2025-08-30', N'Tất cả', N'Còn hiệu lực'),
('KM007', N'Tặng bắp miễn phí cho vé VIP', '2025-07-25', '2025-08-25', N'Vé VIP', N'Còn hiệu lực'),
('KM008', N'Tặng voucher 50k cho đơn combo', '2025-08-01', '2025-08-15', N'Tất cả', N'Hết hạn'),
('KM009', N'Giảm 30% vé suất chiếu sáng sớm', '2025-08-05', '2025-08-31', N'Tất cả', N'Còn hiệu lực'),
('KM010', N'Quà tặng đặc biệt cho khách hàng thân thiết', '2025-08-01', '2025-08-31', N'Thân thiết', N'Còn hiệu lực');

DELETE FROM NhanKhuyenMai;
--Nhập data cho bảng NhanKhuyenMai
INSERT INTO NhanKhuyenMai (MaKM, MaTK, ThoiGianNhan) 
VALUES
('KM001', 'TK005', '10:00:00'),
('KM002', 'TK001', '11:30:00'),
('KM003', 'TK002', '14:15:00'),
('KM004', 'TK003', '09:45:00'),
('KM001', 'TK004', '13:20:00'),
('KM005', 'TK006', '16:50:00'),
('KM002', 'TK007', '12:10:00'),
('KM003', 'TK008', '08:30:00'),
('KM004', 'TK009', '15:05:00'),
('KM005', 'TK010', '17:25:00');

--Nhập data cho bảng PhongChieu
INSERT INTO PhongChieu (MaPhong, TenPhong, SoGhe, TrangThaiPhong) 
VALUES
('P001', N'Phòng 1 - Standard', 50, N'Đang hoạt động'),
('P002', N'Phòng 2 - VIP', 30, N'Đang bảo trì'),
('P003', N'Phòng 3 - IMAX', 70, N'Đang hoạt động'),
('P004', N'Phòng 4 - 3D', 60, N'Đang hoạt động'),
('P005', N'Phòng 5 - Standard', 45, N'Đang bảo trì'),
('P006', N'Phòng 6 - 4DX', 55, N'Đang hoạt động'),
('P007', N'Phòng 7 - VIP', 35, N'Đang hoạt động'),
('P008', N'Phòng 8 - Standard', 40, N'Đang hoạt động'),
('P009', N'Phòng 9 - IMAX', 65, N'Đang bảo trì'),
('P010', N'Phòng 10 - 3D', 50, N'Đang hoạt động');

--Nhập data cho bảng Ghe
INSERT INTO Ghe (MaGhe, TenGhe, TrangThai, MaPhong) 
VALUES
('G001', N'A1', N'Trống', 'P001'),
('G002', N'A2', N'Đã đặt', 'P001'),
('G003', N'A1', N'Trống', 'P002'),
('G004', N'A2', N'Đã đặt', 'P002'),
('G005', N'A1', N'Trống', 'P003'),
('G006', N'A2', N'Đã đặt', 'P003'),
('G007', N'A1', N'Trống', 'P004'),
('G008', N'A2', N'Đã đặt', 'P004'),
('G009', N'A1', N'Trống', 'P005'),
('G010', N'A2', N'Đã đặt', 'P005'),
('G011', N'A1', N'Trống', 'P006'),
('G012', N'A2', N'Đã đặt', 'P006'),
('G013', N'A1', N'Trống', 'P007'),
('G014', N'A2', N'Đã đặt', 'P007'),
('G015', N'A1', N'Trống', 'P008'),
('G016', N'A2', N'Đã đặt', 'P008'),
('G017', N'A1', N'Trống', 'P009'),
('G018', N'A2', N'Đã đặt', 'P009'),
('G019', N'A1', N'Trống', 'P010'),
('G020', N'A2', N'Đã đặt', 'P010');

--Nhập data cho bảng Phim
INSERT INTO Phim (MaPhim, TenPhim, TieuDe, TheLoai, MoTa, ThoiLuong) 
VALUES
('PH001', N'Avengers: Endgame', N'Hồi kết', N'Hành động, Khoa học viễn tưởng', N'Các siêu anh hùng hợp lực chống lại Thanos để cứu vũ trụ.', 181),
('PH002', N'The Lion King', N'Vua sư tử', N'Hoạt hình, Phiêu lưu', N'Hành trình trở lại và giành lại vương quốc của Simba.', 118),
('PH003', N'Titanic', N'Con tàu định mệnh', N'Tình cảm', N'Tình yêu vượt thời gian trên con tàu Titanic.', 195),
('PH004', N'Inception', N'Kẻ đánh cắp giấc mơ', N'Hành động, Khoa học viễn tưởng', N'Hành trình xâm nhập vào tiềm thức để cấy ghép ý tưởng.', 148),
('PH005', N'Minions', N'Những tay sai ngốc nghếch', N'Hoạt hình, Hài hước', N'Cuộc phiêu lưu hài hước của những chú Minions trung thành.', 91),
('PH006', N'Parasite', N'Ký sinh trùng', N'Tâm lý, Giật gân', N'Cuộc sống trái ngược giữa hai gia đình giàu và nghèo.', 132),
('PH007', N'Spider-Man: No Way Home', N'Người Nhện: Không còn nhà', N'Hành động, Khoa học viễn tưởng', N'Người Nhện mở cánh cổng đa vũ trụ và đối đầu các kẻ thù từ vũ trụ khác.', 148),
('PH008', N'Soul', N'Linh hồn', N'Hoạt hình, Tâm lý', N'Một nghệ sĩ nhạc jazz tìm lại ý nghĩa của cuộc sống sau khi lạc vào thế giới linh hồn.', 100),
('PH009', N'The Conjuring', N'Ám ảnh kinh hoàng', N'Kinh dị', N'Cặp đôi trừ tà đối mặt với thế lực siêu nhiên trong ngôi nhà ma ám.', 112),
('PH010', N'Fast & Furious 9', N'Quá nhanh quá nguy hiểm 9', N'Hành động', N'Cuộc đối đầu kịch tính giữa Dominic Toretto và em trai mình.', 145);

--Nhập data cho bảng SuatChieu
INSERT INTO SuatChieu (MaSuat, MaPhim, NgayChieu, GioBatDau, GioKetThuc) 
VALUES
('SC001', 'PH001', '2025-08-07', '18:00:00', '21:01:00'),
('SC002', 'PH002', '2025-08-07', '15:00:00', '16:40:00'),
('SC003', 'PH003', '2025-08-08', '13:00:00', '14:45:00'),
('SC004', 'PH004', '2025-08-08', '20:00:00', '22:15:00'),
('SC005', 'PH005', '2025-08-09', '10:00:00', '11:30:00'),
('SC006', 'PH006', '2025-08-09', '16:00:00', '18:00:00'),
('SC007', 'PH007', '2025-08-10', '14:30:00', '16:50:00'),
('SC008', 'PH008', '2025-08-10', '19:00:00', '21:20:00'),
('SC009', 'PH009', '2025-08-11', '17:00:00', '18:45:00'),
('SC010', 'PH010', '2025-08-11', '20:15:00', '22:30:00');

--Nhập data cho bảng Ve
INSERT INTO Ve (MaVe, MaQR, TrangThaiVe, MaGhe, MaSuat, MaTT) 
VALUES
('VE001', 0x123456, N'Đã dùng',   'G001', 'SC001', 'TT001'),
('VE002', 0x654321, N'Chưa dùng', 'G002', 'SC002', 'TT002'),
('VE003', 0xA1B2C3, N'Đã dùng',   'G003', 'SC003', 'TT003'),
('VE004', 0xC3D4E5, N'Chưa dùng', 'G004', 'SC004', 'TT004'),
('VE005', 0xF6E7D8, N'Đã dùng',   'G005', 'SC005', 'TT005'),
('VE006', 0xABCDEF, N'Chưa dùng', 'G006', 'SC006', 'TT006'),
('VE007', 0x112233, N'Đã dùng',   'G007', 'SC007', 'TT007'),
('VE008', 0x445566, N'Chưa dùng', 'G008', 'SC008', 'TT008'),
('VE009', 0x778899, N'Đã dùng',   'G009', 'SC009', 'TT009'),
('VE010', 0xDEADBE, N'Chưa dùng', 'G010', 'SC010', 'TT010');

--Nhập data cho bảng TaiPhong
INSERT INTO TaiPhong (MaPhong, MaSuat) 
VALUES
('P001', 'SC001'),
('P002', 'SC002'),
('P003', 'SC003'),
('P004', 'SC004'),
('P005', 'SC005'),
('P001', 'SC006'),
('P002', 'SC007'),
('P003', 'SC008'),
('P004', 'SC009'),
('P005', 'SC010');