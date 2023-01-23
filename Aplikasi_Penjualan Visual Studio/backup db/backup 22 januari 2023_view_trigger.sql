﻿{"metadata":{"kernel_spec":{"name":"SQL","language":"sql","display_name":"SQL"},"language_info":{"name":"sql","version":""}},"nbformat":4,"nbformat_minor":2,"cells":[{"cell_type":"markdown","source":["# [db_penjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Database [db_penjualan]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nCREATE DATABASE [db_penjualan]\r\n CONTAINMENT = NONE\r\n ON  PRIMARY \r\n( NAME = N'db_penjualan', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\DATA\\db_penjualan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )\r\n LOG ON \r\n( NAME = N'db_penjualan_log', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\DATA\\db_penjualan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )\r\n WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF\r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET COMPATIBILITY_LEVEL = 160\r\n","GO\r\n","IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))\r\nbegin\r\nEXEC [db_penjualan].[dbo].[sp_fulltext_database] @action = 'enable'\r\nend\r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ANSI_NULL_DEFAULT OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ANSI_NULLS OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ANSI_PADDING OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ANSI_WARNINGS OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ARITHABORT OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET AUTO_CLOSE OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET AUTO_SHRINK OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET AUTO_UPDATE_STATISTICS ON \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET CURSOR_CLOSE_ON_COMMIT OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET CURSOR_DEFAULT  GLOBAL \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET CONCAT_NULL_YIELDS_NULL OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET NUMERIC_ROUNDABORT OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET QUOTED_IDENTIFIER OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET RECURSIVE_TRIGGERS OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET  DISABLE_BROKER \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET DATE_CORRELATION_OPTIMIZATION OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET TRUSTWORTHY OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ALLOW_SNAPSHOT_ISOLATION OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET PARAMETERIZATION SIMPLE \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET READ_COMMITTED_SNAPSHOT OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET HONOR_BROKER_PRIORITY OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET RECOVERY FULL \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET  MULTI_USER \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET PAGE_VERIFY CHECKSUM  \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET DB_CHAINING OFF \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET TARGET_RECOVERY_TIME = 60 SECONDS \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET DELAYED_DURABILITY = DISABLED \r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET ACCELERATED_DATABASE_RECOVERY = OFF  \r\n","GO\r\n","EXEC sys.sp_db_vardecimal_storage_format N'db_penjualan', N'ON'\r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET QUERY_STORE = ON\r\n","GO\r\n","ALTER DATABASE [db_penjualan] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}},{"cell_type":"markdown","source":["# [dbo].[tbl_barang]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_barang' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [db_penjualan]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_barang' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[tbl_barang]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[tbl_barang](\r\n\t[KodeBarang] [char](4) NOT NULL,\r\n\t[NamaBarang] [varchar](50) NOT NULL,\r\n\t[Harga] [int] NOT NULL,\r\n\t[Stok] [int] NOT NULL,\r\n\t[Satuan] [varchar](30) NULL,\r\n CONSTRAINT [PK_tbl_barang] PRIMARY KEY CLUSTERED \r\n(\r\n\t[KodeBarang] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_barang' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[tbl_detailpenjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[tbl_detailpenjualan]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[tbl_detailpenjualan](\r\n\t[NoKwitansi] [varchar](20) NOT NULL,\r\n\t[KodeBarang] [char](4) NOT NULL,\r\n\t[Jumlah] [int] NOT NULL\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[vw_detail]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']","object_type":"View"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  View [dbo].[vw_detail]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE VIEW [dbo].[vw_detail]\r\nAS\r\nSELECT dbo.tbl_detailpenjualan.NoKwitansi, dbo.tbl_detailpenjualan.KodeBarang, dbo.tbl_barang.NamaBarang, dbo.tbl_barang.Harga, dbo.tbl_barang.Satuan, dbo.tbl_detailpenjualan.Jumlah\r\nFROM   dbo.tbl_barang INNER JOIN\r\n             dbo.tbl_detailpenjualan ON dbo.tbl_barang.KodeBarang = dbo.tbl_detailpenjualan.KodeBarang\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']","object_type":"View"}},{"cell_type":"markdown","source":["# [dbo].[tbl_pelanggan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_pelanggan' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[tbl_pelanggan]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[tbl_pelanggan](\r\n\t[IdPelanggan] [char](4) NOT NULL,\r\n\t[NamaPelanggan] [varchar](50) NOT NULL,\r\n\t[Alamat] [varchar](100) NULL,\r\n\t[NoTelepon] [nchar](13) NULL,\r\n CONSTRAINT [PK_tbl_pelanggan] PRIMARY KEY CLUSTERED \r\n(\r\n\t[IdPelanggan] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_pelanggan' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[tbl_penjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_penjualan' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[tbl_penjualan]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[tbl_penjualan](\r\n\t[NoKwitansi] [varchar](20) NOT NULL,\r\n\t[TglKwitansi] [date] NOT NULL,\r\n\t[IdPelanggan] [char](4) NOT NULL,\r\n CONSTRAINT [PK_tbl_penjualan] PRIMARY KEY CLUSTERED \r\n(\r\n\t[NoKwitansi] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_penjualan' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[vw_penjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']","object_type":"View"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  View [dbo].[vw_penjualan]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE VIEW [dbo].[vw_penjualan]\r\nAS\r\nSELECT dbo.tbl_penjualan.NoKwitansi, dbo.tbl_penjualan.TglKwitansi, dbo.tbl_penjualan.IdPelanggan, dbo.tbl_pelanggan.NamaPelanggan\r\nFROM   dbo.tbl_penjualan INNER JOIN\r\n             dbo.tbl_pelanggan ON dbo.tbl_penjualan.IdPelanggan = dbo.tbl_pelanggan.IdPelanggan\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']","object_type":"View"}},{"cell_type":"markdown","source":["# [dbo].[vw_cetaktransaksi]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']","object_type":"View"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  View [dbo].[vw_cetaktransaksi]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE VIEW [dbo].[vw_cetaktransaksi]\r\nAS\r\nSELECT dbo.tbl_detailpenjualan.NoKwitansi, dbo.tbl_penjualan.TglKwitansi, dbo.tbl_penjualan.IdPelanggan, dbo.tbl_pelanggan.NamaPelanggan, dbo.tbl_detailpenjualan.KodeBarang, dbo.tbl_barang.NamaBarang, dbo.tbl_barang.Harga, dbo.tbl_detailpenjualan.Jumlah, \r\n             dbo.tbl_barang.Harga * dbo.tbl_detailpenjualan.Jumlah AS JumlahBayar\r\nFROM   dbo.tbl_barang INNER JOIN\r\n             dbo.tbl_detailpenjualan ON dbo.tbl_barang.KodeBarang = dbo.tbl_detailpenjualan.KodeBarang INNER JOIN\r\n             dbo.tbl_penjualan ON dbo.tbl_detailpenjualan.NoKwitansi = dbo.tbl_penjualan.NoKwitansi INNER JOIN\r\n             dbo.tbl_pelanggan ON dbo.tbl_penjualan.IdPelanggan = dbo.tbl_pelanggan.IdPelanggan\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']","object_type":"View"}},{"cell_type":"markdown","source":["# [dbo].[tbl_login]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_login' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[tbl_login]    Script Date: 1/22/2023 7:25:02 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[tbl_login](\r\n\t[user_id] [char](10) NOT NULL,\r\n\t[username] [varchar](50) NOT NULL,\r\n\t[password] [varchar](50) NOT NULL\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_login' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [relasi_penjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan']","object_type":"ForeignKey"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER TABLE [dbo].[tbl_detailpenjualan]  WITH CHECK ADD  CONSTRAINT [relasi_penjualan] FOREIGN KEY([NoKwitansi])\r\nREFERENCES [dbo].[tbl_penjualan] ([NoKwitansi])\r\nON UPDATE CASCADE\r\nON DELETE CASCADE\r\n","GO\r\n","ALTER TABLE [dbo].[tbl_detailpenjualan] CHECK CONSTRAINT [relasi_penjualan]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan']","object_type":"ForeignKey"}},{"cell_type":"markdown","source":["# [relasi_penjualan_barang]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan_barang']","object_type":"ForeignKey"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER TABLE [dbo].[tbl_detailpenjualan]  WITH CHECK ADD  CONSTRAINT [relasi_penjualan_barang] FOREIGN KEY([KodeBarang])\r\nREFERENCES [dbo].[tbl_barang] ([KodeBarang])\r\nON UPDATE CASCADE\r\nON DELETE CASCADE\r\n","GO\r\n","ALTER TABLE [dbo].[tbl_detailpenjualan] CHECK CONSTRAINT [relasi_penjualan_barang]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_detailpenjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan_barang']","object_type":"ForeignKey"}},{"cell_type":"markdown","source":["# [relasi_penjualan_pelanggan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_penjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan_pelanggan']","object_type":"ForeignKey"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER TABLE [dbo].[tbl_penjualan]  WITH CHECK ADD  CONSTRAINT [relasi_penjualan_pelanggan] FOREIGN KEY([IdPelanggan])\r\nREFERENCES [dbo].[tbl_pelanggan] ([IdPelanggan])\r\nON UPDATE CASCADE\r\nON DELETE CASCADE\r\n","GO\r\n","ALTER TABLE [dbo].[tbl_penjualan] CHECK CONSTRAINT [relasi_penjualan_pelanggan]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/Table[@Name='tbl_penjualan' and @Schema='dbo']/ForeignKey[@Name='relasi_penjualan_pelanggan']","object_type":"ForeignKey"}},{"cell_type":"markdown","source":["# [MS_DiagramPane1]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]\r\nBegin DesignProperties = \r\n   Begin PaneConfigurations = \r\n      Begin PaneConfiguration = 0\r\n         NumPanes = 4\r\n         Configuration = \"(H (1[40] 4[20] 2[20] 3) )\"\r\n      End\r\n      Begin PaneConfiguration = 1\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 4 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 2\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 2 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 3\r\n         NumPanes = 3\r\n         Configuration = \"(H (4 [30] 2 [40] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 4\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [56] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 5\r\n         NumPanes = 2\r\n         Configuration = \"(H (2 [66] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 6\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [50] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 7\r\n         NumPanes = 1\r\n         Configuration = \"(V (3))\"\r\n      End\r\n      Begin PaneConfiguration = 8\r\n         NumPanes = 3\r\n         Configuration = \"(H (1[56] 4[18] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 9\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [75] 4))\"\r\n      End\r\n      Begin PaneConfiguration = 10\r\n         NumPanes = 2\r\n         Configuration = \"(H (1[66] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 11\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [60] 2))\"\r\n      End\r\n      Begin PaneConfiguration = 12\r\n         NumPanes = 1\r\n         Configuration = \"(H (1) )\"\r\n      End\r\n      Begin PaneConfiguration = 13\r\n         NumPanes = 1\r\n         Configuration = \"(V (4))\"\r\n      End\r\n      Begin PaneConfiguration = 14\r\n         NumPanes = 1\r\n         Configuration = \"(V (2))\"\r\n      End\r\n      ActivePaneConfig = 0\r\n   End\r\n   Begin DiagramPane = \r\n      Begin Origin = \r\n         Top = 0\r\n         Left = 0\r\n      End\r\n      Begin Tables = \r\n         Begin Table = \"tbl_barang\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 57\r\n               Bottom = 206\r\n               Right = 279\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n         Begin Table = \"tbl_detailpenjualan\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 336\r\n               Bottom = 179\r\n               Right = 558\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n         Begin Table = \"tbl_pelanggan\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 615\r\n               Bottom = 206\r\n               Right = 849\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n         Begin Table = \"tbl_penjualan\"\r\n            Begin Extent = \r\n               Top = 180\r\n               Left = 336\r\n               Bottom = 350\r\n               Right = 558\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n      End\r\n   End\r\n   Begin SQLPane = \r\n   End\r\n   Begin DataPane = \r\n      Begin ParameterDefaults = \"\"\r\n      End\r\n   End\r\n   Begin CriteriaPane = \r\n      Begin ColumnWidths = 11\r\n         Column = 1440\r\n         Alias = 900\r\n         Table = 1170\r\n         Output = 720\r\n         Append = 1400\r\n         NewValue = 1170\r\n         SortType = 1350\r\n         SortOrder = 1410\r\n         GroupBy = 1350\r\n         Filter = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n      End\r\n   End\r\nEnd\r\n' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [MS_DiagramPaneCount]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_cetaktransaksi' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [MS_DiagramPane1]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]\r\nBegin DesignProperties = \r\n   Begin PaneConfigurations = \r\n      Begin PaneConfiguration = 0\r\n         NumPanes = 4\r\n         Configuration = \"(H (1[40] 4[20] 2[20] 3) )\"\r\n      End\r\n      Begin PaneConfiguration = 1\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 4 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 2\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 2 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 3\r\n         NumPanes = 3\r\n         Configuration = \"(H (4 [30] 2 [40] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 4\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [56] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 5\r\n         NumPanes = 2\r\n         Configuration = \"(H (2 [66] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 6\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [50] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 7\r\n         NumPanes = 1\r\n         Configuration = \"(V (3))\"\r\n      End\r\n      Begin PaneConfiguration = 8\r\n         NumPanes = 3\r\n         Configuration = \"(H (1[56] 4[18] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 9\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [75] 4))\"\r\n      End\r\n      Begin PaneConfiguration = 10\r\n         NumPanes = 2\r\n         Configuration = \"(H (1[66] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 11\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [60] 2))\"\r\n      End\r\n      Begin PaneConfiguration = 12\r\n         NumPanes = 1\r\n         Configuration = \"(H (1) )\"\r\n      End\r\n      Begin PaneConfiguration = 13\r\n         NumPanes = 1\r\n         Configuration = \"(V (4))\"\r\n      End\r\n      Begin PaneConfiguration = 14\r\n         NumPanes = 1\r\n         Configuration = \"(V (2))\"\r\n      End\r\n      ActivePaneConfig = 0\r\n   End\r\n   Begin DiagramPane = \r\n      Begin Origin = \r\n         Top = 0\r\n         Left = 0\r\n      End\r\n      Begin Tables = \r\n         Begin Table = \"tbl_barang\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 57\r\n               Bottom = 206\r\n               Right = 279\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 1\r\n         End\r\n         Begin Table = \"tbl_detailpenjualan\"\r\n            Begin Extent = \r\n               Top = 77\r\n               Left = 471\r\n               Bottom = 247\r\n               Right = 693\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n      End\r\n   End\r\n   Begin SQLPane = \r\n   End\r\n   Begin DataPane = \r\n      Begin ParameterDefaults = \"\"\r\n      End\r\n   End\r\n   Begin CriteriaPane = \r\n      Begin ColumnWidths = 11\r\n         Column = 1440\r\n         Alias = 900\r\n         Table = 1170\r\n         Output = 720\r\n         Append = 1400\r\n         NewValue = 1170\r\n         SortType = 1350\r\n         SortOrder = 1410\r\n         GroupBy = 1350\r\n         Filter = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n      End\r\n   End\r\nEnd\r\n' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [MS_DiagramPaneCount]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_detail' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [MS_DiagramPane1]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]\r\nBegin DesignProperties = \r\n   Begin PaneConfigurations = \r\n      Begin PaneConfiguration = 0\r\n         NumPanes = 4\r\n         Configuration = \"(H (1[40] 4[20] 2[20] 3) )\"\r\n      End\r\n      Begin PaneConfiguration = 1\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 4 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 2\r\n         NumPanes = 3\r\n         Configuration = \"(H (1 [50] 2 [25] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 3\r\n         NumPanes = 3\r\n         Configuration = \"(H (4 [30] 2 [40] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 4\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [56] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 5\r\n         NumPanes = 2\r\n         Configuration = \"(H (2 [66] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 6\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [50] 3))\"\r\n      End\r\n      Begin PaneConfiguration = 7\r\n         NumPanes = 1\r\n         Configuration = \"(V (3))\"\r\n      End\r\n      Begin PaneConfiguration = 8\r\n         NumPanes = 3\r\n         Configuration = \"(H (1[56] 4[18] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 9\r\n         NumPanes = 2\r\n         Configuration = \"(H (1 [75] 4))\"\r\n      End\r\n      Begin PaneConfiguration = 10\r\n         NumPanes = 2\r\n         Configuration = \"(H (1[66] 2) )\"\r\n      End\r\n      Begin PaneConfiguration = 11\r\n         NumPanes = 2\r\n         Configuration = \"(H (4 [60] 2))\"\r\n      End\r\n      Begin PaneConfiguration = 12\r\n         NumPanes = 1\r\n         Configuration = \"(H (1) )\"\r\n      End\r\n      Begin PaneConfiguration = 13\r\n         NumPanes = 1\r\n         Configuration = \"(V (4))\"\r\n      End\r\n      Begin PaneConfiguration = 14\r\n         NumPanes = 1\r\n         Configuration = \"(V (2))\"\r\n      End\r\n      ActivePaneConfig = 0\r\n   End\r\n   Begin DiagramPane = \r\n      Begin Origin = \r\n         Top = 0\r\n         Left = 0\r\n      End\r\n      Begin Tables = \r\n         Begin Table = \"tbl_penjualan\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 57\r\n               Bottom = 179\r\n               Right = 279\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n         Begin Table = \"tbl_pelanggan\"\r\n            Begin Extent = \r\n               Top = 9\r\n               Left = 336\r\n               Bottom = 206\r\n               Right = 570\r\n            End\r\n            DisplayFlags = 280\r\n            TopColumn = 0\r\n         End\r\n      End\r\n   End\r\n   Begin SQLPane = \r\n   End\r\n   Begin DataPane = \r\n      Begin ParameterDefaults = \"\"\r\n      End\r\n   End\r\n   Begin CriteriaPane = \r\n      Begin ColumnWidths = 11\r\n         Column = 1440\r\n         Alias = 900\r\n         Table = 1170\r\n         Output = 720\r\n         Append = 1400\r\n         NewValue = 1170\r\n         SortType = 1350\r\n         SortOrder = 1410\r\n         GroupBy = 1350\r\n         Filter = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n         Or = 1350\r\n      End\r\n   End\r\nEnd\r\n' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPane1']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [MS_DiagramPaneCount]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']/View[@Name='vw_penjualan' and @Schema='dbo']/ExtendedProperty[@Name='MS_DiagramPaneCount']","object_type":"ExtendedProperty"}},{"cell_type":"markdown","source":["# [db_penjualan]"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER DATABASE [db_penjualan] SET  READ_WRITE \r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='ROI']/Database[@Name='db_penjualan']","object_type":"Database"}}]}