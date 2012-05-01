CREATE TABLE [dbo].[EACSVehicles](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[EACSID] [bigint] NOT NULL,
	[RegistrationNumber] [nvarchar](60) NULL,
	[SequenceNumber] [nvarchar](60) NULL,
	[VehicleType] [nvarchar](60) NULL,
	[DriversName] [nvarchar](250) NULL,
	[DriversLicenseNumber] [nvarchar](60) NULL,
	[IsInspectionDone] [bit] NOT NULL,
	[IssuedParkingPermit] [nvarchar](60) NULL,
	[ParkingPermitColor] [nvarchar](60) NULL,
	[NumberOfPassengers] [smallint] NULL,
	[HasLiquor] [bit] NULL,
	[HasFireArm] [bit] NULL,
	[HasAmmunition] [bit] NULL,
	[HasDeadlyWeapon] [bit] NULL,
	[Status] [nvarchar](60) NULL,
	[IsActive] [bit] NOT NULL,
	[UserCreated] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[UserModified] [bigint] NULL,
	[DateModified] [datetime] NULL,
 CONSTRAINT [PK_EACS_Vehicles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EACSVehicles]  WITH CHECK ADD  CONSTRAINT [FK_EACSVehicles_EACS] FOREIGN KEY([EACSID])
REFERENCES [dbo].[EACS] ([ID])
GO

ALTER TABLE [dbo].[EACSVehicles] CHECK CONSTRAINT [FK_EACSVehicles_EACS]
GO

ALTER TABLE [dbo].[EACSVehicles] ADD  CONSTRAINT [DF_EACSVehicles_IsInspectionDone]  DEFAULT ((0)) FOR [IsInspectionDone]
GO

ALTER TABLE [dbo].[EACSVehicles] ADD  CONSTRAINT [DF_EACSVehicles_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


