USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_lending2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[p_lending2](@dzId int,@adminId int,@barcode char(20),
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

   declare @copyId char(20);  --期刊副本的编号
   select @title=QK_MC,@copyId=QKCP_ID
   from v_qk_copy
   where QKCP_ID=@barcode and QK_Status=1;
   if(@@ROWCOUNT<>1)
   begin
      set @code='期刊不可借出'
      return
   end

--可以借出  
   insert into QKJY(QKCP_ID,DZ_ID,JY_DATE,Admin_JY)
       values(@copyId,@dzId,GETDATE(),@adminId)
	set @code='OK'
      
end
GO
