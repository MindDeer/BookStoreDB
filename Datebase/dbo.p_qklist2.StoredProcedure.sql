USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_qklist2]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_qklist2](@id char(30))
as

begin 
    select QK_MC 期刊名,QK_CP.QKCP_ID 副本条码,JY_DATE 借阅日期,GH_DATE 归还日期,DZ_ID 读者,Admin_JY 经办人,dbo.f_lendmoney(JY_DATE,GH_DATE) 累计租金
	   from QK_CP
	      join QKJY on QKJY.QKCP_ID=QK_CP.QKCP_ID
		  join QK on QK.QK_ID=QK_CP.QK_ID
		  join USR on USR_ID=DZ_ID
		  where QK_MC=@id
end

GO
