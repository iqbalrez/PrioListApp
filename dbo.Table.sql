CREATE TABLE [dbo].[TaskList] (
    [Id]            INT           NOT NULL ,
    [TaskName]      NVARCHAR (50) NOT NULL,
    [Deadline]      DATETIME      NOT NULL,
    [PriorityLevel] NVARCHAR (12) NOT NULL,
    [PrioLev]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

