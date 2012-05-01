CREATE TABLE [dbo].[SARFPersons](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SARFID] [bigint] NOT NULL,
	[PersonID] [bigint] NOT NULL,
	[Status] [nvarchar](60) NULL,
	[FirstVisit] [bit] NULL,
	[WasInVisit] [bit] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_SARFPersons] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SARFPersons]  WITH CHECK ADD  CONSTRAINT [FK_SARFPersons_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
GO

ALTER TABLE [dbo].[SARFPersons] CHECK CONSTRAINT [FK_SARFPersons_Person]
GO

ALTER TABLE [dbo].[SARFPersons]  WITH CHECK ADD  CONSTRAINT [FK_SARFPersons_SARF] FOREIGN KEY([SARFID])
REFERENCES [dbo].[SARF] ([ID])
GO

ALTER TABLE [dbo].[SARFPersons] CHECK CONSTRAINT [FK_SARFPersons_SARF]
GO

ALTER TABLE [dbo].[SARFPersons] ADD  CONSTRAINT [DF_SARFPersons_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


