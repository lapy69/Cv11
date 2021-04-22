CREATE TABLE [dbo].[Hodnoceni] (
    [Zkratka]         VARCHAR (3) NOT NULL,
    [ID]              INT         NOT NULL,
    [datum_hodnoceni] DATE        NOT NULL,
    [hodnoceni]       FLOAT (53)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Zkratka] ASC, [ID] ASC),
    FOREIGN KEY ([Zkratka]) REFERENCES [dbo].[Predmety] ([Zkratka]),
    FOREIGN KEY ([ID]) REFERENCES [dbo].[Studenti] ([ID])
);

