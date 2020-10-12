USE [BookStoreDB]
GO
/****** Object:  View [dbo].[v_qkxx]    Script Date: 2020/10/12 16:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[v_qkxx]
as
SELECT DISTINCT
        MainTable.QK_ID,
        ISNULL(SubTable.可借数量, 0) AS 可借数量
FROM    QK_CP AS MainTable
LEFT JOIN (
           SELECT   QK_ID,count(QK_ID) as 可借数量
           FROM     QK_CP
           WHERE    QK_Status=1
           GROUP BY QK_ID
          ) AS SubTable ON MainTable.QK_ID = SubTable.QK_ID; 
GO
