/*** Ramesh/GPSTRACKER data base    ***/

USE [SchoolBusTracker]
GO

/****** Object:  Table [dbo].[tbl_Students]    Script Date: 9/24/2019 11:36:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Students](
	[RollNumber] [numeric](18, 0) NULL,
	[FirstName] [char](10) NULL,
	[LastName] [varchar](50) NULL,
	[IdNum] [varchar](50) NOT NULL
) ON [PRIMARY]

GO


