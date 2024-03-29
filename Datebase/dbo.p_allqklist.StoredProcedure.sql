USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_allqklist]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_allqklist]
as
select QK_CP.QK_ID 编号,QK_MC 期刊名,QKLB.QKLB_MC 类别,QK_Code 'ISSN 编号',Author 主管单位,Press 主办单位,Frequency 刊期,Grade 级别,JQ 价钱,count(QK_CP.QK_ID) 在册数量,可借数量
	from QK
	join QK_CP on QK.QK_ID=QK_CP.QK_ID
	join v_qkxx on QK.QK_ID=v_qkxx.QK_ID
	join QKLB on QK.QKLB_ID=QKLB.QKLB_ID
	group by QK_CP.QK_ID,QK.QK_MC,QKLB.QKLB_MC,QK.QK_Code,QK.Author,QK.Press,QK.JQ,v_qkxx.可借数量,QK.Frequency,QK.Grade
GO
