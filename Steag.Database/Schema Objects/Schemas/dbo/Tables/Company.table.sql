CREATE TABLE [dbo].[Company](
	[ID] [bigint] NOT NULL,
	[CompanyName] [nvarchar](250) NOT NULL,
	[Address1] [nvarchar](250) NULL,
	[Address2] [nvarchar](250) NULL,
	[State] [nvarchar](250) NULL,
	[Country] [nvarchar](250) NULL,
	[PostalCode] [nvarchar](250) NULL,
	[EmailAddress2] [nvarchar](250) NULL,
	[EmailAddrses2] [nvarchar](250) NULL,
	[ContactPerson] [bigint] NULL,
	[TelNo1] [nvarchar](15) NULL,
	[TelNo2] [nvarchar](15) NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


