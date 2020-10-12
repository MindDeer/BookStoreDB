USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_nameQKcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_nameQKcopy](@id char(30))
as
select QKCP_ID 副本编号,QK_MC 期刊名称,QK_CP.QK_ID 期刊编号,dbo.f_statuschange2(QKCP_ID,QK_Status) 副本状态
	from QK_CP
	join QK on QK.QK_ID=QK_CP.QK_ID
	where QK_MC=@id
	
GO
