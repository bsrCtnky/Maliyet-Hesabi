CREATE TABLE [dbo].[KagitModeli] (
    [kagitID]    INT          NOT NULL,
    [kagitTur]   VARCHAR (50) NULL,
    [kagitFiyat] MONEY        NULL,
    CONSTRAINT [PK_KagitModeli] PRIMARY KEY CLUSTERED ([kagitID] ASC)
);

