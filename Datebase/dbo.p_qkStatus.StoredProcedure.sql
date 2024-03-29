USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_qkStatus]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[p_qkStatus]
as
begin
	select QK.QK_ID 编号,QK_MC 期刊名,QK_Code 国际编号,Author 作者,Press 发行商,Grade 刊物等级,JQ 价钱,可借数量
		from QK,v_qkxx
		where QK.QK_ID=v_qkxx.QK_ID
end;
GO
