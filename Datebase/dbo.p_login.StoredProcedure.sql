USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_login]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* **********************************************************************
   存储过程：登录验证
   参数：
   @account：登录账号
   @password：密码
   @type：登录类型（=0表示所有人员登录，=1表示管理员登录）
   @id：返回登录账号的主键值，输出型参数（@id=0表示登录失败，@id>0表示登陆者的主键值）
   功能：根据提供的参数，对账号和密码与数据库中预留的信息进行比对，
        相符时返回用户的主键值（登录成功），不相符时返回0（登录失败）
************************************************************************* */
CREATE procedure [dbo].[p_login]( @account char(15),@password char(15),@type int output,@id int output)
as

if @type=0            --普通读者登录
   begin 
      select @id=USR_ID
	     from USR
		 where Name=@account and Password=@password;
	  if(@@ROWCOUNT<>1)
	  begin 
	     set @id=0;   --登录失败
	  end
   end
else                  --管理人员登录
   begin
      select @id=USR_ID
	     from USR
		 where Name=@account and Password=@password and Type>0;  --必须是管理员
	  if(@@ROWCOUNT<>1)
	  begin 
	     set @id=0;  --登录失败
	  end
   end
GO
