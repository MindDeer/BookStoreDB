USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updateBook]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_updateBook](@tsId int,@tsmc char(30),@type char(20),@code char(20),@author char(20),@press char(30),@money decimal(6,2),@cbdate date)
as
update TS
	set TS_MC=@tsmc,TSLB_ID=@type,
		TS_Code=@code,Author=@author,Press=@press,
		JQ=@money,CB_DATE=@cbdate,DJ_DATE=getdate()
		where TS_ID=@tsId
--delete from TS
--	where TS_ID=@tsId;
--insert into TS(TS_ID,TS_MC,TSLB_ID,TS_Code,Author,Press,JQ,CB_DATE,DJ_DATE)
--	values(@tsId,@tsmc,@type,@code,@author,@press,@money,@cbdate,getdate())


	--insert into TS(TS_ID,TS_MC,TSLB_ID,TS_Code,Author,Press,JQ,CB_DATE,DJ_DATE)
	--values(44,'我喜欢生命本来的样子','TS001','ISBN952700001','周国平','作家出版社','45.00','2019/4/5',getdate())
GO
