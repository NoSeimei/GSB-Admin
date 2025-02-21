USE [SIO2_GSB_GR2_PPE6]
GO
/****** Object:  Table [dbo].[visiteur]    Script Date: 11/05/2019 17:23:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visiteur](
	[id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehicule]    Script Date: 11/05/2019 17:23:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vehicule](
	[immat] [varchar](50) NOT NULL,
	[puiss] [int] NULL,
	[modeleMarque] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[utiliser]    Script Date: 11/05/2019 17:23:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[utiliser](
	[immat] [varchar](50) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[id] [int] NOT NULL,
	[dateFin] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 11/05/2019 17:23:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[utilisateur](
	[id] [int] NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[prenom] [varchar](50) NOT NULL,
	[login] [varchar](50) NOT NULL,
	[mdp] [varchar](50) NOT NULL,
	[adresse] [varchar](50) NOT NULL,
	[cp] [varchar](50) NOT NULL,
	[ville] [varchar](50) NOT NULL,
	[dateEmbauche] [date] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comptable]    Script Date: 11/05/2019 17:23:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comptable](
	[id] [int] NOT NULL,
	[nbFicheRefusee] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__utiliser__dateFi__117F9D94]    Script Date: 11/05/2019 17:23:21 ******/
ALTER TABLE [dbo].[utiliser] ADD  DEFAULT (NULL) FOR [dateFin]
GO
