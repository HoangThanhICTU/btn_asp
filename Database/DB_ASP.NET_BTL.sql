USE [master]
GO
/****** Object:  Database [sql_btl_asp]    Script Date: 28/06/2021 4:08:40 CH ******/
CREATE DATABASE [sql_btl_asp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sql_btl_asp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\sql_btl_asp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sql_btl_asp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\sql_btl_asp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sql_btl_asp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sql_btl_asp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sql_btl_asp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sql_btl_asp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sql_btl_asp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sql_btl_asp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sql_btl_asp] SET ARITHABORT OFF 
GO
ALTER DATABASE [sql_btl_asp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sql_btl_asp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sql_btl_asp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sql_btl_asp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sql_btl_asp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sql_btl_asp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sql_btl_asp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sql_btl_asp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sql_btl_asp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sql_btl_asp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sql_btl_asp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sql_btl_asp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sql_btl_asp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sql_btl_asp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sql_btl_asp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sql_btl_asp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sql_btl_asp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sql_btl_asp] SET RECOVERY FULL 
GO
ALTER DATABASE [sql_btl_asp] SET  MULTI_USER 
GO
ALTER DATABASE [sql_btl_asp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sql_btl_asp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sql_btl_asp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sql_btl_asp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sql_btl_asp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sql_btl_asp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sql_btl_asp', N'ON'
GO
ALTER DATABASE [sql_btl_asp] SET QUERY_STORE = OFF
GO
USE [sql_btl_asp]
GO
/****** Object:  Table [dbo].[DatVe]    Script Date: 28/06/2021 4:08:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatVe](
	[ID] [int] NOT NULL,
	[code_v] [nvarchar](10) NULL,
	[name_kh] [ntext] NULL,
	[id_card] [nvarchar](12) NULL,
	[phone_kh] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangMayBay]    Script Date: 28/06/2021 4:08:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangMayBay](
	[ID] [int] NOT NULL,
	[code] [nvarchar](10) NULL,
	[name_h] [ntext] NULL,
	[address_h] [ntext] NULL,
	[phone_h] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinVe]    Script Date: 28/06/2021 4:08:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinVe](
	[ID] [int] NOT NULL,
	[code_v] [nvarchar](10) NULL,
	[type_v] [ntext] NULL,
	[price_v] [int] NULL,
	[datetime_start] [datetime] NULL,
	[point_start] [ntext] NULL,
	[datetime_end] [datetime] NULL,
	[point_end] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DatVe] ([ID], [code_v], [name_kh], [id_card], [phone_kh]) VALUES (2, N'002', N'Lao Thi Thanh Thao', N'123456788', N'0363012470')
GO
INSERT [dbo].[HangMayBay] ([ID], [code], [name_h], [address_h], [phone_h]) VALUES (3, N'BL', N'Jetstar Pacific Airlines', N'VietNam', N'0363012470')
INSERT [dbo].[HangMayBay] ([ID], [code], [name_h], [address_h], [phone_h]) VALUES (4, N'QH', N'Bamboo Airways', N'VietNam', N'0363012470')
GO
INSERT [dbo].[ThongTinVe] ([ID], [code_v], [type_v], [price_v], [datetime_start], [point_start], [datetime_end], [point_end]) VALUES (1, N'002', N'Thương gia', 1000000, CAST(N'2021-06-17T20:00:00.000' AS DateTime), N'Hà N?i', CAST(N'2021-06-17T21:00:00.000' AS DateTime), N'H? Chí Minh')
GO
USE [master]
GO
ALTER DATABASE [sql_btl_asp] SET  READ_WRITE 
GO
