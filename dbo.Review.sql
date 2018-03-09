CREATE TABLE [dbo].[Review] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Comment] NVARCHAR (250) NOT NULL,
    [Reviewer]    NVARCHAR (60)  NOT NULL,
    CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED ([ID] ASC)
);

