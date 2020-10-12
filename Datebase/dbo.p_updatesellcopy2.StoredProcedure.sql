USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updatesellcopy2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_updatesellcopy2](@copyid char(20),@tsmc char(30),@code char(20),@author char(20),@press char(30),@money decimal(6,2))
as
update v_showsellcopy2
	set 期刊副本号=@copyid,期刊名称=@tsmc,ISSN编号=@code,主管单位=@author,主办单位=@press,价钱=@money
	where 期刊副本号=@copyid;    

GO
