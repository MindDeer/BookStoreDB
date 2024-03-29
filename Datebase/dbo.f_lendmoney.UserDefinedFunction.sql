USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_lendmoney]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[f_lendmoney](@jydate datetime,@ghdate datetime)
	returns decimal(4,2)
as
begin
declare @time int;
declare @money decimal(4,2);
if(@ghdate is not null)
begin
	set @time=convert(int,@ghdate-@jydate);
	if(@time>0 and @time<=15)
	begin 
		set @money=@time*0.60
	end;
	else
	begin
		set @money=@time*0.50
	end;
	return @money
end;	
begin
	set @time=convert(int,getdate()-@jydate);
	if(@time>0 and @time<=15)
	begin 
		set @money=@time*0.60
	end;
	else
	begin
		set @money=@time*0.50
	end;
	return @money
end;
end
GO
