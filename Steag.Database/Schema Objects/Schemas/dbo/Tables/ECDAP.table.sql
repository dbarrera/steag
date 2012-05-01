CREATE TABLE [dbo].[ECDAP](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[EACSID] [bigint] NOT NULL,
	[ECDAPCode] [nvarchar](60) NULL,
	[BadgeID] [bigint] NOT NULL,
	[DateIssued] [datetime] NULL,
	[IssuedTo] [bigint] NOT NULL,
	[IssuedBy] [bigint] NULL,
	[DateReturned] [datetime] NULL,
	[IsReturned] [bit] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_ECDAP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ECDAP]  WITH CHECK ADD  CONSTRAINT [FK_ECDAP_BadgeRegistry] FOREIGN KEY([BadgeID])
REFERENCES [dbo].[BadgeRegistry] ([ID])
GO

ALTER TABLE [dbo].[ECDAP] CHECK CONSTRAINT [FK_ECDAP_BadgeRegistry]
GO

ALTER TABLE [dbo].[ECDAP]  WITH CHECK ADD  CONSTRAINT [FK_ECDAP_Person] FOREIGN KEY([IssuedTo])
REFERENCES [dbo].[Person] ([ID])
GO

ALTER TABLE [dbo].[ECDAP] CHECK CONSTRAINT [FK_ECDAP_Person]
GO

ALTER TABLE [dbo].[ECDAP]  WITH CHECK ADD  CONSTRAINT [FK_ECDAP_UserAccount] FOREIGN KEY([IssuedBy])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[ECDAP] CHECK CONSTRAINT [FK_ECDAP_UserAccount]
GO

ALTER TABLE [dbo].[ECDAP] ADD  CONSTRAINT [DF_ECDAP_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


