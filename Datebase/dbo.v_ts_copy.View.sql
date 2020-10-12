USE [BookStoreDB]
GO
/****** Object:  View [dbo].[v_ts_copy]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* *************************************************************
--视图：列出副本的信息
--功能：连接副本表和图书表，返回副本的主键、书名、图书条码和副本状态
*************************************************************** */

create View [dbo].[v_ts_copy]
as
select TSCP_ID,TS_MC,TS_Code,TS_Status
    from TS_CP
	   join TS on TS_CP.TS_ID=TS.TS_ID;
GO
