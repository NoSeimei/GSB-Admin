USE [GSB-Admin]
GO
/****** Object:  Table [dbo].[comptable]    Script Date: 07/11/2019 13:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comptable](
	[id] [int] NOT NULL,
	[nbFicheRefusee] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 07/11/2019 13:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[dateEmbauche] [date] NOT NULL,
 CONSTRAINT [PK_utilisateur_ID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utiliser]    Script Date: 07/11/2019 13:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utiliser](
	[immat] [varchar](50) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[id] [int] NOT NULL,
	[dateFin] [date] NULL,
 CONSTRAINT [PK_utiliser_composer] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[DateDebut] ASC,
	[immat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehicule]    Script Date: 07/11/2019 13:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehicule](
	[immat] [varchar](50) NOT NULL,
	[puiss] [int] NULL,
	[modeleMarque] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vehicule_immat] PRIMARY KEY CLUSTERED 
(
	[immat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visiteur]    Script Date: 07/11/2019 13:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visiteur](
	[id] [int] NOT NULL,
 CONSTRAINT [PK_visiteur_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[comptable]  WITH CHECK ADD  CONSTRAINT [FK_comptable_id] FOREIGN KEY([id])
REFERENCES [dbo].[utilisateur] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comptable] CHECK CONSTRAINT [FK_comptable_id]
GO
ALTER TABLE [dbo].[utiliser]  WITH CHECK ADD  CONSTRAINT [FK_voiture_utiliser_immat] FOREIGN KEY([immat])
REFERENCES [dbo].[vehicule] ([immat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[utiliser] CHECK CONSTRAINT [FK_voiture_utiliser_immat]
GO
ALTER TABLE [dbo].[utiliser]  WITH CHECK ADD  CONSTRAINT [FK_voiture_Visiteur_id] FOREIGN KEY([id])
REFERENCES [dbo].[visiteur] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[utiliser] CHECK CONSTRAINT [FK_voiture_Visiteur_id]
GO
ALTER TABLE [dbo].[visiteur]  WITH CHECK ADD  CONSTRAINT [FK_visiteur_id] FOREIGN KEY([id])
REFERENCES [dbo].[utilisateur] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[visiteur] CHECK CONSTRAINT [FK_visiteur_id]
GO
