﻿CREATE TABLE [dbo].[Tests]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (NEWID()),
	[ShortName] VARCHAR(30) NOT NULL,
	[Name] VARCHAR(500) NOT NULL,
	[HandlerSignaturePrompt] VARCHAR(1000) NOT NULL,
	[LastEditedBy] UNIQUEIDENTIFIER NOT NULL,
	[LastEditedDate] DATETIME NOT NULL DEFAULT GetDate()
)
