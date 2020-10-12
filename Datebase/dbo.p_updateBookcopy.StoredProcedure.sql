USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updateBookcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_updateBookcopy](@tsid char(15),@copyid char(15),@status char(10))
as
declare @statusid int;
set @statusid=dbo.f_statuschangeback(@copyid,@status);
update TS_CP
	set TSCP_ID=@copyid,
		TS_ID=@tsid,
		TS_Status=@statusid
	where TSCP_ID=@copyid;
GO
