USE [BookStoreDB]
GO
/****** Object:  View [dbo].[v_tsxx]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[v_tsxx]
as
SELECT DISTINCT
        MainTable.TS_ID,
        ISNULL(SubTable.可借数量, 0) AS 可借数量
FROM    TS_CP AS MainTable
LEFT JOIN (
           SELECT   TS_ID,count(TS_ID) as 可借数量
           FROM     TS_CP
           WHERE    TS_Status=1
           GROUP BY TS_ID
          ) AS SubTable ON MainTable.TS_ID = SubTable.TS_ID; 
GO
