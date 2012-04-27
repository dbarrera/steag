INSERT INTO [Steag.Security.DEVELOPMENT].[dbo].[SystemSettings]
           ([CompanyName]
           ,[Address1]
           ,[Address2]
           ,[Country]
           ,[State]
           ,[PostalCode]
           ,[LastSarfCode]
           ,[LastEacsCode]
           ,[UserCreated]
           ,[DateCreated]
           ,[UserModified]
           ,[DateModified])
     VALUES
           ('STEAG State Power Inc.',
           NULL,
           NULL,
           NULL,
           NULL,
           NULL,
           1000,
           1000,
           1,
           GETDATE(),
           1,
           GETDATE())
