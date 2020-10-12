USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_listsellcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_listsellcopy]
as
select 图书副本号,图书名称,ISBN编号,作者,出版社,价钱 from v_showsellcopy
GO
