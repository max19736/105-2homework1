CREATE TABLE [dbo].[Class1] (
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [date]           NCHAR (10) NULL,
    [number]         NCHAR (10) NULL,
    [chinesename]    NCHAR (10) NULL,
    [englishename]   NCHAR (10) NULL,
    [phonenumber]    NCHAR (10) NULL,
    [fax]            NCHAR (10) NULL,
    [URL]            NCHAR (10) NULL,
    [Email]          NCHAR (10) NULL,
    [chineseaddress] NCHAR (10) NULL,
    [englishaddress] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

