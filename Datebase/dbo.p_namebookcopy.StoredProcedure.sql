USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_namebookcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_namebookcopy](@id char(30))
as
select TSCP_ID 副本编号,TS_MC 图书名称,TS_CP.TS_ID 图书编号,dbo.f_statuschange(TSCP_ID,TS_Status) 副本状态
	from TS_CP
	join TS on TS.TS_ID=TS_CP.TS_ID
	where TS_MC=@id;
	
GO
