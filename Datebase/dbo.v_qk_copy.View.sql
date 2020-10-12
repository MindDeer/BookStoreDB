USE [BookStoreDB]
GO
/****** Object:  View [dbo].[v_qk_copy]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* *************************************************************
--视图：列出期刊副本的信息
--功能：连接副本表和期刊表，返回副本的主键、书名、期刊条码和副本状态
*************************************************************** */

Create View [dbo].[v_qk_copy]
as
select QKCP_ID,QK_MC,QK_Code,QK_Status
    from QK_CP
	   join QK on QK_CP.QK_ID=QK.QK_ID;
GO
