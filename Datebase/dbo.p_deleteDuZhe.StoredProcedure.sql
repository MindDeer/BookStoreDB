USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_deleteDuZhe]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_deleteDuZhe](@dzId char(15),@name char(20),@sex char(2),@idcard char(30),@password char(15),@phone char(12),@type int,@djdate date)
as
delete from USR
	where USR_ID=@dzId;
GO
