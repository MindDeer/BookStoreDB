USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_lending]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* **************************************************************
  存储过程：根据借书证编号和图书编号完成借书
  参数：共6个，前3个为输入型，后3个为输出型
  @dzId:借书证编号
  @staffId:借出经办人编号
  @tsId:图书编号
  @code:返回四种信息：OK；False；借书证编号错误；图书不可借出
  @account:读者登录名
  @title:书名
  功能：首先检查借书证是否有效，然后检测相应图书是否可借出，
      检查通过后，则使用前三个参数和当前时间向图书借阅表（TSJY）插入一条借书记录，
	  并返回所借图书的书名和借书人的姓名。
**************************************************************** */

CREATE procedure [dbo].[p_lending](@dzId int,@adminId int,@barcode char(20),
                    @code char(30) output,@account char(20) output,@title char(30) output)
as
begin
   select @account=Name
   from USR
   where USR_ID=@dzId;
   if (@@ROWCOUNT<>1)
   begin
      set @code='借书证号错误';
      return;
   end
   declare @copyId char(20);  --图书副本的编号
   select @title=TS_MC,@copyId=TSCP_ID
       from v_ts_copy
	   where TSCP_ID=@barcode and TS_Status=1;
   if(@@ROWCOUNT<>1)
   begin
      set @code='图书不可借出'
      return
   end
--可以借出  
   set @code='OK'
   insert into TSJY(TSCP_ID,DZ_ID,JY_DATE,Admin_JY)
       values(@copyId,@dzId,GETDATE(),@adminId)
      
end
GO
