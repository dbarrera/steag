CREATE TABLE [dbo].[WebPageRegistry](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PageIdentity] [nvarchar](250) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[AssemblyName] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_WebPageRegistry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


