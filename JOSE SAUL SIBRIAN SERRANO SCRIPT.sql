USE [PrograII]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 15/10/2023 9:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Sexo] [varchar](50) NULL,
	[Edad] [int] NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 

INSERT [dbo].[Estudiantes] ([Id], [Nombres], [Apellidos], [Sexo], [Edad]) VALUES (2, N'Saul', N'Sibrian', N'M', 22)
INSERT [dbo].[Estudiantes] ([Id], [Nombres], [Apellidos], [Sexo], [Edad]) VALUES (16, N'Guia', N'Programacion', N'M', 18)
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
GO
