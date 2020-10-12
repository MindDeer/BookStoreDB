USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertQKcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_insertQKcopy](@qkid int,@copyid char(20),@status char(10))
as
insert QK_CP(QKCP_ID,QK_ID,QK_Status)
	values(@copyid,@qkid,@status)

	--exec p_insertBookcopy 1,'TS27998',1
GO
