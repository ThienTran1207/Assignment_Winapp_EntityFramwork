USE [master]
GO
/****** Object:  Database [quan_ly_chi_tieu]    Script Date: 03/11/2022 23:59:50 ******/
CREATE DATABASE [quan_ly_chi_tieu]
GO
USE [quan_ly_chi_tieu]
GO
/****** Object:  Table [dbo].[category]    Script Date: 03/11/2022 23:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[income]    Script Date: 03/11/2022 23:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[income](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NULL,
	[money] [float] NULL,
	[date_use] [date] NULL,
	[description] [nvarchar](500) NULL,
	[uid] [int] NULL,
 CONSTRAINT [PK_income] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outcome]    Script Date: 03/11/2022 23:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outcome](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NULL,
	[money] [float] NULL,
	[date_use] [date] NULL,
	[description] [nvarchar](500) NULL,
	[uid] [int] NULL,
 CONSTRAINT [PK_outcome] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 03/11/2022 23:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nchar](10) NULL,
	[gender] [bit] NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name]) VALUES (1, N'Chi phí đi lại')
INSERT [dbo].[category] ([id], [name]) VALUES (2, N'Lương')
INSERT [dbo].[category] ([id], [name]) VALUES (3, N'Mua Sắm')
INSERT [dbo].[category] ([id], [name]) VALUES (4, N'Sức khỏe')
INSERT [dbo].[category] ([id], [name]) VALUES (5, N'Khinh doanh')
INSERT [dbo].[category] ([id], [name]) VALUES (6, N'Ăn uống')
INSERT [dbo].[category] ([id], [name]) VALUES (7, N'Điện nước')
INSERT [dbo].[category] ([id], [name]) VALUES (8, N'Con cái')
INSERT [dbo].[category] ([id], [name]) VALUES (9, N'Trợ cấp')
INSERT [dbo].[category] ([id], [name]) VALUES (10, N'Quà tặng')
INSERT [dbo].[category] ([id], [name]) VALUES (11, N'Khác')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[income] ON 

INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (1, 2, 5000000, CAST(N'2022-11-02' AS Date), N'lương tháng 11', 1)
INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (2, 10, 100000, CAST(N'2022-10-20' AS Date), N'quà của công ty', 1)
INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (3, 5, 1230000, CAST(N'2022-04-11' AS Date), N'lương tháng 11', NULL)
INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (4, 5, 1230000, CAST(N'2022-04-11' AS Date), N'lương tháng 11', NULL)
INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (5, 10, 100000, CAST(N'2022-10-20' AS Date), N'quà của công ty', NULL)
INSERT [dbo].[income] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (6, 5, 1230000, CAST(N'2022-04-11' AS Date), N'lương tháng 11123', NULL)
SET IDENTITY_INSERT [dbo].[income] OFF
GO
SET IDENTITY_INSERT [dbo].[outcome] ON 

INSERT [dbo].[outcome] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (1, 3, 2010000, CAST(N'2022-10-31' AS Date), N'chi phí xăng xe1', 1)
INSERT [dbo].[outcome] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (2, 6, 600000, CAST(N'2022-10-31' AS Date), N'tiền ăn của tháng', 1)
INSERT [dbo].[outcome] ([id], [category_id], [money], [date_use], [description], [uid]) VALUES (5, 4, 3210000, CAST(N'2022-10-07' AS Date), N'chi phí xăng xe13', NULL)
SET IDENTITY_INSERT [dbo].[outcome] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [name], [phone], [gender], [password]) VALUES (1, N'chien', N'0123456789', 1, N'123')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[income]  WITH CHECK ADD  CONSTRAINT [FK_income_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
ALTER TABLE [dbo].[income] CHECK CONSTRAINT [FK_income_category]
GO
ALTER TABLE [dbo].[income]  WITH CHECK ADD  CONSTRAINT [FK_income_users] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[income] CHECK CONSTRAINT [FK_income_users]
GO
ALTER TABLE [dbo].[outcome]  WITH CHECK ADD  CONSTRAINT [FK_outcome_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
ALTER TABLE [dbo].[outcome] CHECK CONSTRAINT [FK_outcome_category]
GO
ALTER TABLE [dbo].[outcome]  WITH CHECK ADD  CONSTRAINT [FK_outcome_users] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[outcome] CHECK CONSTRAINT [FK_outcome_users]
GO
USE [master]
GO
ALTER DATABASE [quan_ly_chi_tieu] SET  READ_WRITE 
GO
