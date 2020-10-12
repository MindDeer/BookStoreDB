USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertsellcopy2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_insertsellcopy2](@copyid char(20))
as
begin
--	declare @tips int;
--	select @tips=count(*) from v_showsellcopy;
--if(@tips=0)
--begin
--declare @copyid char(20);set @copyid='TS27001';
insert into v_showsellcopy2
    select QKCP_ID,QK_MC,QK_Code,Author,Press,JQ    
	from QK join QK_CP on QK.QK_ID=QK_CP.QK_ID
	where QKCP_ID=@copyid
--select 图书副本号,图书名称,ISBN编号,作者,出版社,价钱 
--	from v_showsellcopy 
--end;
--select * from v_showsellcopy
--truncate table v_showsellcopy --不受约束，清空v_showsellcopy
--truncate table TSLS
end
GO
