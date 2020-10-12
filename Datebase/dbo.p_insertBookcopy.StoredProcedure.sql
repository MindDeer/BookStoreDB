USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertBookcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_insertBookcopy](@tsid int,@copyid char(20),@status char(10))
as
insert TS_CP(TSCP_ID,TS_ID,TS_Status)
	values(@copyid,@tsid,@status)

	--exec p_insertBookcopy 1,'TS27998',1
GO
