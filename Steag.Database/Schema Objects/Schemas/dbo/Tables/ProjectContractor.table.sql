CREATE TABLE [dbo].[ProjectContractor](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectID] [bigint] NOT NULL,
	[ContractorID] [bigint] NOT NULL,
	[Notes] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[DateStarted] [datetime] NULL,
	[DateEnded] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [nchar](10) NULL,
 CONSTRAINT [PK_ProjectContractor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProjectContractor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectContractor_Contractor] FOREIGN KEY([ContractorID])
REFERENCES [dbo].[Contractor] ([ID])
GO

ALTER TABLE [dbo].[ProjectContractor] CHECK CONSTRAINT [FK_ProjectContractor_Contractor]
GO

ALTER TABLE [dbo].[ProjectContractor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectContractor_Project] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ID])
GO

ALTER TABLE [dbo].[ProjectContractor] CHECK CONSTRAINT [FK_ProjectContractor_Project]
GO

ALTER TABLE [dbo].[ProjectContractor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectContractor_UserCreated] FOREIGN KEY([UserCreated])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[ProjectContractor] CHECK CONSTRAINT [FK_ProjectContractor_UserCreated]
GO

ALTER TABLE [dbo].[ProjectContractor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectContractor_UserModified] FOREIGN KEY([UserModified])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[ProjectContractor] CHECK CONSTRAINT [FK_ProjectContractor_UserModified]
GO

ALTER TABLE [dbo].[ProjectContractor] ADD  CONSTRAINT [DF_ProjectContractor_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


