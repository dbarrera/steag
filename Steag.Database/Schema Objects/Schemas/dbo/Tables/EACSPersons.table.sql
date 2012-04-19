CREATE TABLE [dbo].[EACSPersons](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[EACSID] [bigint] NOT NULL,
	[PersonID] [bigint] NOT NULL,
	[Status] [nvarchar](60) NULL,
	[IsActive] [bit] NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_EACSPersons] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EACSPersons]  WITH CHECK ADD  CONSTRAINT [FK_EACSPersons_EACS] FOREIGN KEY([EACSID])
REFERENCES [dbo].[EACS] ([ID])
GO

ALTER TABLE [dbo].[EACSPersons] CHECK CONSTRAINT [FK_EACSPersons_EACS]
GO

ALTER TABLE [dbo].[EACSPersons]  WITH CHECK ADD  CONSTRAINT [FK_EACSPersons_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
GO

ALTER TABLE [dbo].[EACSPersons] CHECK CONSTRAINT [FK_EACSPersons_Person]
GO


