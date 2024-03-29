USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[USR]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USR](
	[USR_ID] [char](15) NOT NULL,
	[Name] [char](20) NOT NULL,
	[Sex] [char](2) NULL,
	[ID_Card] [char](30) NOT NULL,
	[Password] [char](15) NOT NULL,
	[Phone] [char](12) NOT NULL,
	[Type] [tinyint] NOT NULL,
	[DJ_DATE] [date] NULL,
 CONSTRAINT [USR_key] PRIMARY KEY CLUSTERED 
(
	[USR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[USR]  WITH CHECK ADD  CONSTRAINT [SexChk] CHECK  (([Sex]='男' OR [Sex]='女'))
GO
ALTER TABLE [dbo].[USR] CHECK CONSTRAINT [SexChk]
GO
