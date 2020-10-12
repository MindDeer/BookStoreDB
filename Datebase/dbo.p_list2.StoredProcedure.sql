USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_list2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_list2](@id int)
as

begin 
    select QK_MC 期刊名,Author 发行商,QK_CP.QKCP_ID 条码,JY_DATE 借书日期,dbo.f_date(JY_DATE,GH_DATE) as 应还日期,dbo.f_lendmoney(JY_DATE,GH_DATE) 累计租金
	   from QK_CP
	      join QKJY on QKJY.QKCP_ID=QK_CP.QKCP_ID
		  join QK on QK.QK_ID=QK_CP.QK_ID
		  join USR on USR_ID=DZ_ID
		  where USR.USR_ID=@id
end
GO
