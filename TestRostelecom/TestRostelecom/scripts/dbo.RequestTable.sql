CREATE TABLE [dbo].[RequestTable] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [RequestDate]     DATETIME       NOT NULL,
    [Address]         NVARCHAR (MAX) NOT NULL,
    [Comment]         NVARCHAR (MAX) NULL,
    [CloseDate]       DATETIME       NULL,
    [DateOfDeparture] DATETIME       NULL,
    [ClientId]        INT            NOT NULL,
    [ServiceId]       INT            NOT NULL,
    [MasterId]        INT            NULL,
    [OperatorId]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

