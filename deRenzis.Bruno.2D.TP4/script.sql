USE [Productos]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 29/11/2020 19:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](50) NOT NULL,
	[cantidadProducto] [int] NOT NULL,
	[precioProducto] [float] NOT NULL,
	[tipoProducto] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (1, N'Alfajor', 20, 25, NULL)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (2, N'Galletitas', 50, 15, NULL)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (3, N'Gomitas', 51, 12, NULL)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (4, N'Cafe', 12, 50, NULL)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (5, N'Chocolate', 51, 18, NULL)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [cantidadProducto], [precioProducto], [tipoProducto]) VALUES (6, N'Chupetines', 50, 5, NULL)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
