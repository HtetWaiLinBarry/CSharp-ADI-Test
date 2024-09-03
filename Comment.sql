USE [PeerReview(WME)]
GO

/****** Object:  Table [dbo].[Comment]    Script Date: 3/25/2020 2:17:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Comment](
	[CommentID] [varchar](50) NOT NULL,
	[ReviewerID] [varchar](50) NOT NULL,
	[DocumentID] [varchar](50) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[CommentDate] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([DocumentID])
REFERENCES [dbo].[Document] ([DocumentID])
GO

ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([ReviewerID])
REFERENCES [dbo].[Reviewer] ([ReviewerID])
GO


