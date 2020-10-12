USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_statuschange2]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_statuschange2](@copyid char(20),@status int)
	returns char(10)
as
begin
	declare @tip char(10);
	select @status=QK_Status from QK_CP where QKCP_ID=@copyid
	if(@status=1)
	begin set @tip='可借' end
	else if(@status=2)
	begin set @tip='已借出' end
	else if(@status=2)
	begin set @tip='损坏' end
	return @tip
end
GO
