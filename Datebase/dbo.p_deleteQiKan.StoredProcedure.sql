USE [BookStoreDB]
GO
/****** Object:  StoredProcedure [dbo].[p_deleteQiKan]    Script Date: 2020/10/12 16:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_deleteQiKan](@qkId int,@qkmc char(30),@type char(20),@code char(20),@author char(20),@press char(30),@frequency char(20),@grade char(20),@money decimal(6,2),@cbdate date)
as
delete QK
	where QK_ID=@qkId;

GO
