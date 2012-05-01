CREATE TABLE [dbo].[Project](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectCode] [nvarchar](60) NOT NULL,
	[ProjectName] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Notes] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[DateStarted] [datetime] NULL,
	[DateEnded] [datetime] NULL,
	[Status] [nvarchar](30) NULL,
	[ProjectFiled] [datetime] NULL,
	[FiledBy] [bigint] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_FiledBy] FOREIGN KEY([FiledBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_FiledBy]
GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_UserCreated] FOREIGN KEY([UserCreated])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_UserCreated]
GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_UserModified] FOREIGN KEY([UserModified])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_UserModified]
GO

ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


