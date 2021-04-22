CREATE TABLE [dbo].[SpojovaciTabulka] (
    [Zkratka] VARCHAR (3) NOT NULL,
    [ID]      INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Zkratka] ASC, [ID] ASC),
    FOREIGN KEY ([Zkratka]) REFERENCES [dbo].[Predmety] ([Zkratka]),
    FOREIGN KEY ([ID]) REFERENCES [dbo].[Studenti] ([ID])
);

