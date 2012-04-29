INSERT INTO [dbo].[SystemSettings]
           ([CompanyName]
           ,[Address1]
           ,[Address2]
           ,[Country]
           ,[State]
           ,[PostalCode]
		   ,[FiscalYear]
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
		   2012,          
           1,
           GETDATE(),
           1,
           GETDATE())
