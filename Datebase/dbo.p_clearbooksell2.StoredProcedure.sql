USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_clearbooksell2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_clearbooksell2]
as
truncate table v_showsellcopy2
--不受约束，清空v_showsellcopy
--truncate table TSLS
GO
