CREATE TABLE [dbo].[WatchList](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](250) NULL,
	[FirstName] [nvarchar](250) NULL,
	[MiddleName] [nvarchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Notes] [nvarchar](500) NULL,
	[Photo] [image] NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_WatchList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[WatchList] ADD  CONSTRAINT [DF_WatchList_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


