USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_returning]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* *********************************************************
还书存储过程：
参数：3个，前两个传入，后两个传出
@barcode、@staffId、@code(还书成功返回OK，条码输入错误时返回失败）
功能：返回成功OK标志后，无条件还书，更新借还表的归还日期
************************************************************ */
CREATE proc [dbo].[p_returning](@copyId char(20),@staffId int,
		@code char(50) output,@title char(50) output,@account char(20) output)
as
select @title=TS_MC,@account=Name
	   from TS_CP
			join TSJY on TSJY.TSCP_ID=TS_CP.TSCP_ID
			join TS on TS.TS_ID=TS_CP.TS_ID
			join USR on USR_ID=DZ_ID
	   where TSJY.TSCP_ID=@copyId
declare @id char(20);
select @id=TSCP_ID
	from TSJY
	where TSCP_ID=@copyId;
if(@@ROWCOUNT<>1)
begin
	set @code='还书失败，图书条码错误'
end;
else
begin
	declare @tip date;
	select @tip=GH_DATE
		from TSJY
		where TSCP_ID=@copyId;
	if(@tip is null)
	begin
		update TSJY
			set GH_DATE=getdate(),Admin_GH=@staffId
			where TSCP_ID=@copyId and GH_DATE is null;
		set @code='OK'
	end;
	else
	begin
		set @code='还书失败，该图书尚未借出'
	end;
end;
GO
