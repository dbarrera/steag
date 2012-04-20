CREATE TABLE [dbo].[EACS](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SARFID] [bigint] NOT NULL,
	[EACSCode] [nvarchar](60) NOT NULL,
	[TransactionDate] [datetime] NULL,
	[Purpose] [nvarchar](250) NULL,
	[IsFirstVisit] [bit] NULL,
	[Notes] [nvarchar](500) NULL,
	[Status] [nvarchar](60) NULL,
	[ProcessedDate] [datetime] NULL,
	[ProcessedBy] [bigint] NULL,
	[VerifiedDate] [datetime] NULL,
	[VerifiedBy] [bigint] NULL,
	[ClosedDate] [datetime] NULL,
	[ClosedBy] [bigint] NULL,
	[IsActive] [bit] NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_EACS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EACS]  WITH CHECK ADD  CONSTRAINT [FK_EACS_ClosedBy] FOREIGN KEY([ClosedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[EACS] CHECK CONSTRAINT [FK_EACS_ClosedBy]
GO

ALTER TABLE [dbo].[EACS]  WITH CHECK ADD  CONSTRAINT [FK_EACS_ProcessedBy] FOREIGN KEY([ProcessedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[EACS] CHECK CONSTRAINT [FK_EACS_ProcessedBy]
GO

ALTER TABLE [dbo].[EACS]  WITH CHECK ADD  CONSTRAINT [FK_EACS_SARF] FOREIGN KEY([SARFID])
REFERENCES [dbo].[SARF] ([ID])
GO

ALTER TABLE [dbo].[EACS] CHECK CONSTRAINT [FK_EACS_SARF]
GO

ALTER TABLE [dbo].[EACS]  WITH CHECK ADD  CONSTRAINT [FK_EACS_VerifiedBy] FOREIGN KEY([VerifiedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[EACS] CHECK CONSTRAINT [FK_EACS_VerifiedBy]
GO


