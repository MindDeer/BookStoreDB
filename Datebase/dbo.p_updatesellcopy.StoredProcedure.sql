USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updatesellcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_updatesellcopy](@copyid char(20),@tsmc char(30),@code char(20),@author char(20),@press char(30),@money decimal(6,2))
as
update v_showsellcopy
	set 图书副本号=@copyid,图书名称=@tsmc,ISBN编号=@code,作者=@author,出版社=@press,价钱=@money
	where 图书副本号=@copyid;    

GO
