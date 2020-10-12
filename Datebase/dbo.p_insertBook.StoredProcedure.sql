USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertBook]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_insertBook](@tsId int,@tsmc char(30),@type char(20),@code char(20),@author char(20),@press char(30),@money decimal(6,2),@cbdate date)
as
insert into TS(TS_ID,TS_MC,TSLB_ID,TS_Code,Author,Press,JQ,CB_DATE,DJ_DATE)
	values(@tsId,@tsmc,@type,@code,@author,@press,@money,@cbdate,getdate())


	--insert into TS(TS_ID,TS_MC,TSLB_ID,TS_Code,Author,Press,JQ,CB_DATE,DJ_DATE)
	--values(44,'我喜欢生命本来的样子','TS001','ISBN952700001','周国平','作家出版社','45.00','2019/4/5',getdate())
GO
