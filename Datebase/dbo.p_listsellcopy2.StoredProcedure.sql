USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_listsellcopy2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_listsellcopy2]
as
select 期刊副本号,期刊名称,ISSN编号,主管单位,主办单位,价钱 from v_showsellcopy2
GO
