CREATE TABLE [dbo].[Contractor](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ContractorName] [nvarchar](250) NOT NULL,
	[ContactPerson] [nvarchar](250) NULL,
	[ContactNumber1] [nvarchar](30) NULL,
	[ContactNumber2] [nvarchar](30) NULL,
	[EmailAddress] [nvarchar](250) NULL,
	[Address1] [nvarchar](250) NULL,
	[Address2] [nvarchar](250) NULL,
	[State] [nvarchar](250) NULL,
	[Country] [nvarchar](250) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Notes] [nvarchar](250) NULL,
	[LastProjectInvolvement] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_Contractor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Contractor]  WITH CHECK ADD  CONSTRAINT [FK_Contractor_UserCreated] FOREIGN KEY([UserCreated])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[Contractor] CHECK CONSTRAINT [FK_Contractor_UserCreated]
GO

ALTER TABLE [dbo].[Contractor]  WITH CHECK ADD  CONSTRAINT [FK_Contractor_UserModified] FOREIGN KEY([UserModified])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[Contractor] CHECK CONSTRAINT [FK_Contractor_UserModified]
GO

ALTER TABLE [dbo].[Contractor] ADD  CONSTRAINT [DF_Contractor_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


