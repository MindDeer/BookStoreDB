USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_sumsellcopy2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_sumsellcopy2](@sum money output)
as
select @sum=SUM(价钱) from v_showsellcopy2
GO
