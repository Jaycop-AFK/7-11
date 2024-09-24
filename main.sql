﻿{"metadata":{"kernel_spec":{"name":"SQL","language":"sql","display_name":"SQL"},"language_info":{"name":"sql","version":""}},"nbformat":4,"nbformat_minor":2,"cells":[{"cell_type":"markdown","source":["# [7-11]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Database [7-11]    Script Date: 9/24/2024 4:15:16 PM ******/\r\nCREATE DATABASE [7-11]\r\n CONTAINMENT = NONE\r\n ON  PRIMARY \r\n( NAME = N'7-11', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\DATA\\7-11.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )\r\n LOG ON \r\n( NAME = N'7-11_log', FILENAME = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\DATA\\7-11_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )\r\n WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF\r\n","GO\r\n","ALTER DATABASE [7-11] SET COMPATIBILITY_LEVEL = 160\r\n","GO\r\n","IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))\r\nbegin\r\nEXEC [7-11].[dbo].[sp_fulltext_database] @action = 'enable'\r\nend\r\n","GO\r\n","ALTER DATABASE [7-11] SET ANSI_NULL_DEFAULT OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET ANSI_NULLS OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET ANSI_PADDING OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET ANSI_WARNINGS OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET ARITHABORT OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET AUTO_CLOSE OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET AUTO_SHRINK OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET AUTO_UPDATE_STATISTICS ON \r\n","GO\r\n","ALTER DATABASE [7-11] SET CURSOR_CLOSE_ON_COMMIT OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET CURSOR_DEFAULT  GLOBAL \r\n","GO\r\n","ALTER DATABASE [7-11] SET CONCAT_NULL_YIELDS_NULL OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET NUMERIC_ROUNDABORT OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET QUOTED_IDENTIFIER OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET RECURSIVE_TRIGGERS OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET  DISABLE_BROKER \r\n","GO\r\n","ALTER DATABASE [7-11] SET AUTO_UPDATE_STATISTICS_ASYNC OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET DATE_CORRELATION_OPTIMIZATION OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET TRUSTWORTHY OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET ALLOW_SNAPSHOT_ISOLATION OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET PARAMETERIZATION SIMPLE \r\n","GO\r\n","ALTER DATABASE [7-11] SET READ_COMMITTED_SNAPSHOT OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET HONOR_BROKER_PRIORITY OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET RECOVERY FULL \r\n","GO\r\n","ALTER DATABASE [7-11] SET  MULTI_USER \r\n","GO\r\n","ALTER DATABASE [7-11] SET PAGE_VERIFY CHECKSUM  \r\n","GO\r\n","ALTER DATABASE [7-11] SET DB_CHAINING OFF \r\n","GO\r\n","ALTER DATABASE [7-11] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) \r\n","GO\r\n","ALTER DATABASE [7-11] SET TARGET_RECOVERY_TIME = 60 SECONDS \r\n","GO\r\n","ALTER DATABASE [7-11] SET DELAYED_DURABILITY = DISABLED \r\n","GO\r\n","ALTER DATABASE [7-11] SET ACCELERATED_DATABASE_RECOVERY = OFF  \r\n","GO\r\n","EXEC sys.sp_db_vardecimal_storage_format N'7-11', N'ON'\r\n","GO\r\n","ALTER DATABASE [7-11] SET QUERY_STORE = ON\r\n","GO\r\n","ALTER DATABASE [7-11] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}},{"cell_type":"markdown","source":["# [dbo].[product]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [7-11]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[product]    Script Date: 9/24/2024 4:15:16 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[product](\r\n\t[product_id] [int] NOT NULL,\r\n\t[product_name] [nvarchar](50) NOT NULL,\r\n\t[product_price] [float] NOT NULL,\r\n\t[product_amout] [int] NOT NULL,\r\n\t[peoduct_tID] [int] NOT NULL\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[product_type]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product_type' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[product_type]    Script Date: 9/24/2024 4:15:16 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[product_type](\r\n\t[product_tID] [int] NOT NULL,\r\n\t[product_tName] [nvarchar](50) NOT NULL\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product_type' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[users]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='users' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["/****** Object:  Table [dbo].[users]    Script Date: 9/24/2024 4:15:16 PM ******/\r\nSET ANSI_NULLS ON\r\n","GO\r\n","SET QUOTED_IDENTIFIER ON\r\n","GO\r\n","CREATE TABLE [dbo].[users](\r\n\t[user_ID] [int] NOT NULL,\r\n\t[user_firstName] [nvarchar](50) NOT NULL,\r\n\t[user_lastName] [nvarchar](50) NOT NULL,\r\n\t[user_email] [nvarchar](50) NOT NULL,\r\n\t[user_name] [nvarchar](50) NOT NULL,\r\n\t[user_password] [nvarchar](50) NOT NULL\r\n) ON [PRIMARY]\r\nGO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='users' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[product]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (1001, N'เลย์', 22, 991, 1)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (1002, N'เทสโต้', 20, 998, 1)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (2001, N'พายสัปปะรด', 20, 499, 2)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (2002, N'เอแคร์', 20, 499, 2)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (3001, N'ข้าวผัดไก่', 35, 499, 3)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (3002, N'กะเพราหมู', 39, 500, 3)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (4001, N'กาแฟ', 45, 499, 4)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (4002, N'ชาไทย', 25, 500, 4)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (4003, N'เอ็มร้อย', 10, 10000, 4)\r\n","INSERT [dbo].[product] ([product_id], [product_name], [product_price], [product_amout], [peoduct_tID]) VALUES (3008, N'dog', 305, 100, 3)\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[product_type]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product_type' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["INSERT [dbo].[product_type] ([product_tID], [product_tName]) VALUES (1, N'ขนมมกรุบกรอบ')\r\n","INSERT [dbo].[product_type] ([product_tID], [product_tName]) VALUES (2, N'เบเกอรี่')\r\n","INSERT [dbo].[product_type] ([product_tID], [product_tName]) VALUES (3, N'อาหารสำเร็จรูป')\r\n","INSERT [dbo].[product_type] ([product_tID], [product_tName]) VALUES (4, N'เครื่องดื่ม')\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='product_type' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [dbo].[users]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='users' and @Schema='dbo']","object_type":"Table"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["INSERT [dbo].[users] ([user_ID], [user_firstName], [user_lastName], [user_email], [user_name], [user_password]) VALUES (1001, N'Jamdum', N'Inyu', N'abc@gmail.com', N'jamlukbol', N'12345678')\r\n","INSERT [dbo].[users] ([user_ID], [user_firstName], [user_lastName], [user_email], [user_name], [user_password]) VALUES (1002, N'BamlookBol', N'Inyu', N'def@gmail.com', N'bamlokbol', N'12345678')\r\n","INSERT [dbo].[users] ([user_ID], [user_firstName], [user_lastName], [user_email], [user_name], [user_password]) VALUES (1, N'1', N'1', N'1', N'1', N'1')\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']/Table[@Name='users' and @Schema='dbo']","object_type":"Table"}},{"cell_type":"markdown","source":["# [7-11]"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["USE [master]\r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}},{"outputs":[],"execution_count":0,"cell_type":"code","source":["ALTER DATABASE [7-11] SET  READ_WRITE \r\n","GO\r\n"],"metadata":{"urn":"Server[@Name='344_14']/Database[@Name='7-11']","object_type":"Database"}}]}