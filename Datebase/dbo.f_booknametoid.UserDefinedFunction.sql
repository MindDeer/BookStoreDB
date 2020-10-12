USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_booknametoid]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_booknametoid](@tsmc char(30),@copyid char(20))
	returns int
as
begin 
	declare @id int;
	select @id=TS_CP.TS_ID 
		from TS 
		join TS_CP on TS.TS_ID=TS_CP.TS_ID
		where TS_MC=@tsmc and TSCP_ID=@copyid
	return @id;
end

--select dbo.f_booknametoid('全球通史','TS27001')
GO
