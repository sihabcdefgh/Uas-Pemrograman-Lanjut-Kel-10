USE [master]
GO
/****** Object:  Database [db_penjualan_baru]    Script Date: 12/01/2023 04:42:40 ******/
CREATE DATABASE [db_penjualan_baru]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_penjualan_baru', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_penjualan_baru.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_penjualan_baru_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_penjualan_baru_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [db_penjualan_baru] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_penjualan_baru].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_penjualan_baru] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_penjualan_baru] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_penjualan_baru] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_penjualan_baru] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_penjualan_baru] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_penjualan_baru] SET  MULTI_USER 
GO
ALTER DATABASE [db_penjualan_baru] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_penjualan_baru] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_penjualan_baru] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_penjualan_baru] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_penjualan_baru] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_penjualan_baru] SET QUERY_STORE = OFF
GO
USE [db_penjualan_baru]
GO
/****** Object:  Table [dbo].[tbl_barang]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_barang](
	[KodeBarang] [char](4) NOT NULL,
	[NamaBarang] [varchar](50) NOT NULL,
	[Harga] [int] NOT NULL,
	[Stok] [int] NOT NULL,
	[Satuan] [varchar](30) NULL,
 CONSTRAINT [PK_tbl_barang] PRIMARY KEY CLUSTERED 
(
	[KodeBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_detailpenjualan]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_detailpenjualan](
	[NoKwitansi] [varchar](20) NOT NULL,
	[KodeBarang] [char](4) NOT NULL,
	[Jumlah] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_detail]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_detail]
AS
SELECT        dbo.tbl_detailpenjualan.NoKwitansi, dbo.tbl_detailpenjualan.KodeBarang, dbo.tbl_barang.NamaBarang, dbo.tbl_barang.Harga, dbo.tbl_barang.Satuan, dbo.tbl_detailpenjualan.Jumlah
FROM            dbo.tbl_barang INNER JOIN
                         dbo.tbl_detailpenjualan ON dbo.tbl_barang.KodeBarang = dbo.tbl_detailpenjualan.KodeBarang
GO
/****** Object:  Table [dbo].[tbl_pelanggan]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pelanggan](
	[IdPelanggan] [char](4) NOT NULL,
	[NamaPelanggan] [varchar](50) NOT NULL,
	[Alamat] [varchar](100) NULL,
	[NoTelepon] [varchar](13) NULL,
 CONSTRAINT [PK_tbl_pelanggan] PRIMARY KEY CLUSTERED 
(
	[IdPelanggan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_penjualan]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_penjualan](
	[NoKwitansi] [varchar](20) NOT NULL,
	[TglKwitansi] [date] NOT NULL,
	[IdPelanggan] [char](4) NOT NULL,
 CONSTRAINT [PK_tbl_penjualan] PRIMARY KEY CLUSTERED 
(
	[NoKwitansi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_penjualan]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_penjualan]
AS
SELECT        dbo.tbl_penjualan.NoKwitansi, dbo.tbl_penjualan.TglKwitansi, dbo.tbl_penjualan.IdPelanggan, dbo.tbl_pelanggan.NamaPelanggan
FROM            dbo.tbl_penjualan INNER JOIN
                         dbo.tbl_pelanggan ON dbo.tbl_penjualan.IdPelanggan = dbo.tbl_pelanggan.IdPelanggan
GO
/****** Object:  View [dbo].[vw_cetaktransaksi]    Script Date: 12/01/2023 04:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_cetaktransaksi]
AS
SELECT        dbo.tbl_detailpenjualan.NoKwitansi, dbo.tbl_penjualan.TglKwitansi, dbo.tbl_penjualan.IdPelanggan, dbo.tbl_pelanggan.NamaPelanggan, dbo.tbl_detailpenjualan.KodeBarang, dbo.tbl_barang.NamaBarang, dbo.tbl_barang.Harga, 
                         dbo.tbl_detailpenjualan.Jumlah, dbo.tbl_barang.Harga * dbo.tbl_detailpenjualan.Jumlah AS JumlahBayar
FROM            dbo.tbl_barang INNER JOIN
                         dbo.tbl_detailpenjualan ON dbo.tbl_barang.KodeBarang = dbo.tbl_detailpenjualan.KodeBarang INNER JOIN
                         dbo.tbl_penjualan ON dbo.tbl_detailpenjualan.NoKwitansi = dbo.tbl_penjualan.NoKwitansi INNER JOIN
                         dbo.tbl_pelanggan ON dbo.tbl_penjualan.IdPelanggan = dbo.tbl_pelanggan.IdPelanggan
GO
ALTER TABLE [dbo].[tbl_detailpenjualan]  WITH CHECK ADD  CONSTRAINT [relasi_penjualan] FOREIGN KEY([NoKwitansi])
REFERENCES [dbo].[tbl_penjualan] ([NoKwitansi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_detailpenjualan] CHECK CONSTRAINT [relasi_penjualan]
GO
ALTER TABLE [dbo].[tbl_detailpenjualan]  WITH CHECK ADD  CONSTRAINT [relasi_penjualan_barang] FOREIGN KEY([KodeBarang])
REFERENCES [dbo].[tbl_barang] ([KodeBarang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_detailpenjualan] CHECK CONSTRAINT [relasi_penjualan_barang]
GO
ALTER TABLE [dbo].[tbl_penjualan]  WITH CHECK ADD  CONSTRAINT [Relasi_Penjualan_Pelanggan] FOREIGN KEY([IdPelanggan])
REFERENCES [dbo].[tbl_pelanggan] ([IdPelanggan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_penjualan] CHECK CONSTRAINT [Relasi_Penjualan_Pelanggan]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_detailpenjualan"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_pelanggan"
            Begin Extent = 
               Top = 141
               Left = 258
               Bottom = 271
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_penjualan"
            Begin Extent = 
               Top = 158
               Left = 24
               Bottom = 271
               Right = 194
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbl_detailpenjualan"
            Begin Extent = 
               Top = 42
               Left = 296
               Bottom = 155
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_penjualan"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_pelanggan"
            Begin Extent = 
               Top = 11
               Left = 308
               Bottom = 141
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
USE [master]
GO
ALTER DATABASE [db_penjualan_baru] SET  READ_WRITE 
GO
