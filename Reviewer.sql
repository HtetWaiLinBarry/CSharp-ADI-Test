USE [PeerReview(WME)]
GO

/****** Object:  Table [dbo].[Reviewer]    Script Date: 3/25/2020 2:08:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Reviewer](
	[ReviewerID] [varchar](50) NOT NULL,
	[ReviewerName] [varchar](50) NOT NULL,
	[ReviewerDate] [varchar](255) NULL,
	[ReviewerSkill] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReviewerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


