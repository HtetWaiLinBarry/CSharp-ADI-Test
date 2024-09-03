USE [PeerReview(WME)]
GO

/****** Object:  Table [dbo].[Rating]    Script Date: 3/25/2020 2:07:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Rating](
	[RatingID] [varchar](50) NOT NULL,
	[CommentID] [varchar](50) NOT NULL,
	[RatingNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([CommentID])
REFERENCES [dbo].[Comment] ([CommentID])
GO


