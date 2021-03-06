USE [master]
GO
/****** Object:  Database [uye]    Script Date: 10.5.2019 08:05:13 ******/
CREATE DATABASE [uye]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'uyeler', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\uyeler.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'uyeler_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\uyeler_log.ldf' , SIZE = 6912KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [uye] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [uye].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [uye] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [uye] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [uye] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [uye] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [uye] SET ARITHABORT OFF 
GO
ALTER DATABASE [uye] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [uye] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [uye] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [uye] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [uye] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [uye] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [uye] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [uye] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [uye] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [uye] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [uye] SET  DISABLE_BROKER 
GO
ALTER DATABASE [uye] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [uye] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [uye] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [uye] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [uye] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [uye] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [uye] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [uye] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [uye] SET  MULTI_USER 
GO
ALTER DATABASE [uye] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [uye] SET DB_CHAINING OFF 
GO
ALTER DATABASE [uye] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [uye] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [uye]
GO
/****** Object:  Table [dbo].[hizliKayit]    Script Date: 10.5.2019 08:05:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hizliKayit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nchar](11) NULL,
 CONSTRAINT [PK_hizliKayit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[salon]    Script Date: 10.5.2019 08:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[uyeId] [nchar](5) NULL,
	[uyeSira] [varchar](200) NULL,
 CONSTRAINT [PK_salon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salon2]    Script Date: 10.5.2019 08:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salon2](
	[uyeSira] [int] IDENTITY(1,1) NOT NULL,
	[uyeId] [nchar](5) NULL,
 CONSTRAINT [PK_salon2] PRIMARY KEY CLUSTERED 
(
	[uyeSira] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[urunler]    Script Date: 10.5.2019 08:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[v_Id] [varchar](5) NULL,
	[urunAd] [nchar](30) NULL,
	[urunFiyat] [int] NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[uyeler]    Script Date: 10.5.2019 08:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[uyeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[adsoyad] [varchar](30) NULL,
	[tel] [varchar](11) NULL,
	[sehir] [varchar](20) NULL,
	[unvan] [nchar](20) NULL,
	[sirket] [nchar](20) NULL,
	[kayitTarihi] [varchar](50) NULL,
	[ekleyen] [nchar](10) NULL,
 CONSTRAINT [PK_uyeler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vipUyeler]    Script Date: 10.5.2019 08:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vipUyeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[v_Id] [varchar](5) NULL,
	[v_AdSoyad] [varchar](30) NULL,
	[v_Tel] [varchar](11) NULL,
	[v_Sehir] [varchar](30) NULL,
	[v_Etkinlik] [varchar](15) NULL,
	[v_Bakiye] [int] NULL,
	[v_KalanBakiye] [int] NULL,
	[v_Tarih] [varchar](50) NULL,
	[v_ResimYolu] [varchar](200) NULL,
 CONSTRAINT [PK_vipUyeler_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[hizliKayit] ON 

INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (2, N'11111111111')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (9, N'11111111114')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (6, N'12312321321')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (3, N'22222222222')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (8, N'23333333333')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (5, N'34222222222')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (4, N'34433333333')
INSERT [dbo].[hizliKayit] ([Id], [tc]) VALUES (7, N'43555555555')
SET IDENTITY_INSERT [dbo].[hizliKayit] OFF
SET IDENTITY_INSERT [dbo].[salon] ON 

INSERT [dbo].[salon] ([Id], [uyeId], [uyeSira]) VALUES (1, N'admin', N'1')
INSERT [dbo].[salon] ([Id], [uyeId], [uyeSira]) VALUES (2, N'22589', N'2')
INSERT [dbo].[salon] ([Id], [uyeId], [uyeSira]) VALUES (3, N'95376', N'3')
INSERT [dbo].[salon] ([Id], [uyeId], [uyeSira]) VALUES (4, N'33957', N'4')
SET IDENTITY_INSERT [dbo].[salon] OFF
SET IDENTITY_INSERT [dbo].[salon2] ON 

INSERT [dbo].[salon2] ([uyeSira], [uyeId]) VALUES (1, N'admin')
INSERT [dbo].[salon2] ([uyeSira], [uyeId]) VALUES (2, N'42042')
INSERT [dbo].[salon2] ([uyeSira], [uyeId]) VALUES (3, N'43112')
SET IDENTITY_INSERT [dbo].[salon2] OFF
SET IDENTITY_INSERT [dbo].[urunler] ON 

INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (2, N'95036', N'Visual Studio Eğitim Seti     ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (3, N'95036', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (4, N'95036', N'Visual Studio Eğitim Seti     ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (5, N'95036', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (6, N'28591', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (7, N'28591', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (8, N'29704', N'Visual Studio Eğitim Seti     ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (9, N'29704', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (10, N'29704', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (11, N'29704', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (12, N'00000', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (13, N'00000', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (14, N'00000', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (15, N'00000', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (16, N'51319', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (17, N'51319', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (18, N'51319', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (19, N'51319', N'Visual Studio Eğitim Seti     ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (20, N'', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (21, N'', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (22, N'', N'Visual Studio Eğitim Seti     ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (23, N'', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (24, N'', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (25, N'', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (26, N'', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (27, N'', N'XBOX                          ', 1999)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (28, N'16995', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (29, N'16995', N'Visual Studio Set             ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (30, N'16995', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (31, N'', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (32, N'73112', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (33, N'73890', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (34, N'31736', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (35, N'39664', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (36, N'39664', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (37, N'39664', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (38, N'42042', N'Office                        ', 399)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (39, N'42042', N'Office                        ', 399)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (40, N'22589', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (41, N'22589', N'Windows Paketi                ', 150)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (42, N'22589', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (43, N'95376', N'Laptop                        ', 2200)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (44, N'95376', N'Visual Studio Set             ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (45, N'95376', N'Flash Bellek                  ', 80)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (46, N'43112', N'XBOX                          ', 1999)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (47, N'43112', N'Office                        ', 399)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (48, N'43112', N'Office                        ', 399)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (49, N'33957', N'Visual Studio Set             ', 20)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (50, N'33957', N'XBOX                          ', 1999)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (51, N'88401', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (52, N'88401', N'Mouse                         ', 190)
INSERT [dbo].[urunler] ([Id], [v_Id], [urunAd], [urunFiyat]) VALUES (53, N'88401', N'XBOX                          ', 1999)
SET IDENTITY_INSERT [dbo].[urunler] OFF
SET IDENTITY_INSERT [dbo].[uyeler] ON 

INSERT [dbo].[uyeler] ([Id], [adsoyad], [tel], [sehir], [unvan], [sirket], [kayitTarihi], [ekleyen]) VALUES (1, N'user', N'11111111111', N'aa', N'bb                  ', N'Glory               ', N'dd', N'123       ')
INSERT [dbo].[uyeler] ([Id], [adsoyad], [tel], [sehir], [unvan], [sirket], [kayitTarihi], [ekleyen]) VALUES (2, N'görkem', N'12345678910', N'istanbul', N'Yetkili             ', N'Glory               ', N'10 Mayıs 2019 Cuma', NULL)
INSERT [dbo].[uyeler] ([Id], [adsoyad], [tel], [sehir], [unvan], [sirket], [kayitTarihi], [ekleyen]) VALUES (3, N'can', N'32423423432', N'istanbul', N'Öğrenci             ', N'Faggo               ', N'10 Mayıs 2019 Cuma', NULL)
INSERT [dbo].[uyeler] ([Id], [adsoyad], [tel], [sehir], [unvan], [sirket], [kayitTarihi], [ekleyen]) VALUES (4, N'jackson', N'12345678910', N'istanbul', N'Öğrenci             ', N'Mello               ', N'10 Mayıs 2019 Cuma', NULL)
SET IDENTITY_INSERT [dbo].[uyeler] OFF
SET IDENTITY_INSERT [dbo].[vipUyeler] ON 

INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (2, N'42042', N'görkem', N'05348522636', N'istanbul', N'Microsoft', 2500, 1702, N'10 Mayıs 2019 Cuma', N'C:\Users\Görkem\Desktop\bilisimEtkinlik\bilisimEtkinlik\img\user(2).png')
INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (3, N'22589', N'can', N'32544243340', N'istanbul', N'Microsoft', 2800, 260, N'10 Mayıs 2019 Cuma', N'C:\Users\Görkem\Desktop\bilisimEtkinlik\bilisimEtkinlik\img\logo.png')
INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (4, N'95376', N'jackson', N'33333333333', N'istanbul', N'Microsoft', 2800, 500, N'10 Mayıs 2019 Cuma', N'rsm')
INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (5, N'43112', N'user', N'23112313231', N'istanbul', N'Microsoft', 2800, 3, N'10 Mayıs 2019 Cuma', N'rsm')
INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (6, N'33957', N'furkan', N'45555555555', N'istanbul', N'Microsoft', 2800, 781, N'10 Mayıs 2019 Cuma', N'C:\Users\Görkem\Desktop\bilisimEtkinlik\bilisimEtkinlik\img\logo.png')
INSERT [dbo].[vipUyeler] ([Id], [v_Id], [v_AdSoyad], [v_Tel], [v_Sehir], [v_Etkinlik], [v_Bakiye], [v_KalanBakiye], [v_Tarih], [v_ResimYolu]) VALUES (7, N'88401', N'sinan', N'55555555555', N'istanbul', N'Microsoft', 2800, 421, N'10 Mayıs 2019 Cuma', N'rsm')
SET IDENTITY_INSERT [dbo].[vipUyeler] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_hizliKayit]    Script Date: 10.5.2019 08:05:14 ******/
ALTER TABLE [dbo].[hizliKayit] ADD  CONSTRAINT [UQ_hizliKayit] UNIQUE NONCLUSTERED 
(
	[tc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_uyeId]    Script Date: 10.5.2019 08:05:14 ******/
ALTER TABLE [dbo].[salon] ADD  CONSTRAINT [UQ_uyeId] UNIQUE NONCLUSTERED 
(
	[uyeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_v_Id]    Script Date: 10.5.2019 08:05:14 ******/
ALTER TABLE [dbo].[vipUyeler] ADD  CONSTRAINT [UQ_v_Id] UNIQUE NONCLUSTERED 
(
	[v_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_v_Tel]    Script Date: 10.5.2019 08:05:14 ******/
ALTER TABLE [dbo].[vipUyeler] ADD  CONSTRAINT [UQ_v_Tel] UNIQUE NONCLUSTERED 
(
	[v_Tel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [uye] SET  READ_WRITE 
GO
