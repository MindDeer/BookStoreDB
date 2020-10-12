USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[v_showsellcopy]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[v_showsellcopy](
	[图书副本号] [char](20) NOT NULL,
	[图书名称] [char](30) NULL,
	[ISBN编号] [char](20) NULL,
	[作者] [char](20) NULL,
	[出版社] [char](30) NULL,
	[价钱] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[图书副本号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[v_showsellcopy]  WITH CHECK ADD  CONSTRAINT [f_sellcopy] FOREIGN KEY([图书副本号])
REFERENCES [dbo].[TS_CP] ([TSCP_ID])
GO
ALTER TABLE [dbo].[v_showsellcopy] CHECK CONSTRAINT [f_sellcopy]
GO
