USE [CsharpProject]
GO
/****** Object:  Table [dbo].[CartTable]    Script Date: 6/21/2025 2:30:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CartTable](
	[CartProductId] [varchar](10) NOT NULL,
	[CartProductName] [varchar](50) NOT NULL,
	[CartQuantity] [int] NOT NULL,
	[CartTotal] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConfirmTable]    Script Date: 6/21/2025 2:30:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConfirmTable](
	[InvoiceNo] [varchar](10) NOT NULL,
	[UserId] [varchar](10) NOT NULL,
	[TotalSale] [float] NOT NULL,
	[SaleDate] [date] NOT NULL,
	[SaleTime] [time](0) NOT NULL,
	[Pay] [float] NOT NULL,
	[Changes] [float] NOT NULL,
 CONSTRAINT [PK_ConfirmTable] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductTable]    Script Date: 6/21/2025 2:30:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductTable](
	[ProductId] [varchar](10) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
 CONSTRAINT [PK_ProductTable] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 6/21/2025 2:30:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserId] [varchar](10) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UserType] [varchar](10) NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CartTable] ([CartProductId], [CartProductName], [CartQuantity], [CartTotal]) VALUES (N'P007', N'PEPSI', 2, 3)
INSERT [dbo].[CartTable] ([CartProductId], [CartProductName], [CartQuantity], [CartTotal]) VALUES (N'P012', N'KITKAT', 3, 7.8)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-001', N'u-001', 100, CAST(N'2025-01-18' AS Date), CAST(N'10:00:00' AS Time), 150, 50)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-002', N'u-001', 120, CAST(N'2025-02-18' AS Date), CAST(N'10:05:00' AS Time), 150, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-003', N'u-001', 130, CAST(N'2025-03-18' AS Date), CAST(N'10:10:00' AS Time), 150, 20)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-004', N'u-001', 140, CAST(N'2025-06-15' AS Date), CAST(N'10:15:00' AS Time), 160, 20)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-005', N'u-002', 150, CAST(N'2025-06-18' AS Date), CAST(N'10:20:00' AS Time), 170, 20)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-006', N'u-002', 160, CAST(N'2025-06-18' AS Date), CAST(N'10:25:00' AS Time), 180, 20)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-007', N'u-002', 170, CAST(N'2025-06-18' AS Date), CAST(N'10:30:00' AS Time), 200, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-008', N'u-001', 180, CAST(N'2025-06-18' AS Date), CAST(N'10:35:00' AS Time), 210, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-009', N'u-001', 190, CAST(N'2025-06-18' AS Date), CAST(N'10:40:00' AS Time), 220, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-010', N'u-001', 200, CAST(N'2025-06-18' AS Date), CAST(N'10:45:00' AS Time), 230, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-011', N'u-002', 210, CAST(N'2025-06-18' AS Date), CAST(N'10:50:00' AS Time), 240, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-012', N'u-003', 220, CAST(N'2025-06-18' AS Date), CAST(N'10:55:00' AS Time), 250, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-013', N'u-001', 230, CAST(N'2025-06-15' AS Date), CAST(N'11:00:00' AS Time), 260, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-014', N'u-010', 240, CAST(N'2025-06-18' AS Date), CAST(N'11:05:00' AS Time), 270, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-015', N'u-005', 250, CAST(N'2025-06-18' AS Date), CAST(N'11:10:00' AS Time), 280, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-016', N'u-006', 260, CAST(N'2025-06-18' AS Date), CAST(N'11:15:00' AS Time), 290, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-017', N'u-007', 270, CAST(N'2025-06-18' AS Date), CAST(N'11:20:00' AS Time), 300, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-018', N'u-001', 280, CAST(N'2025-06-18' AS Date), CAST(N'11:25:00' AS Time), 310, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-019', N'u-011', 290, CAST(N'2025-06-18' AS Date), CAST(N'11:30:00' AS Time), 320, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-020', N'u-002', 300, CAST(N'2025-06-18' AS Date), CAST(N'11:35:00' AS Time), 330, 30)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-021', N'u-001', 30.5, CAST(N'2025-06-18' AS Date), CAST(N'21:06:30' AS Time), 111, 80.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-022', N'u-001', 7.5, CAST(N'2025-06-18' AS Date), CAST(N'23:53:12' AS Time), 50, 42.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-023', N'u-004', 13.9, CAST(N'2025-06-19' AS Date), CAST(N'15:17:31' AS Time), 22, 8.1)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-024', N'u-004', 5.5, CAST(N'2025-06-19' AS Date), CAST(N'15:21:37' AS Time), 33, 27.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-025', N'u-004', 3, CAST(N'2025-06-19' AS Date), CAST(N'15:22:55' AS Time), 21, 18)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-026', N'u-004', 7.5, CAST(N'2025-06-19' AS Date), CAST(N'15:28:08' AS Time), 90, 82.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-027', N'u-004', 29.2, CAST(N'2025-06-19' AS Date), CAST(N'15:33:04' AS Time), 55, 25.8)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-028', N'u-004', 1.5, CAST(N'2025-06-19' AS Date), CAST(N'15:42:46' AS Time), 7, 5.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-029', N'u-001', 14.6, CAST(N'2025-06-19' AS Date), CAST(N'17:12:37' AS Time), 33, 18.4)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-030', N'u-004', 2, CAST(N'2025-06-19' AS Date), CAST(N'17:13:59' AS Time), 2, 0)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-031', N'u-004', 1.5, CAST(N'2025-06-19' AS Date), CAST(N'19:31:21' AS Time), 2, 0.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-032', N'u-004', 1.5, CAST(N'2025-06-19' AS Date), CAST(N'19:31:48' AS Time), 2, 0.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-033', N'u-004', 2.5, CAST(N'2025-06-19' AS Date), CAST(N'19:32:14' AS Time), 12, 9.5)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-034', N'u-004', 2, CAST(N'2025-06-19' AS Date), CAST(N'19:55:41' AS Time), 999, 997)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-035', N'u-004', 3, CAST(N'2025-06-19' AS Date), CAST(N'19:56:20' AS Time), 4, 1)
INSERT [dbo].[ConfirmTable] ([InvoiceNo], [UserId], [TotalSale], [SaleDate], [SaleTime], [Pay], [Changes]) VALUES (N'inv-036', N'u-001', 28.5, CAST(N'2025-06-21' AS Date), CAST(N'14:20:06' AS Time), 33, 4.5)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P001', N'PIZZA', 94, 5.5)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P002', N'BURGARE', 76, 4.2)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P003', N'SANDWICH', 88, 3.75)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P004', N'FRIES', 110, 2.5)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P005', N'TACO', 59, 3)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P006', N'COKE', 146, 1.5)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P007', N'PEPSI', 137, 1.5)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P008', N'COFFEE', 98, 2)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P009', N'TEA', 106, 1.8)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P010', N'JUICE', 130, 2.2)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P011', N'DARYMILK', 70, 2.8)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P012', N'KITKAT', 49, 2.6)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P013', N'SNICKERS', 63, 3.1)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P014', N'TWIX', 47, 2.9)
INSERT [dbo].[ProductTable] ([ProductId], [ProductName], [Quantity], [UnitPrice]) VALUES (N'P015', N'MILKYWAY', 50, 3.2)
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-001', N'Demo Admin', N'admin123', N'Admin')
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-002', N'Demo Manager', N'admin456', N'Admin')
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-003', N'Demo Owner', N'admin789', N'Admin')
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-004', N'Demo Salesman', N'sales123', N'Salesman')
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-005', N'Demo Cashier', N'sales456', N'Salesman')
INSERT [dbo].[UserTable] ([UserId], [UserName], [Password], [UserType]) VALUES (N'u-006', N'Demo Staff', N'sales789', N'Salesman')
ALTER TABLE [dbo].[CartTable]  WITH CHECK ADD  CONSTRAINT [FK_CartTable_ProductTable] FOREIGN KEY([CartProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[CartTable] CHECK CONSTRAINT [FK_CartTable_ProductTable]
GO
