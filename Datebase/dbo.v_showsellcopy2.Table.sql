USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[v_showsellcopy2]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[v_showsellcopy2](
	[期刊副本号] [char](20) NOT NULL,
	[期刊名称] [char](30) NULL,
	[ISSN编号] [char](20) NULL,
	[主管单位] [char](30) NULL,
	[主办单位] [char](30) NULL,
	[价钱] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[期刊副本号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[v_showsellcopy2]  WITH CHECK ADD  CONSTRAINT [f_sellcopy2] FOREIGN KEY([期刊副本号])
REFERENCES [dbo].[QK_CP] ([QKCP_ID])
GO
ALTER TABLE [dbo].[v_showsellcopy2] CHECK CONSTRAINT [f_sellcopy2]
GO
