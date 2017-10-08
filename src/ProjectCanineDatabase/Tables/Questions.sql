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
	[LastEditedDate] DATETIME NOT NULL DEFAULT GetDate()
);
GO
ALTER TABLE [dbo].[Questions] ADD CONSTRAINT FK_Questions_Tests
	FOREIGN KEY (Test) REFERENCES [dbo].[Tests] (Id);
GO

ALTER TABLE [dbo].[Questions] ADD CONSTRAINT FK_Questions_Examiners
FOREIGN KEY (LastEditedBy) REFERENCES [dbo].Examiners (Id);
GO
