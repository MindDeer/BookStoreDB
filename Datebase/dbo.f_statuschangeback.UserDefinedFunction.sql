USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_statuschangeback]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create function [dbo].[f_statuschangeback](@copyid char(20),@status char(10))
	returns int
as
begin
	declare @tip int;
	select @status=TS_Status from TS_CP where TSCP_ID=@copyid
	if(@status='可借')
	begin set @tip=1 end
	else if(@status='已借出')
	begin set @tip=2 end
	else if(@status='损坏')
	begin set @tip=3 end
	return @tip
end
GO
