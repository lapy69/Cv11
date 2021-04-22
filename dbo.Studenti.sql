CREATE TABLE [dbo].[Studenti] (
    [Jmeno]          VARCHAR (30) NOT NULL,
    [Prijmeni]       VARCHAR (30) NOT NULL,
    [Datum_narozeni] DATE         NOT NULL,
    [ID]             INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

