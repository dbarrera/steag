CREATE TABLE [dbo].[BadgeRegistry](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[BadgeCode] [nvarchar](60) NULL,
	[IsIssued] [bit] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_BadgeRegistry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[BadgeRegistry] ADD  CONSTRAINT [DF_BadgeRegistry_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


