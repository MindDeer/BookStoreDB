USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_list]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_list](@id int)
as

begin 
    select TS_MC 书名,Author 作者,TS_CP.TSCP_ID 条码,JY_DATE 借书日期,dbo.f_date(JY_DATE,GH_DATE) as 应还日期,dbo.f_lendmoney(JY_DATE,GH_DATE) 累计租金
	   from TS_CP
	      join TSJY on TSJY.TSCP_ID=TS_CP.TSCP_ID
		  join TS on TS.TS_ID=TS_CP.TS_ID
		  join USR on USR_ID=DZ_ID
		  where USR.USR_ID=@id
end
GO
