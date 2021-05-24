CREATE TABLE [dbo].[BaskiTuru] (
    [baskiID]    INT          NOT NULL,
    [baskiAd]    VARCHAR (50) NULL,
    [baskiFiyat] MONEY        NULL,
    CONSTRAINT [PK_BaskiTuru] PRIMARY KEY CLUSTERED ([baskiID] ASC)
);

