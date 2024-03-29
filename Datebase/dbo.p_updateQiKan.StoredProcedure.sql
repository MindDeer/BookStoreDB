USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_updateQiKan]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_updateQiKan](@qkId int,@qkmc char(30),@type char(20),@code char(20),@author char(20),@press char(30),@frequency char(20),@grade char(20),@money decimal(6,2),@cbdate date)
as
update QK
	set QK_MC=@qkmc,QKLB_ID=@type,QK_Code=@code,Author=@author,
		Press=@press,Frequency=@frequency,Grade=@grade,JQ=@money,CB_DATE=@cbdate
	where QK_ID=@qkId
--delete QK
--	where QK_ID=@qkId;
--insert into QK(QK_ID,QK_MC,QKLB_ID,QK_Code,Author,Press,Frequency,Grade,JQ,CB_DATE,DJ_DATE)
--	values(@qkId,@qkmc,@type,@code,@author,@press,@frequency,@grade,@money,@cbdate,getdate())
GO
