CREATE TABLE [dbo].[UserFile] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [UserId]    CHAR (10)   NULL,
    [TableName] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserFile_ToTable] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

