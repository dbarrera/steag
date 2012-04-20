CREATE TABLE [dbo].[UserRole](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleCode] [nvarchar](60) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[IsTemplate] [bit] NOT NULL,
	[IsActive] [bit] NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UserRole] ADD  CONSTRAINT [DF_UserRole_IsTemplate]  DEFAULT ((0)) FOR [IsTemplate]
GO


