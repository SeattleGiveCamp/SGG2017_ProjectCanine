﻿DECLARE @handler AS UNIQUEIDENTIFIER = 'e30ed2be-3a53-4800-a8c4-feda77461bf2';
DECLARE @testDate AS DATETIME = '2017-10-07 00:00:00';
DECLARE @examiner AS UNIQUEIDENTIFIER = 'ed378076-c969-4fca-8fa6-7058b3ffd888';
INSERT INTO [dbo].[TestResults] ([Id], [Handler], [Dog], [PassedTest], [TestDate], [ScoringExaminer], [HandsOnExaminer], [CertificationType], [EquipmentRestrictions], [ScoringExaminerSignature], [HandsOnSignature], [HandlerSignature]) VALUES ('fa81b15f-1a19-4219-a395-f85c059127ff', @handler, '86c7ecd5-b468-4cb2-91c7-6c25ed9742f0', 1, @testDate, @examiner, @examiner, '83261fc8-73dd-4afb-aa69-f9367a872b35', 'b5e223c9-70b8-41f9-9f1a-bed531c2fbac', <Binary Data>, <Binary Data>, <Binary Data>);
INSERT INTO [dbo].[TestResults] ([Id], [Handler], [Dog], [PassedTest], [TestDate], [ScoringExaminer], [HandsOnExaminer], [CertificationType], [EquipmentRestrictions], [ScoringExaminerSignature], [HandsOnSignature], [HandlerSignature]) VALUES ('dadc6501-c848-45f7-a211-1fa93ecd7a88', @handler, 'ee034027-cb14-486d-baac-36077676a0f5', 1, @testDate, @examiner, @examiner, '83261fc8-73dd-4afb-aa69-f9367a872b35', '3aba4a52-d8d6-4b01-a893-34ccdcba77d9', <Binary Data>, <Binary Data>, <Binary Data>);