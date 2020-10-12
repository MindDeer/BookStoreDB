USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updateQKcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_updateQKcopy](@qkid char(15),@copyid char(15),@status char(10))
as
update QK_CP
	set QKCP_ID=@copyid,
		QK_ID=dbo.f_booknametoid(@qkid,@copyid),
		QK_Status=dbo.f_statuschangeback2(@copyid,@status)
	where QKCP_ID=@copyid;
GO
