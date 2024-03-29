USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_statuschange]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_statuschange](@copyid char(20),@status int)
	returns char(10)
as
begin
	declare @tip char(10);
	select @status=TS_Status from TS_CP where TSCP_ID=@copyid
	if(@status=1)
	begin set @tip='可借' end
	else if(@status=2)
	begin set @tip='已借出' end
	else if(@status=2)
	begin set @tip='损坏' end
	return @tip
end
GO
