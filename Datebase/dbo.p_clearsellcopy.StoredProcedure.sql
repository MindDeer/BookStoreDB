USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_clearsellcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_clearsellcopy]
as
truncate table v_showsellcopy 
--不受约束，清空v_showsellcopy
GO
