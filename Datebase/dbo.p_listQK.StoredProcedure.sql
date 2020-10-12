USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_listQK]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_listQK]
as
select QK_ID 编号,QK_MC 期刊名,QKLB_ID 类别号,QK_Code 'ISSN 编号',Author 主管单位,Press 主办单位,Frequency 刊期,Grade 级别,JQ 价钱,CB_DATE 出版日期 from QK
GO
