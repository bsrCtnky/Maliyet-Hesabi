CREATE TABLE [dbo].[Deri] (
    [deriID]      INT          NOT NULL,
    [deriTuru]    VARCHAR (50) NULL,
    [deriBirimi]  INT          NULL,
    [deriBireKac] INT          NULL,
    CONSTRAINT [PK_Deri] PRIMARY KEY CLUSTERED ([deriID] ASC),
    CONSTRAINT [FK_Deri_BireKac] FOREIGN KEY ([deriBireKac]) REFERENCES [dbo].[BireKac] ([BireKacId])
);

