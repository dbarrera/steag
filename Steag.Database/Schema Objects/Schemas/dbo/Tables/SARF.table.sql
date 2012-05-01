CREATE TABLE [dbo].[SARF](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SARFCode] [nvarchar](60) NOT NULL,
	[DateFiled] [datetime] NULL,
	[DateOfVisit] [datetime] NULL,
	[FiledBy] [bigint] NOT NULL,
	[Purpose] [nvarchar](250) NULL,
	[SourceIP] [nvarchar](60) NULL,
	[Status] [nvarchar](60) NOT NULL,
	[ApprovedBy] [bigint] NULL,
	[DateVisited] [datetime] NULL,
	[VisitVerifiedBy] [bigint] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_SARF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SARF]  WITH CHECK ADD  CONSTRAINT [FK_SARF_ApprovedBy] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[SARF] CHECK CONSTRAINT [FK_SARF_ApprovedBy]
GO

ALTER TABLE [dbo].[SARF]  WITH CHECK ADD  CONSTRAINT [FK_SARF_FiledBy] FOREIGN KEY([FiledBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[SARF] CHECK CONSTRAINT [FK_SARF_FiledBy]
GO

ALTER TABLE [dbo].[SARF]  WITH CHECK ADD  CONSTRAINT [FK_SARF_VerifiedBy] FOREIGN KEY([VisitVerifiedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[SARF] CHECK CONSTRAINT [FK_SARF_VerifiedBy]
GO

ALTER TABLE [dbo].[SARF] ADD  CONSTRAINT [DF_SARF_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


