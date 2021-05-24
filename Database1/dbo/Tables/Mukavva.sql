CREATE TABLE [dbo].[Mukavva] (
    [mukavvaID]      INT          NOT NULL,
    [mukavvaTuru]    VARCHAR (50) NULL,
    [mukavvaAdet]    INT          NULL,
    [mukavvaBireKac] INT          NULL,
    CONSTRAINT [PK_Mukavva] PRIMARY KEY CLUSTERED ([mukavvaID] ASC),
    CONSTRAINT [FK_Mukavva_BireKac] FOREIGN KEY ([mukavvaBireKac]) REFERENCES [dbo].[BireKac] ([BireKacId])
);

