USE [master]
GO
/****** Object:  Database [OnlineTesting]    Script Date: 9/12/2024 11:38:41 AM ******/
CREATE DATABASE [OnlineTesting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineTesting', FILENAME = N'D:\QTHCSDL\OnlineTesting.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OnlineTesting_log', FILENAME = N'D:\QTHCSDL\OnlineTesting_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [OnlineTesting] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineTesting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineTesting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineTesting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineTesting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineTesting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineTesting] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineTesting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineTesting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineTesting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineTesting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineTesting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineTesting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineTesting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineTesting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineTesting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineTesting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineTesting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineTesting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineTesting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineTesting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineTesting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineTesting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineTesting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineTesting] SET RECOVERY FULL 
GO
ALTER DATABASE [OnlineTesting] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineTesting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineTesting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineTesting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineTesting] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineTesting] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OnlineTesting] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnlineTesting', N'ON'
GO
ALTER DATABASE [OnlineTesting] SET QUERY_STORE = ON
GO
ALTER DATABASE [OnlineTesting] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [OnlineTesting]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id_admin] [char](10) NOT NULL,
	[cap_do_quan_tri] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaThi]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaThi](
	[id_CaThi] [int] IDENTITY(1,1) NOT NULL,
	[gio_bat_dau] [time](7) NULL,
	[gio_ket_thuc] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_CaThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[id_CauHoi] [int] IDENTITY(1,1) NOT NULL,
	[cau_hoi] [nvarchar](255) NULL,
	[id_MonHoc] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_CauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietCauHoi]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCauHoi](
	[id_ChiTietCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[id_CauHoi] [int] NULL,
	[cau_tra_loi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ChiTietCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DapAn]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DapAn](
	[id_DapAn] [int] IDENTITY(1,1) NOT NULL,
	[id_ChiTietCauHoi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_DapAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[id_diem] [int] IDENTITY(1,1) NOT NULL,
	[id_sv] [char](10) NULL,
	[diem] [float] NULL,
	[id_Lop_MonHoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_diem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[id_GiangVien] [char](10) NOT NULL,
	[bang_cap] [nvarchar](100) NULL,
	[kinh_nghiem] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_GiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien_MonHoc]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien_MonHoc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_GiangVien] [char](10) NULL,
	[id_MonHoc] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[id_HocKy] [varchar](50) NOT NULL,
	[hoc_ky] [int] NULL,
	[nam_hoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_HocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQuaBaiLam]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaBaiLam](
	[id_kqbl] [int] IDENTITY(1,1) NOT NULL,
	[script_dap_an] [nvarchar](255) NULL,
	[id_LichThi] [int] NULL,
	[id_SinhVien] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_kqbl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichThi]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichThi](
	[id_LichThi] [int] IDENTITY(1,1) NOT NULL,
	[ngay_thi] [date] NULL,
	[thoi_gian_thi] [time](7) NULL,
	[quy_che_thi] [nvarchar](255) NULL,
	[id_CaThi] [int] NULL,
	[id_LopHoc_MonHoc] [int] NULL,
	[so_cau] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_LichThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [LichThi_MonHoc_NgayThi_CaThi_uniquetogether] UNIQUE NONCLUSTERED 
(
	[id_LichThi] ASC,
	[id_LopHoc_MonHoc] ASC,
	[id_CaThi] ASC,
	[ngay_thi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[id_Lop] [char](10) NOT NULL,
	[ten_lop] [nvarchar](100) NULL,
	[si_so] [int] NULL,
	[tinh_trang_lop] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc_MonHoc]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc_MonHoc](
	[id_LopHoc_MonHoc] [int] IDENTITY(1,1) NOT NULL,
	[id_LopHoc] [char](10) NULL,
	[id_MonHoc] [char](10) NULL,
	[HocKy] [int] NULL,
	[NamHoc] [int] NULL,
	[ngay_bat_dau] [date] NULL,
	[id_GiangVien] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_LopHoc_MonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[id_MonHoc] [char](10) NOT NULL,
	[ten_mon_hoc] [nvarchar](255) NULL,
	[so_tin_chi] [int] NULL,
	[tinh_trang_mon] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_MonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[id_user] [char](10) NOT NULL,
	[ho_ten] [nvarchar](255) NOT NULL,
	[dia_chi] [nvarchar](255) NULL,
	[ngay_sinh] [date] NULL,
	[SDT] [varchar](20) NULL,
	[Username] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[UserRole] [nvarchar](255) NULL,
 CONSTRAINT [PK__NguoiDun__D2D1463708D816F7] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[mssv] [char](10) NOT NULL,
	[nam_nhap_hoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_DangKyMon]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_DangKyMon](
	[id_Lop_MonHoc] [int] NOT NULL,
	[mssv] [char](10) NOT NULL,
	[trang_thai] [nvarchar](10) NULL,
 CONSTRAINT [PK_DangKyMon] PRIMARY KEY CLUSTERED 
(
	[id_Lop_MonHoc] ASC,
	[mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_LopHoc]    Script Date: 9/12/2024 11:38:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_LopHoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_MSSV] [char](10) NOT NULL,
	[Id_Lop] [char](10) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK__Admin__id_admin__398D8EEE] FOREIGN KEY([id_admin])
REFERENCES [dbo].[NguoiDung] ([id_user])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK__Admin__id_admin__398D8EEE]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD FOREIGN KEY([id_MonHoc])
REFERENCES [dbo].[MonHoc] ([id_MonHoc])
GO
ALTER TABLE [dbo].[ChiTietCauHoi]  WITH CHECK ADD FOREIGN KEY([id_CauHoi])
REFERENCES [dbo].[CauHoi] ([id_CauHoi])
GO
ALTER TABLE [dbo].[DapAn]  WITH CHECK ADD FOREIGN KEY([id_ChiTietCauHoi])
REFERENCES [dbo].[ChiTietCauHoi] ([id_ChiTietCauHoi])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([id_sv])
REFERENCES [dbo].[SinhVien] ([mssv])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_LopHoc_MonHoc] FOREIGN KEY([id_Lop_MonHoc])
REFERENCES [dbo].[LopHoc_MonHoc] ([id_LopHoc_MonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_LopHoc_MonHoc]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK__GiangVien__id_Gi__3F466844] FOREIGN KEY([id_GiangVien])
REFERENCES [dbo].[NguoiDung] ([id_user])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK__GiangVien__id_Gi__3F466844]
GO
ALTER TABLE [dbo].[GiangVien_MonHoc]  WITH CHECK ADD FOREIGN KEY([id_GiangVien])
REFERENCES [dbo].[GiangVien] ([id_GiangVien])
GO
ALTER TABLE [dbo].[GiangVien_MonHoc]  WITH CHECK ADD FOREIGN KEY([id_MonHoc])
REFERENCES [dbo].[MonHoc] ([id_MonHoc])
GO
ALTER TABLE [dbo].[KetQuaBaiLam]  WITH CHECK ADD FOREIGN KEY([id_LichThi])
REFERENCES [dbo].[LichThi] ([id_LichThi])
GO
ALTER TABLE [dbo].[KetQuaBaiLam]  WITH CHECK ADD FOREIGN KEY([id_SinhVien])
REFERENCES [dbo].[SinhVien] ([mssv])
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD FOREIGN KEY([id_CaThi])
REFERENCES [dbo].[CaThi] ([id_CaThi])
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD  CONSTRAINT [FK_LichThi_LopHoc_MonHoc] FOREIGN KEY([id_LopHoc_MonHoc])
REFERENCES [dbo].[LopHoc_MonHoc] ([id_LopHoc_MonHoc])
GO
ALTER TABLE [dbo].[LichThi] CHECK CONSTRAINT [FK_LichThi_LopHoc_MonHoc]
GO
ALTER TABLE [dbo].[LopHoc_MonHoc]  WITH CHECK ADD FOREIGN KEY([id_LopHoc])
REFERENCES [dbo].[Lop] ([id_Lop])
GO
ALTER TABLE [dbo].[LopHoc_MonHoc]  WITH CHECK ADD FOREIGN KEY([id_MonHoc])
REFERENCES [dbo].[MonHoc] ([id_MonHoc])
GO
ALTER TABLE [dbo].[LopHoc_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_MonHoc_GiangVien] FOREIGN KEY([id_GiangVien])
REFERENCES [dbo].[GiangVien] ([id_GiangVien])
GO
ALTER TABLE [dbo].[LopHoc_MonHoc] CHECK CONSTRAINT [FK_LopHoc_MonHoc_GiangVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [fk_student_user] FOREIGN KEY([mssv])
REFERENCES [dbo].[NguoiDung] ([id_user])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [fk_student_user]
GO
ALTER TABLE [dbo].[SinhVien_DangKyMon]  WITH CHECK ADD FOREIGN KEY([id_Lop_MonHoc])
REFERENCES [dbo].[LopHoc_MonHoc] ([id_LopHoc_MonHoc])
GO
ALTER TABLE [dbo].[SinhVien_DangKyMon]  WITH CHECK ADD FOREIGN KEY([mssv])
REFERENCES [dbo].[SinhVien] ([mssv])
GO
USE [master]
GO
ALTER DATABASE [OnlineTesting] SET  READ_WRITE 
GO
