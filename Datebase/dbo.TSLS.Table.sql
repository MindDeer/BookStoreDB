USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[TSLS]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TSLS](
	[ID] [char](20) NOT NULL,
	[TSCP_ID] [char](20) NOT NULL,
	[JQ] [decimal](6, 2) NOT NULL,
	[LS_DATE] [date] NOT NULL,
	[Admin] [char](15) NOT NULL,
	[Tips] [char](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TSLS]  WITH CHECK ADD  CONSTRAINT [TS_F2key] FOREIGN KEY([TSCP_ID])
REFERENCES [dbo].[TS_CP] ([TSCP_ID])
GO
ALTER TABLE [dbo].[TSLS] CHECK CONSTRAINT [TS_F2key]
GO
