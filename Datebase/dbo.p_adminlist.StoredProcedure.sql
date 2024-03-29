USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_adminlist]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_adminlist](@id char(15))
as

begin 
    select TS_MC 书名,TS_CP.TSCP_ID 副本条码,JY_DATE 借书日期,GH_DATE 还书日期,DZ_ID 读者,Admin_JY 经办人,dbo.f_lendmoney(JY_DATE,GH_DATE) 累计租金
	   from TS_CP
	      join TSJY on TSJY.TSCP_ID=TS_CP.TSCP_ID
		  join TS on TS.TS_ID=TS_CP.TS_ID
		  join USR on USR_ID=DZ_ID
	where Admin_JY=@id
end
GO
