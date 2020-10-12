USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_deleteBookcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_deleteBookcopy](@copyid char(15))
as
delete TS_CP
	where TSCP_ID=@copyid;
GO
