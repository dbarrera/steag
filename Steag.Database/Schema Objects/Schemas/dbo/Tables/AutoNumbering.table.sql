CREATE TABLE [dbo].[AutoNumbering](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TransactionCode] [nvarchar](60) NULL,
	[Prefix] [nvarchar](60) NULL,
	[Suffix] [nvarchar](60) NULL,
	[Counter] [bigint] NULL,
	[Format] [nvarchar](60) NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_AutoNumbering] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AutoNumbering]  WITH CHECK ADD  CONSTRAINT [FK_AutoNumbering_UserCreated] FOREIGN KEY([UserCreated])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[AutoNumbering] CHECK CONSTRAINT [FK_AutoNumbering_UserCreated]
GO

ALTER TABLE [dbo].[AutoNumbering]  WITH CHECK ADD  CONSTRAINT [FK_AutoNumbering_UserModified] FOREIGN KEY([UserModified])
REFERENCES [dbo].[UserAccount] ([ID])
GO

ALTER TABLE [dbo].[AutoNumbering] CHECK CONSTRAINT [FK_AutoNumbering_UserModified]
GO


