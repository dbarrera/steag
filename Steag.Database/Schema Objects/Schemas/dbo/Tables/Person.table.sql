CREATE TABLE [dbo].[Person](
	[ID] [bigint] NOT NULL,
	[LastName] [nvarchar](250) NOT NULL,
	[FirstName] [nvarchar](250) NOT NULL,
	[MiddleName] [nvarchar](250) NULL,
	[Birthday] [datetime] NULL,
	[Sex] [nvarchar](10) NULL,
	[Position] [nvarchar](60) NULL,
	[Photo] [image] NULL,
	[CompanyID] [bigint] NULL,
	[HasVisited] [bit] NULL,
	[DateOfFirstVisit] [datetime] NULL,
	[LastVisited] [datetime] NULL,
	[IsActive] [bit] NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_CompanyEmployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_CompanyEmployee_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([ID])
GO

ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_CompanyEmployee_Company]
GO

ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_CompanyEmployee_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO