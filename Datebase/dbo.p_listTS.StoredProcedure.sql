USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_listTS]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_listTS]
as
select TS_ID 编号,TS_MC 书名,TSLB_ID 类别号,TS_Code 'ISBN 编号',Author 作者,Press 出版社,JQ 价钱,CB_DATE 出版日期 from TS
GO
