USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_listDZ]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_listDZ]
as
select USR_ID 借书证号,Name 姓名,Sex 性别,ID_Card 身份证号,Password 密码,Phone 联系电话,Type 用户类型,DJ_DATE 登记日期 
from USR
where Type=0
GO
