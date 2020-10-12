USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_returning2]    Script Date: 2020/10/12 16:58:26 ******/
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
CREATE proc [dbo].[p_returning2](@copyId char(20),@staffId int,
		@code char(50) output,@title char(50) output,@account char(20) output)
as
select @title=QK_MC,@account=Name
	   from QK_CP
			join QKJY on QKJY.QKCP_ID=QK_CP.QKCP_ID
			join QK on QK.QK_ID=QK_CP.QK_ID
			join USR on USR_ID=DZ_ID
	   where QKJY.QKCP_ID=@copyId
declare @id char(20);
select @id=QKCP_ID
	from QKJY
	where QKCP_ID=@copyId;
if(@@ROWCOUNT<>1)
begin
	set @code='归还失败，期刊条码错误'
end;
else
begin
	declare @tip date;
	select @tip=GH_DATE
		from QKJY
		where QKCP_ID=@copyId;
	if(@tip is null)
	begin
		update QKJY
			set GH_DATE=getdate(),Admin_GH=@staffId
			where QKCP_ID=@copyId and GH_DATE is null;
		set @code='OK'
	end;
	else
	begin
		set @code='归还失败，该期刊尚未借出'
	end;
end
GO
