USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_searchbooksell]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_searchbooksell](@id char(20))
as
select ID 销售单号,TSCP_ID 图书副本号,JQ 价钱,LS_DATE 销售日期,Admin 经手人,Tips 备注
from TSLS
where ID=@id
GO
