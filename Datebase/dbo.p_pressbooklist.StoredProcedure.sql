USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_pressbooklist]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_pressbooklist](@id char(30))
as
select TS_CP.TS_ID 编号,TS_MC 书名,TSLB.TSLB_MC 类别,TS_Code 'ISBN 编号',Author 作者,Press 出版社,JQ 价钱,count(TS_CP.TS_ID) 在册数量,可借数量
	from TS
	join TS_CP on TS.TS_ID=TS_CP.TS_ID
	join v_tsxx on TS.TS_ID=v_tsxx.TS_ID
	join TSLB on TS.TSLB_ID=TSLB.TSLB_ID
	where TS.Press=@id
	group by TS_CP.TS_ID,TS.TS_MC,TSLB.TSLB_MC,TS.TS_Code,TS.Author,TS.Press,TS.JQ,v_tsxx.可借数量
GO
