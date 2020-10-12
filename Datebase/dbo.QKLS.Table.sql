USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[QKLS]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QKLS](
	[ID] [char](20) NOT NULL,
	[QKCP_ID] [char](20) NOT NULL,
	[JQ] [decimal](6, 2) NOT NULL,
	[LS_DATE] [date] NOT NULL,
	[Admin] [char](15) NOT NULL,
	[Tips] [char](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QKLS]  WITH CHECK ADD  CONSTRAINT [QK_F2key] FOREIGN KEY([QKCP_ID])
REFERENCES [dbo].[QK_CP] ([QKCP_ID])
GO
ALTER TABLE [dbo].[QKLS] CHECK CONSTRAINT [QK_F2key]
GO
