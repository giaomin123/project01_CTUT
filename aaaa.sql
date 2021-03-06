USE [dbQLCDACNTT]
GO
/****** Object:  Table [dbo].[QuanLyDuAn]    Script Date: 11/20/20 3:28:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyDuAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenDA] [nvarchar](50) NULL,
	[maDA] [nvarchar](50) NULL,
	[ngayBD] [date] NULL,
	[ngayKT] [date] NULL,
	[kinhphiDA] [float] NULL,
	[loaiDA] [nvarchar](50) NULL,
	[noiTrienKhai] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuanLyDuAn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QuanLyDuAn] ON 

INSERT [dbo].[QuanLyDuAn] ([id], [tenDA], [maDA], [ngayBD], [ngayKT], [kinhphiDA], [loaiDA], [noiTrienKhai]) VALUES (1, N'Toan', N'MAD123', CAST(N'2020-01-22' AS Date), CAST(N'2020-02-23' AS Date), 10000, N'Nice', N'Can Tho')
INSERT [dbo].[QuanLyDuAn] ([id], [tenDA], [maDA], [ngayBD], [ngayKT], [kinhphiDA], [loaiDA], [noiTrienKhai]) VALUES (2, N'TiengAnh', N'MDA34', CAST(N'2020-01-02' AS Date), CAST(N'2020-01-03' AS Date), 10000, N'nice', N'Soc Trang')
SET IDENTITY_INSERT [dbo].[QuanLyDuAn] OFF
GO
