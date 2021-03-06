USE [Quanlidoansinhvien]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[IDBaoCao] [nchar](10) NOT NULL,
	[IDDeTai] [nvarchar](50) NULL,
	[LanBaoCao] [int] NULL,
	[TaiLieu] [nvarchar](100) NULL,
	[NhanXet] [nvarchar](500) NULL,
	[DiemTong] [float] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NhanXetTheoTuan] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeTai]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeTai](
	[ID] [nvarchar](50) NOT NULL,
	[TenDeTai] [nvarchar](50) NULL,
	[LoaiDeTai] [nvarchar](50) NULL,
	[GiaoVienHuongDan] [nvarchar](50) NULL,
	[MoTa] [nvarchar](1000) NULL,
	[SoLuongSinhVien] [int] NULL,
	[ThoiGianBatDau] [date] NULL,
	[ThoiGianKetThuc] [date] NULL,
	[SoLanBaoCao] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_DeTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[ID] [nvarchar](50) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
	[TruongKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDeTai]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDeTai](
	[ID] [nvarchar](50) NOT NULL,
	[LoaiDeTai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_LoaiDeTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[PhanQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login_1] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[ID] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[HeDaoTao] [nvarchar](50) NULL,
	[LopTruong] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/25/2020 8:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [nvarchar](100) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[Lop] [nvarchar](50) NULL,
	[khoa] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[DeTai] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BaoCao] ([IDBaoCao], [IDDeTai], [LanBaoCao], [TaiLieu], [NhanXet], [DiemTong], [TrangThai]) VALUES (N'bc1       ', N'dt1', 1, N'abc', N'abc', 1, 0)
INSERT [dbo].[BaoCao] ([IDBaoCao], [IDDeTai], [LanBaoCao], [TaiLieu], [NhanXet], [DiemTong], [TrangThai]) VALUES (N'bc2       ', N'dt1', 2, N'dsd', N'sdd', 9, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [LoaiDeTai], [GiaoVienHuongDan], [MoTa], [SoLuongSinhVien], [ThoiGianBatDau], [ThoiGianKetThuc], [SoLanBaoCao], [TinhTrang]) VALUES (N'dt1', N'Đề tài 1', N'DACK', N'gv2', N'không có gì', 2, CAST(N'2020-06-12' AS Date), CAST(N'2020-06-13' AS Date), 2, 0)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [LoaiDeTai], [GiaoVienHuongDan], [MoTa], [SoLuongSinhVien], [ThoiGianBatDau], [ThoiGianKetThuc], [SoLanBaoCao], [TinhTrang]) VALUES (N'dt2', N'Đề tài 2', N'DACK', N'gv2', N'không có gì', 3, CAST(N'2020-06-25' AS Date), CAST(N'2020-08-21' AS Date), 3, 0)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [LoaiDeTai], [GiaoVienHuongDan], [MoTa], [SoLuongSinhVien], [ThoiGianBatDau], [ThoiGianKetThuc], [SoLanBaoCao], [TinhTrang]) VALUES (N'dt3', N'Đề tài 3', N'DACK', N'gv3', N'không có gì', 2, CAST(N'2020-06-25' AS Date), CAST(N'2020-06-26' AS Date), 2, 0)
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [Khoa], [DiaChi], [Sdt]) VALUES (N'gv1', N'a', CAST(N'2000-02-01' AS Date), 1, N'giảng viên', N'DDT', N'a', N'1323')
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [Khoa], [DiaChi], [Sdt]) VALUES (N'gv2', N'dsds', CAST(N'2000-02-08' AS Date), 0, N'dsd', N'CNTT', N'SÁ', N'123')
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [Khoa], [DiaChi], [Sdt]) VALUES (N'gv3', N'dsds', CAST(N'2000-06-14' AS Date), 0, N'sdsd', N'CNTT', N'DSDS', N'123')
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [Khoa], [DiaChi], [Sdt]) VALUES (N'gv4', N'av', CAST(N'2000-06-13' AS Date), 1, N'dv', N'CNTT', N'cc', N'4561')
INSERT [dbo].[GiaoVien] ([ID], [Ten], [NgaySinh], [GioiTinh], [ChucVu], [Khoa], [DiaChi], [Sdt]) VALUES (N'gv5', N'sad', CAST(N'2000-06-13' AS Date), 1, N'sadas', N'CNTT', N'fdsfs', N'4561')
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'CKCTM', N'Cơ Khí Chế Tạo Máy', NULL)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'CKDL', N'Cơ Khí Động Lực', NULL)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'CLC', N'Đào Tạo Chất Lượng Cao', NULL)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'CNTT', N'Công Nghệ Thông Tin', N'Lê Văn Vinh')
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'DDT', N'Điện-Điện Tử', NULL)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'KT', N'Kinh Tế', NULL)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [TruongKhoa]) VALUES (N'XD', N'Xây Dựng', NULL)
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'DACK', N'Đồ án cuối kỳ', N'Đánh giá kiến thức của 1 môn học')
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'KLTN', N'Khóa Luận Tốt Nghiệp', N'Đánh giá năng lực của sinh viên đã đủ để tốt nghiệp chưa. ')
INSERT [dbo].[LoaiDeTai] ([ID], [LoaiDeTai], [MoTa]) VALUES (N'TLCN', N'Tiểu Luận Chuyên Ngành', N'Đánh giá chuyên ngành sinh viên theo học')
INSERT [dbo].[Login] ([Username], [Password], [PhanQuyen]) VALUES (N'giaovien', N'123', N'1')
INSERT [dbo].[Login] ([Username], [Password], [PhanQuyen]) VALUES (N'sinhvien', N'123', N'2')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL1A', N'17110CL1A', N'Chính Quy', N'A')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL1B', N'17110CL1B', N'Chính Quy', N'B')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL1C', N'17110CL1C', N'Chính Quy', N'C')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL2A', N'17110CL2A', N'Chính Quy', N'D')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL2B', N'17110CL2B', N'Chính Quy', N'E')
INSERT [dbo].[Lop] ([ID], [TenLop], [HeDaoTao], [LopTruong]) VALUES (N'CL2C', N'17110CL2C', N'CLC', N'F')
INSERT [dbo].[SinhVien] ([ID], [Ten], [GioiTinh], [NgaySinh], [Lop], [khoa], [DiaChi], [Sdt], [DeTai]) VALUES (N'17110130', N'Nguyễn Văn Hà', 1, CAST(N'2000-02-02' AS Date), N'CL1A', N'CKCTM', N'abc', N'09853146', N'dt1')
INSERT [dbo].[SinhVien] ([ID], [Ten], [GioiTinh], [NgaySinh], [Lop], [khoa], [DiaChi], [Sdt], [DeTai]) VALUES (N'17110230', N'Nguyễn Văn Thắng', 1, CAST(N'2000-02-01' AS Date), N'CL1B', N'CLC', N'01 Võ Văn Ngâng', N'0971484530', N'dt1')
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_DeTai] FOREIGN KEY([IDDeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[BaoCao] CHECK CONSTRAINT [FK_BaoCao_DeTai]
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [FK_DeTai_GiaoVien] FOREIGN KEY([GiaoVienHuongDan])
REFERENCES [dbo].[GiaoVien] ([ID])
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [FK_DeTai_GiaoVien]
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [FK_DeTai_LoaiDeTai] FOREIGN KEY([LoaiDeTai])
REFERENCES [dbo].[LoaiDeTai] ([ID])
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [FK_DeTai_LoaiDeTai]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Khoa] FOREIGN KEY([Khoa])
REFERENCES [dbo].[Khoa] ([ID])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_DeTai] FOREIGN KEY([DeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_DeTai]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY([khoa])
REFERENCES [dbo].[Khoa] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([Lop])
REFERENCES [dbo].[Lop] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
