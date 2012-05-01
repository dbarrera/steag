CREATE TABLE [dbo].[UserRoleWebPage](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserRoleID] [bigint] NOT NULL,
	[WebPageID] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_UserRoleWebPage] PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC,
	[WebPageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UserRoleWebPage]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleWebPage_UserRole] FOREIGN KEY([UserRoleID])
REFERENCES [dbo].[UserRole] ([ID])
GO

ALTER TABLE [dbo].[UserRoleWebPage] CHECK CONSTRAINT [FK_UserRoleWebPage_UserRole]
GO

ALTER TABLE [dbo].[UserRoleWebPage]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleWebPage_WebPage] FOREIGN KEY([WebPageID])
REFERENCES [dbo].[WebPageRegistry] ([ID])
GO

ALTER TABLE [dbo].[UserRoleWebPage] CHECK CONSTRAINT [FK_UserRoleWebPage_WebPage]
GO

ALTER TABLE [dbo].[UserRoleWebPage] ADD  CONSTRAINT [DF_UserRoleWebPage_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


