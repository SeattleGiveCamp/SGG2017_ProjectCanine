﻿CREATE TABLE [dbo].[Questions]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Test] UNIQUEIDENTIFIER NOT NULL,
	[Text] VARCHAR(1000) NOT NULL,
	[MustPass] BIT NOT NULL DEFAULT 0,
	[SectionNumber] INT NOT NULL,
	[QuestionNumber] INT NOT NULL,
	[HasYesNo] BIT NOT NULL DEFAULT 0,
	[LastEditedBy] UNIQUEIDENTIFIER NULL,
	[LastEditedDate] DATETIME NULL DEFAULT GetDate()
)
