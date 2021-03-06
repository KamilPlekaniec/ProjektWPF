USE [ProjektWPF]
GO
/****** Object:  Table [dbo].[Użytkownik]    Script Date: 09.07.2020 19:39:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Użytkownik](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Loginx] [char](30) NULL,
	[Passwordx] [char](30) NULL,
	[Imię] [char](13) NULL,
	[Nazwisko] [char](30) NULL,
	[Lata] [char](20) NULL,
	[DataDołączenia] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Użytkownik] ON 

INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (4, N'darek2                        ', N'darek123                      ', N'Darek        ', N'Kaminski                      ', N'20                  ', N'25.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (1002, N'awdaw                         ', N'awdaw                         ', N'awdaw        ', N'dawda                         ', N'20                  ', N'25.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (2002, N'dadwa@wp.pl                   ', N'dawvtD123                     ', N'Dawid        ', N'King                          ', N'20                  ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (2003, N'adwda@wp.pl                   ', N'vdawvD231                     ', N'Kamil        ', N'Plekaniec                     ', N'22                  ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (3002, N'awdwa@wp.pl                   ', N'dawdawD1                      ', N'Darek        ', N'Kamien                        ', N'10                  ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (4002, N'dawdw@dad.pl                  ', N'adwa123D                      ', N'dawda        ', N'dwadaw                        ', N'dawdwa              ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (5002, N'yvdawuy@wp.pl                 ', N'vdawydDVY1231                 ', N'Kamil        ', N'Gdady                         ', N'21                  ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (5003, N'dawdaw@wp.pl                  ', N'adbwayvUYDdy21                ', N'Henryk       ', N'Kania                         ', N'27                  ', N'26.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (6002, N'12345@wp.pl                   ', N'12345xD                       ', N'Kamil        ', N'Plekaniec                     ', N'22                  ', N'27.06.2020          ')
INSERT [dbo].[Użytkownik] ([ID], [Loginx], [Passwordx], [Imię], [Nazwisko], [Lata], [DataDołączenia]) VALUES (6003, N'kar@wp.pl                     ', N'Karolina99                    ', N'karolina     ', N'karolina                      ', N'20                  ', N'27.06.2020          ')
SET IDENTITY_INSERT [dbo].[Użytkownik] OFF
