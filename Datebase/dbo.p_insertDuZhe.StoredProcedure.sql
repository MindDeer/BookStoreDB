USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertDuZhe]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_insertDuZhe](@dzId char(15),@name char(20),@sex char(2),@idcard char(30),@password char(15),@phone char(12),@type int,@djdate date)
as
insert into USR(USR_ID,Name,Sex,ID_Card,Password,Phone,Type,DJ_DATE)
	values(@dzId,@name,@sex,@idcard,@password,@phone,@type,@djdate)
GO
