
CREATE TABLE [dbo].[tbCours] (
    [Id]          INT             NOT NULL,
    [Titre]       NVARCHAR (50)   NOT NULL,
    [Description] NVARCHAR (3000) NULL,
    CONSTRAINT [PK_Cours] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[tbEnseignants] (
    [Id]       INT             NOT NULL,
    [Nom]      NVARCHAR (50)   NOT NULL,
    [Prenom]   NVARCHAR (50)   NOT NULL,
    [Titre]    NVARCHAR (50)   NULL,
    [Bio]      NVARCHAR (3000) NULL,
    [Rue]      NVARCHAR (100)  NOT NULL,
    [Npa]      NVARCHAR (10)   NOT NULL,
    [Localit�] NVARCHAR (50)   NOT NULL,
    CONSTRAINT [PK_Enseignants] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[tbEtudiants] (
    [Id]       INT            NOT NULL,
    [Nom]      NVARCHAR (100) NOT NULL,
    [Prenom]   NVARCHAR (100) NOT NULL,
    [Rue]      NVARCHAR (100) NOT NULL,
    [RueNum]   NVARCHAR (100) NOT NULL,
    [Npa]      NVARCHAR (10)  NOT NULL,
    [Localite] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Etudiants] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[tbFormations] (
    [Id]  INT            NOT NULL,
    [Nom] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Formations] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[tbSessions] (
    [Id]                 INT           NOT NULL,
    [SessionId]          NVARCHAR (50) NOT NULL,
    [MaxInscription]     INT           NOT NULL,
    [AnneeAcademique]    INT           NOT NULL,
    [JoursCours]         NVARCHAR (20) NOT NULL,
    [DateDebutCours]     DATE          NOT NULL,
    [DateFinCours]       DATE          NOT NULL,
    [Session_Cours]      INT           NOT NULL,
    [Session_Enseignant] INT           NOT NULL,
    CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sessions_Cours] FOREIGN KEY ([Session_Cours]) REFERENCES [dbo].[tbCours] ([Id]),
    CONSTRAINT [FK_Sessions_Eseignant] FOREIGN KEY ([Session_Enseignant]) REFERENCES [dbo].[tbEnseignants] ([Id])
);

GO

CREATE TABLE [dbo].[tbInscriptions] (
    [Inscription_Session]  INT NOT NULL,
    [Inscription_Etudiant] INT NOT NULL,
    CONSTRAINT [FK_Inscriptions_Etudiants] FOREIGN KEY ([Inscription_Etudiant]) REFERENCES [dbo].[tbEtudiants] ([Id]),
    CONSTRAINT [FK_Inscriptions_Sessions] FOREIGN KEY ([Inscription_Session]) REFERENCES [dbo].[tbSessions] ([Id])
);

GO

CREATE TABLE [dbo].[tbCoursFormations] (
    [CoursFormation_Cours]      INT NOT NULL,
    [CoursFormation_Formations] INT NOT NULL,
    CONSTRAINT [FK_CoursFormations_Cours] FOREIGN KEY ([CoursFormation_Cours]) REFERENCES [dbo].[tbCours] ([Id]),
    CONSTRAINT [FK_CoursFormations_Formations] FOREIGN KEY ([CoursFormation_Formations]) REFERENCES [dbo].[tbFormations] ([Id])
);

GO

INSERT INTO [dbo].[tbEtudiants]
Values (1, 'Newton', 'Isac', 'Gravity street', '25', '1042', 'London');

GO

INSERT INTO [dbo].[tbEtudiants]
Values (2, 'Holmes', 'Sherlok', 'Baker street', '121b', '1000', 'London');

GO

INSERT INTO [dbo].[tbEtudiants]
Values (4, 'Babbage', 'Charles', 'Analytical street', '26', '1019', 'Oxford');

GO

INSERT INTO [dbo].[tbEtudiants]
Values (5, 'Lovelace', 'Ada', 'Argorithm street', '20', '1015', 'Oxford');