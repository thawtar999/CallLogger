USE [master]
GO
/****** Object:  Database [SimpleCallLoggerDB]    Script Date: 8/26/2020 1:23:03 PM ******/
CREATE DATABASE [SimpleCallLoggerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SimpleCallLoggerDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SimpleCallLoggerDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SimpleCallLoggerDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SimpleCallLoggerDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SimpleCallLoggerDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SimpleCallLoggerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET  MULTI_USER 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SimpleCallLoggerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SimpleCallLoggerDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SimpleCallLoggerDB', N'ON'
GO
USE [SimpleCallLoggerDB]
GO
/****** Object:  Table [dbo].[CallLog]    Script Date: 8/26/2020 1:23:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CallLog](
	[CallLogId] [int] NOT NULL,
	[StaffId] [int] NULL,
	[CustomerId] [int] NULL,
	[CallDate] [nvarchar](20) NULL,
	[StartTime] [nvarchar](20) NULL,
	[EndTime] [nvarchar](20) NULL,
	[CallDuration] [float] NULL,
	[CallNote] [nvarchar](500) NULL,
 CONSTRAINT [PK_CallLog] PRIMARY KEY CLUSTERED 
(
	[CallLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 8/26/2020 1:23:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerEmail] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 8/26/2020 1:23:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [nvarchar](50) NULL,
	[StaffEmail] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (1, 1, 2, N'8/23/2020', N'7:03:29 AM', N'7:12:29 AM', 9, N'testing call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (2, 1, 1, N'8/24/2020', N'8:00:00 AM', N'8:10:00 AM', 10, N'testing call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (3, 1, 2, N'8/22/2020', N'8:30:00 AM', N'8:31:00 AM', 1, N'Test')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (4, 2, 2, N'8/25/2020', N'9:00:00 AM', N'10:50:00 AM', 50, N'more than 1 hour call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (5, 2, 2, N'8/23/2020', N'11:00:00 AM', N'11:00:10 AM', 0.17, N'less than 30 seconds call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (6, 2, 2, N'8/21/2020', N'3:00:00 PM', N'3:00:20 PM', 0.33, N'Less than 1 hour call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (7, 1, 2, N'8/22/2020', N'12:00:00 PM', N'12:20:00 PM', 20, N'Less than 30 seconds')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (8, 1, 2, N'8/25/2020', N'7:51:44 AM', N'7:52:44 AM', 1, N'test')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (9, 1, 2, N'8/25/2020', N'9:50:56 AM', N'9:53:56 AM', 3, N'1 minute call')
INSERT [dbo].[CallLog] ([CallLogId], [StaffId], [CustomerId], [CallDate], [StartTime], [EndTime], [CallDuration], [CallNote]) VALUES (10, 1, 1, N'8/26/2020', N'12:49:42 PM', N'1:52:42 PM', 63, N'more than 1 hour')
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerEmail], [ContactNumber], [Address]) VALUES (1, N'Nandar', N'nandar@gmail.com', N'09786654323', N'No.132, Mingalar Road, Mandalay')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerEmail], [ContactNumber], [Address]) VALUES (2, N'Aye Aye', N'aye@gmail.com', N'09345677367', N'No.23, 62 Road, Mandalay')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerEmail], [ContactNumber], [Address]) VALUES (3, N'Eaindray Oo', N'eain@gmail.com', N'0987465535', N'Mandalay')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffId], [StaffName], [StaffEmail], [ContactNumber], [Address]) VALUES (1, N'Khine Khine', N'kk@gmail.com', N'0987363627', N'Yangon')
INSERT [dbo].[Staff] ([StaffId], [StaffName], [StaffEmail], [ContactNumber], [Address]) VALUES (2, N'Aung Aung', N'aung@gmail.com', N'093456774', N'Mandalay')
INSERT [dbo].[Staff] ([StaffId], [StaffName], [StaffEmail], [ContactNumber], [Address]) VALUES (3, N'Ma Ohnmar', N'ohnmar@gmail.com', N'0937383736', N'Yangon')
SET IDENTITY_INSERT [dbo].[Staff] OFF
ALTER TABLE [dbo].[CallLog]  WITH CHECK ADD  CONSTRAINT [FK_CallLog_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[CallLog] CHECK CONSTRAINT [FK_CallLog_Customer]
GO
ALTER TABLE [dbo].[CallLog]  WITH CHECK ADD  CONSTRAINT [FK_CallLog_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staff] ([StaffId])
GO
ALTER TABLE [dbo].[CallLog] CHECK CONSTRAINT [FK_CallLog_Staff]
GO
USE [master]
GO
ALTER DATABASE [SimpleCallLoggerDB] SET  READ_WRITE 
GO
