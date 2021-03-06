USE [POS]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 31/10/2019 8:31:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Label] [varchar](50) NOT NULL,
	[Icon] [varchar](50) NULL,
 CONSTRAINT [PK_Actions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surnames] [varchar](100) NOT NULL,
	[Identification] [varchar](20) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[StateId] [bigint] NOT NULL,
	[Creationdate] [datetime] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[StateId] [bigint] NOT NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CategoryId] [bigint] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Image] [varchar](50) NULL,
	[PurchasePrice] [numeric](18, 0) NOT NULL,
	[SalePrice] [numeric](18, 0) NOT NULL,
	[Stock] [bigint] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[Purchased] [bigint] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product_Category]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product_Category](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[StateId] [bigint] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol_Actions]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol_Actions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RolId] [bigint] NOT NULL,
	[ActionId] [bigint] NOT NULL,
 CONSTRAINT [PK_Rol_Actions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClientId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Iva] [numeric](18, 0) NOT NULL,
	[NetoWorth] [numeric](18, 0) NOT NULL,
	[Total] [numeric](18, 0) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[PaymentMethodId] [bigint] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales_Detail]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Detail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[SaleId] [bigint] NOT NULL,
	[SaleDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Sales_Detail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[States]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[States](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Rol]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Rol](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[RolId] [bigint] NOT NULL,
 CONSTRAINT [PK_User_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 31/10/2019 8:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[StateId] [bigint] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[LastLogin] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [Name], [Surnames], [Identification], [Address], [Phone], [Email], [StateId], [Creationdate]) VALUES (1, N'Jair', N'Guerrero', N'1130', N'Calle 23', N'311', N'test@test.com', 1, CAST(N'2019-10-31 01:01:40.717' AS DateTime))
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[PaymentMethods] ON 

INSERT [dbo].[PaymentMethods] ([Id], [Name], [StateId]) VALUES (1, N'Efectivo', 1)
INSERT [dbo].[PaymentMethods] ([Id], [Name], [StateId]) VALUES (2, N'Cheque', 1)
INSERT [dbo].[PaymentMethods] ([Id], [Name], [StateId]) VALUES (3, N'TC-0255', 1)
INSERT [dbo].[PaymentMethods] ([Id], [Name], [StateId]) VALUES (4, N'TD-0777', 1)
SET IDENTITY_INSERT [dbo].[PaymentMethods] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Code], [Image], [PurchasePrice], [SalePrice], [Stock], [CreationDate], [Purchased]) VALUES (1, N'Jean Studio F', 3, N'1001', N'-', CAST(32000 AS Numeric(18, 0)), CAST(70000 AS Numeric(18, 0)), 12, CAST(N'2019-10-31 00:00:00.000' AS DateTime), 12)
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Code], [Image], [PurchasePrice], [SalePrice], [Stock], [CreationDate], [Purchased]) VALUES (2, N'Jean Boyfirend', 3, N'1002', N'-', CAST(38000 AS Numeric(18, 0)), CAST(90000 AS Numeric(18, 0)), 20, CAST(N'2019-10-31 00:00:00.000' AS DateTime), 20)
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Code], [Image], [PurchasePrice], [SalePrice], [Stock], [CreationDate], [Purchased]) VALUES (3, N'Blusa Italiana', 3, N'1003', N'-', CAST(15000 AS Numeric(18, 0)), CAST(45000 AS Numeric(18, 0)), 1, CAST(N'2019-10-31 00:00:00.000' AS DateTime), 12)
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Code], [Image], [PurchasePrice], [SalePrice], [Stock], [CreationDate], [Purchased]) VALUES (4, N'Jean Denim H', 4, N'1004', N'-', CAST(32000 AS Numeric(18, 0)), CAST(75000 AS Numeric(18, 0)), 1, CAST(N'2019-10-31 00:00:00.000' AS DateTime), 24)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Product_Category] ON 

INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (1, N'Electromecánicos')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (2, N'Construcción')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (3, N'Ropa Dama')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (4, N'Ropa Hombre')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (5, N'Accesorios')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (6, N'Libros')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (7, N'PC')
INSERT [dbo].[Product_Category] ([Id], [Name]) VALUES (8, N'Dispositivos Moviles')
SET IDENTITY_INSERT [dbo].[Product_Category] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([Id], [Name], [StateId]) VALUES (1, N'Administrador', 1)
INSERT [dbo].[Rol] ([Id], [Name], [StateId]) VALUES (3, N'Vendedor', 1)
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[States] ON 

INSERT [dbo].[States] ([Id], [Name]) VALUES (1, N'Activo')
INSERT [dbo].[States] ([Id], [Name]) VALUES (2, N'Inactivo')
INSERT [dbo].[States] ([Id], [Name]) VALUES (3, N'Activox1')
INSERT [dbo].[States] ([Id], [Name]) VALUES (4, N'Bloqueado')
INSERT [dbo].[States] ([Id], [Name]) VALUES (5, N'Cancelado')
INSERT [dbo].[States] ([Id], [Name]) VALUES (6, N'Reversado')
INSERT [dbo].[States] ([Id], [Name]) VALUES (7, N'Congelado')
INSERT [dbo].[States] ([Id], [Name]) VALUES (8, N'Hold')
SET IDENTITY_INSERT [dbo].[States] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password], [StateId], [CreationDate], [LastLogin]) VALUES (1, N'admin', N'&ASD#%85744', 1, CAST(N'2019-10-28 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Users] ([Id], [Login], [Password], [StateId], [CreationDate], [LastLogin]) VALUES (2, N'jjjj', N'nsnsns', 2, CAST(N'2019-10-30 22:29:30.907' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
