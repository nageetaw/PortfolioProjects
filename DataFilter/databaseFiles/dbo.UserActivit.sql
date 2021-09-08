CREATE TABLE [dbo].[UserActivit] (
    [Id]   INT identity(1,1)  NOT NULL,
    [UserId] CHAR(10) NULL,
    [Activity] NCHAR(100) NULL, 
    PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

