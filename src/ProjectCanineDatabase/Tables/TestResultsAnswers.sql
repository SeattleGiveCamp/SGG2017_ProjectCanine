﻿CREATE TABLE [dbo].[TestResultsAnswers]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[TestResult] UNIQUEIDENTIFIER NOT NULL,
	[Question] UNIQUEIDENTIFIER NOT NULL,
	[Answer] VARCHAR(2) NOT NULL,
	[YesNo] BIT NOT NULL DEFAULT 0
)
