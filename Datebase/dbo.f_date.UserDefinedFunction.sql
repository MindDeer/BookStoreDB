USE [BookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[f_date]    Script Date: 2020/10/12 16:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[f_date](@jy_date datetime,@gh_date datetime) 
   returns char(10)
as
begin 
   if(@gh_date is null)
   begin
       return convert(char(10),dateadd(day,30,@jy_date),23);
   end
   begin
       return '已归还'
   end
end;
GO
