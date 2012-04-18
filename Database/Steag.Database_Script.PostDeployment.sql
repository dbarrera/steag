/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-- =============================================
-- Script Template
-- =============================================
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('ADMINISTRATOR TEMPLATE','STEAG Security System Administrator Template',1,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('GATE 1 SECURITY TEMPLATE','Gate 1 Security Personnel Template',1,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('GATE 2 SECURITY TEMPLATE','Gate 2 Security Personnel Template',1,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('EMPLOYEE TEMPLATE','STEAG Employee Template',1,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('Administrator','STEAG Security System Administrator',0,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('Gate 1 Security','Gate 1 Security Personnel',0,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('Gate 2 Security','Gate 2 Security Personnel',0,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [dbo].[UserRole] ([RoleCode] ,[Description] ,[IsTemplate], [IsActive], [UserCreated], [DateCreated], [UserModified], [DateModified]) VALUES('Employee','STEAG Employee',0,1,1,'Apr 17 2012 11:18PM',1,'Apr 17 2012 11:18PM')
INSERT INTO [Steag.Security.DEVELOPMENT].[dbo].[UserAccount]
           ([UserName]
           ,[Password]
           ,[Salt]
           ,[UserRoleID]
           ,[FirstName]
           ,[MiddleName]
           ,[LastName]
           ,[EmailAddress]
           ,[IsActive]
           ,[UserCreated]
           ,[DateCreated]
           ,[UserModified]
           ,[DateModified])
     VALUES
           ('Admin',
           'fzyjtTarbKBuxvu3eKriYQ==',
           '82AP+PZTRfKLlKVlGayPZb/55SkXvzj6bIVZh3sr9nrFUX7zPcKh2/vUs7vD1IaVt7PrDJjHaAmHdHSjjRrNeg==',
           5,
           'STEAG Security System Admin',
           NULL,
           NULL,
           NULL,
           1,
           1,
            GETDATE(),
           1,
           GETDATE())

INSERT INTO [Steag.Security.DEVELOPMENT].[dbo].[UserAccount]
           ([UserName]
           ,[Password]
           ,[Salt]
           ,[UserRoleID]
           ,[FirstName]
           ,[MiddleName]
           ,[LastName]
           ,[EmailAddress]
           ,[IsActive]
           ,[UserCreated]
           ,[DateCreated]
           ,[UserModified]
           ,[DateModified])
     VALUES
           ('Guard1',
           'fzyjtTarbKBuxvu3eKriYQ==',
           '82AP+PZTRfKLlKVlGayPZb/55SkXvzj6bIVZh3sr9nrFUX7zPcKh2/vUs7vD1IaVt7PrDJjHaAmHdHSjjRrNeg==',
           6,
           NULL,
           NULL,
           NULL,
           NULL,
           1,
           1,
            GETDATE(),
           1,
           GETDATE())

INSERT INTO [Steag.Security.DEVELOPMENT].[dbo].[UserAccount]
           ([UserName]
           ,[Password]
           ,[Salt]
           ,[UserRoleID]
           ,[FirstName]
           ,[MiddleName]
           ,[LastName]
           ,[EmailAddress]
           ,[IsActive]
           ,[UserCreated]
           ,[DateCreated]
           ,[UserModified]
           ,[DateModified])
     VALUES
           ('Guard2',
           'fzyjtTarbKBuxvu3eKriYQ==',
           '82AP+PZTRfKLlKVlGayPZb/55SkXvzj6bIVZh3sr9nrFUX7zPcKh2/vUs7vD1IaVt7PrDJjHaAmHdHSjjRrNeg==',
           7,
           NULL,
           NULL,
           NULL,
           NULL,
           1,
           1,
            GETDATE(),
           1,
           GETDATE())
