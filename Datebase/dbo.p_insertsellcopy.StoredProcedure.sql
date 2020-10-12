USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_insertsellcopy]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[p_insertsellcopy](@copyid char(20))
as
begin
insert into v_showsellcopy
    select TSCP_ID,TS_MC,TS_Code,Author,Press,JQ    
	from TS join TS_CP on TS.TS_ID=TS_CP.TS_ID
	where TSCP_ID=@copyid
end
GO
