USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[QK]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QK](
	[QK_ID] [int] NOT NULL,
	[QK_MC] [char](30) NOT NULL,
	[QKLB_ID] [char](20) NOT NULL,
	[QK_Code] [char](20) NOT NULL,
	[Author] [char](100) NULL,
	[Press] [char](100) NULL,
	[Frequency] [char](20) NULL,
	[Grade] [char](20) NULL,
	[JQ] [decimal](6, 2) NULL,
	[CB_DATE] [date] NULL,
	[DJ_DATE] [date] NULL,
 CONSTRAINT [QK_key] PRIMARY KEY CLUSTERED 
(
	[QK_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QK]  WITH CHECK ADD  CONSTRAINT [QKLB_F1key] FOREIGN KEY([QKLB_ID])
REFERENCES [dbo].[QKLB] ([QKLB_ID])
GO
ALTER TABLE [dbo].[QK] CHECK CONSTRAINT [QKLB_F1key]
GO
