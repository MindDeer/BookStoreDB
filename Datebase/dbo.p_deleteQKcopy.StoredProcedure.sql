USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_deleteQKcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_deleteQKcopy](@copyid char(15))
as
delete QK_CP
	where QKCP_ID=@copyid;
GO
