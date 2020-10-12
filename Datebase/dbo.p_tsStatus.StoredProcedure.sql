USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_tsStatus]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[p_tsStatus]
as
begin
	select TS.TS_ID 编号,TS_MC 书名,TS_Code 国际编号,Author 作者,Press 出版社,JQ 价钱,可借数量
		from TS,v_tsxx
		where TS.TS_ID=v_tsxx.TS_ID		
end;
GO
