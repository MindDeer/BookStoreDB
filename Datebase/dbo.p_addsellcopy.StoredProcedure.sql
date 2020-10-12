USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_addsellcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_addsellcopy](@id char(20),@copyid char(20),@money decimal(6,2),@admin char(15),@tips char(100))
as
insert into TSLS(ID,TSCP_ID,JQ,LS_DATE,Admin,Tips)
	values(@id,@copyid,@money,getdate(),@admin,@tips)
GO
