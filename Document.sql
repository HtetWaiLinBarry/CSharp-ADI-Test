USE [PeerReview(WME)]
GO

/****** Object:  Table [dbo].[Document]    Script Date: 3/25/2020 2:07:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Document](
	[DocumentID] [varchar](50) NOT NULL,
	[DocumentName] [varchar](50) NOT NULL,
	[UploadFile] [varchar](255) NOT NULL,
	[UploadDate] [varchar](50) NOT NULL,
	[AuthorID] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Document]  WITH CHECK ADD FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
GO


