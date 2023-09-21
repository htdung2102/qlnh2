drop table OrderDetails

CREATE TABLE [dbo].[OrderDetails] (
    [DetailID]  INT          IDENTITY (1, 1) NOT NULL,
    [orderID]   INT  NULL, 
    [productID] INT NULL,
    [quantity]  INT          NULL,
    PRIMARY KEY CLUSTERED ([DetailID] ASC)
);



CREATE TABLE [dbo].[tblorder] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [TableName]     VARCHAR (20)  NULL,
    [OrderDate]     DATE          NULL,
    [OrderTime]     VARCHAR (10)  NULL,
    [payStatus]     NVARCHAR (20) NULL,
    [total]         FLOAT (53)    NULL,
    [CustomerID]    INT  NULL,
    [NoCustomer]    INT           NULL,
    [PaymethodID]   INT           NULL,
    [DiscountTotal] DECIMAL (18)  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
SELECT * FROM TableList 
UPDATE  TableList set TableStatus = NULL WHERE TableName = '103' 

select * from tblorder TB inner join OrderDetails OD ON TB.ID = OD.orderID 
select * from OrderDetails

DROP TABLE IF EXISTS #BANGTAM 
--INTO #BANGTAM 
select  tb.OrderDate, tb.OrderTime, tb.TableName,c.CustomerName, c.Phone, p.Name, od.quantity, p.Price, tb.DiscountTotal

                    from  OrderDetails od  LEFT OUTER JOIN tblorder tb  on tb.ID = od.orderID 
                    LEFT OUTER JOIN Product p on od.productID = p.ID
                    LEFT OUTER JOIN Customer c on c.ID =  tb.CustomerID where tb.TableName = 108 and tb.payStatus = 'Pending'
 SELECT * FROM   #BANGTAM        

group by tb.OrderDate, tb.OrderTime, tb.DiscountTotal, tb.TableName,c.CustomerName, c.Phone, p.Name, p.Price, od.quantity
   order by  tb.OrderDate, tb.OrderTime, tb.DiscountTotal, tb.TableName,c.CustomerName, c.Phone, p.Name, p.Price, od.quantity

delete from tblorder
delete from OrderDetails  

select * from OrderDetails where orderID = 4                
                   

             select  tb.OrderDate, tb.OrderTime,tb.TableName, c.CustomerName, c.Phone , p.Name, od.quantity , p.Price , tb.DiscountTotal, tb.total, (p.Price * od.quantity) as Amount,
             (tb.total - tb.DiscountTotal) as paytotal, tb.NoCustomer, st.StaffName                          
                    from  tblorder tb INNER JOIN OrderDetails od on tb.ID = od.orderID 
                    INNER JOIN Product p on od.productID = p.ID
                     LEFT OUTER JOIN Customer c on  c.ID =  tb.CustomerID 
                     INNER JOIN Staff st on st.ID = tb.StaffID 


SELECT * FROM ProductType 

ALTER TABLE Reservation
ADD  BookDate DATE, BookTime TIME 

ALTER TABLE ProductType  
ADD Department INT

SELECT TB.TableName, P.Name, DD.quantity
FROM
tblorder TB LEFT JOIN OrderDetails DD ON tb.ID = dd.orderID
            LEFT JOIN Product P ON DD.productID = P.ID
            LEFT JOIN ProductType PT ON P.TypeID = PT.ID
            WHERE PT.Department = 1 
select * from OrderDetails 
select * from Discount 
alter table OrderDetails 
add Printstatus INT 
DROP TABLE STAFF 
 
CREATE TABLE [dbo].[Staff] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [UserName]  VARCHAR(30),
    [Password] VARCHAR(10),
    [StaffName]  NVARCHAR (50) NOT NULL,
    [Phone]    VARCHAR (11)  NULL,
    [Role] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

SELECT  tb.OrderDate, SUM(subquery.quantity) as quantity, SUM(tb.total) AS Total, SUM(tb.DiscountTotal) as DiscountTotal, SUM(tb.total - tb.DiscountTotal) as Nettotal 
FROM tblorder tb
LEFT JOIN (
    SELECT orderID, SUM(quantity) as quantity
    FROM OrderDetails
    GROUP BY orderID
) as subquery on tb.ID = subquery.orderID 
where tb.OrderDate  BETWEEN DATEFROMPARTS(2023, 11,9) AND DATEFROMPARTS(2023, 11,12)
GROUP BY  tb.OrderDate

 ;WITH W AS(   SELECT  tb.OrderDate, PT.TypeName, P.Name, P.Price, OD.quantity
FROM tblorder tb
LEFT JOIN OrderDetails od on tb.ID = od.orderID 
LEFT JOIN Product p ON P.ID = OD.productID
LEFT JOIN ProductType PT ON PT.ID = P.TypeID)

SELECT W.OrderDate,W.TypeName, CASE WHEN  W.TypeName IS NULL THEN MAX(W.TypeName) ELSE MAX(W.Name) END  AS NAME
, SUM(W.Price), SUM(W.quantity)
FROM W 
GROUP BY GROUPING SETS((W.OrderDate,W.TypeName), (W.TypeName))
ORDER BY  W.OrderDate,(CASE WHEN  W.OrderDate IS NULL THEN 0 ELSE 1 END)

; with w as(SELECT  tb.OrderDate, PT.TypeName, P.Name, P.Price, SUM(OD.quantity) as TotalQuantity, SUM(P.Price * OD.quantity) as TotalAmount
FROM tblorder tb
LEFT JOIN OrderDetails od on tb.ID = od.orderID 
LEFT JOIN Product p ON P.ID = OD.productID
LEFT JOIN ProductType PT ON PT.ID = P.TypeID
GROUP BY tb.OrderDate, PT.TypeName, P.Name, P.Price
ORDER BY PT.TypeName, P.Name)

SELECT SUM(total - DiscountTotal) / SUM(NoCustomer) as AverageRevenuePerCustomer
FROM tblorder
select * FROM tblorder

SELECT  tb.OrderDate, SUM(tb.total - tb.DiscountTotal) as Nettotal 
FROM tblorder tb
where tb.OrderDate  BETWEEN DATEFROMPARTS(2023, 11,9) AND DATEFROMPARTS(2023, 11,12)
GROUP BY  tb.OrderDate
DROP TABLE tblorder 

CREATE TABLE [dbo].[tblorder] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [TableName]     VARCHAR (20)  NULL,
    [OrderDate]     DATE          NULL,
    [OrderTime]     VARCHAR (10)  NULL,
    [payStatus]     NVARCHAR (20) NULL,
    [total]         DECIMAL (18)   NULL,
    [CustomerID]    INT           NULL,
    [NoCustomer]    INT           NULL,
    [PaymethodID]   INT           NULL,
    [DiscountTotal] DECIMAL (18)  NULL,
    [StaffID]       INT           NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
delete from Customer

select  tb.OrderDate, tb.OrderTime,tb.TableName, c.CustomerName, c.Phone , p.Name, od.quantity , p.Price , tb.DiscountTotal, tb.total, (p.Price * od.quantity) as Amount,
             (tb.total - tb.DiscountTotal) as paytotal, tb.NoCustomer, st.StaffName                          
                    from  tblorder tb INNER JOIN OrderDetails od on tb.ID = od.orderID 
                    INNER JOIN Product p on od.productID = p.ID
                     LEFT OUTER JOIN Customer c on  c.ID =  tb.CustomerID 
                     INNER JOIN Staff st on st.ID = tb.StaffID  

select p.Name, sum(od.quantity) as quantity
from tblorder tb left join OrderDetails OD ON tb.ID = od.orderID
left join product p on od.productID = p.ID
left join ProductType pt on pt.ID = p.TypeID
where tb.OrderDate BETWEEN DATEFROMPARTS(2023, 11,9) AND DATEFROMPARTS(2023, 11,12) and pt.Department = 1
group by p.Name

create table department 
(ID INT PRIMARY KEY IDENTITY ,
Name NVARCHAR(30)
)
select * from department 
INSERT INTO department values ('Bar')

select * from DiscountType  

alter table discount 
add Point INT 

SELECT c.CustomerName, c.Scores FROM
tblorder tb inner join Customer c on tb.CustomerID = c.ID 
where tb.TableName = '108' and tb.payStatus = 'Pending'

Select ID, TableTName from Reservation where BookDate = datefromparts(2023,11,18) and Shift =1
select * from Reservation
Select * from TableList 
UPDATE TableList SET TableStatus = NULL WHERE TableName IN (SELECT TableTName FROM Reservation WHERE ID = 14)
alter table TableList 
drop COLUMN CustomerID 

alter table tblorder 
add DiscountID INT 

select  tb.OrderDate, tb.OrderTime, tb.TableName, c.CustomerName, c.Phone , p.Name , p.Price , od.quantity, 
                CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE D.DiscountValue
                END as DiscountValue,
                tb.total, (p.Price * od.quantity) as Amount,
                (tb.total - 
                    CASE
                        WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                        ELSE D.DiscountValue
                    END) as paytotal, 
                tb.NoCustomer, st.StaffName                          
                from  tblorder tb 
                INNER JOIN OrderDetails od on tb.ID = od.orderID 
                INNER JOIN Product p on od.productID = p.ID
                LEFT OUTER JOIN Customer c on  c.ID =  tb.CustomerID 
                inner join Discount D on tb.DiscountID = D.ID 
                INNER JOIN Staff st on st.ID = tb.StaffID  
                where  tb.payStatus = 'Pending'

                select ID, DiscountValue, TypeID, Point from Discount
delete from tblorder where TableName = 106 
select * from Reservation 

alter table Reservation
add TableID INT 

select NoCustomer from tblorder O INNER JOIN  TableList T ON T.ID = O.TableID

Select ID, TableTName from Reservation where  BookDate = CAST(18/11/2023 AS DATE)  and Shift = 1

SELECT  MONTH(tb.OrderDate) as Month,  COUNT(tb.ID) as OrderCount, SUM(tb.total) AS Total, 
            SUM(
                CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE D.DiscountValue
                END
            ) as DiscountValue, 
            SUM(tb.total - 
                CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE D.DiscountValue
                END
            ) as Nettotal 
            FROM tblorder tb
            LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
            WHERE YEAR(tb.OrderDate) = 2023 and MONTH(tb.OrderDate) = 11 and tb.payStatus = 'Paid'
            GROUP BY  MONTH(tb.OrderDate), YEAR(tb.OrderDate)
select sum(NoCustomer) from tblorder where OrderDate = '2023-11-17'

SELECT TOP 5 P.Name, SUM(OD.quantity * P.Price) as TotalRevenue
    FROM tblorder O
    INNER JOIN OrderDetails OD ON O.ID = OD.orderID
    INNER JOIN Product P ON OD.ProductID = P.ID
    WHERE O.payStatus = 'Paid'  AND O.OrderDate BETWEEN @startdate AND @enddate
    GROUP BY P.Name
    ORDER BY TotalRevenue DESC

    SELECT TOP 5 P.Name, SUM(OD.quantity) as TotalQuantity, SUM(OD.quantity * P.Price) as TotalRevenue
        FROM tblorder O
        INNER JOIN OrderDetails OD ON O.ID = OD.orderID
        INNER JOIN Product P ON OD.ProductID = P.ID
        WHERE O.payStatus = 'Paid'  
        GROUP BY P.Name
        ORDER BY TotalRevenue DESC

         SELECT TOP 5 C.CustomerName, SUM(tb.total - 
        CASE
            WHEN ISNULL(D.DiscountValue, 0) < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
            ELSE ISNULL(D.DiscountValue, 0)
        END
    ) as TotalSpent
    FROM tblorder tb
    LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
    INNER JOIN Customer C on tb.CustomerID = C.ID
    WHERE  tb.payStatus = 'Paid'
    GROUP BY C.CustomerName
    ORDER BY TotalSpent DESC

select OrderDate, TableName, NoCustomer,tb.total,
                    CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE ISNULL(D.DiscountValue,0)
                    END as DiscountTotal
,(tb.total - 
                CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE ISNULL(D.DiscountValue,0)
                END
            ) as Nettotal 
from tblorder tb left join Discount d on tb.DiscountID = d.ID
inner join TableList tl on tl.ID = tb.TableID 
WHERE OrderDate = '2023-11-19'

select * FROM ProductType 


SELECT pt.TypeName,
    CASE 
        WHEN GROUPING_ID(pt.TypeName, p.Name) = 3 THEN N'Tổng cộng'
        WHEN GROUPING_ID(pt.TypeName, p.Name) = 2 THEN pt.TypeName
        ELSE p.Name
    END as Name, 
    SUM(od.quantity) as Quantity,
    SUM(od.quantity * p.Price) as Revenue
FROM 
    tblorder o
INNER JOIN 
    orderdetails od ON o.ID = od.orderID
INNER JOIN 
    Product p ON od.productID = p.ID
INNER JOIN 
    ProductType pt ON p.TypeID = pt.ID
    WHERE 
    o.OrderDate BETWEEN @StartDate AND @EndDate
GROUP BY 
    ROLLUP (pt.TypeName, p.Name)
ORDER BY 
    CASE 
        WHEN GROUPING_ID(pt.TypeName, p.Name) = 3 THEN 1 ELSE 0 END,
        pt.TypeName, 
    CASE 
        WHEN p.Name IS NULL THEN 0 ELSE 1 END,
    p.Name

    select TL.TableName, st.StaffName,p.Name, od.quantity from tblorder tb inner join OrderDetails od on tb.ID = od.orderID 
    inner join Product p on od.productID = p.ID
    INNER JOIN TableList tl on tb.TableID = tl.ID 
    INNER JOIN Staff st on tb.StaffID = st.ID 

    select * from OrderDetails
    select * FROM tblorder

    select * from Reservation 
    
    select sum(NoCustomer) from tblorder

    create table Invoice 
    (ID INT PRIMARY KEY IDENTITY,
    InvoiceID AS ('HD'+right('00000'+CONVERT([varchar],[ID]),(5))),
    OrderID INT,
    CustomerName NVARCHAR(50),
    CompanyName NVARCHAR(128),
    TaxCode INT,
    Address NVARCHAR(128))

    SELECT I.InvoiceDate ,I.InvoiceID, I.CustomerName, I.CompanyName, I.TaxCode, I.Address,
    (tb.total - 
    CASE WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
    ELSE ISNULL(D.DiscountValue,0) END) as Total                   
    FROM Invoice I INNER JOIN tblorder tb on I. OrderID = tb.ID                   
                    LEFT JOIN Discount d on d.ID =  tb.DiscountID 
                    
select * FROM Invoice

ALTER TABLE Invoice 
add InvoiceDate DATE 

select * from tblorder
DELETE FROM tblorder where ID = 49 
select * from OrderDetails 
delete from OrderDetails where orderID = 49 
select * from Customer
SELECT  SUM(tb.total - 
                    CASE
                        WHEN D.DiscountValue < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                        ELSE ISNULL(D.DiscountValue, 0)
                    END
                ) as Nettotal 
                FROM tblorder tb
                LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
                WHERE tb.OrderDate = CAST(GETDATE() AS DATE) and tb.payStatus = 'Paid'
                GROUP BY  tb.OrderDate

                select ID, TableName, TableStatus, TypeName from TableList tl inner join TableType tt on tl.TypeID = tt.TypeID where TT.TypeID = 1 

                SELECT pt.ID, pt.TypeName, dp.Name FROM  department dp inner join ProductType pt on dp.ID = pt.Department
                Select * from ProductType

 SELECT  MONTH(tb.OrderDate) as Month, YEAR(tb.OrderDate) as Year, COUNT(tb.ID) as OrderCount, SUM(tb.total) AS Total, 
        SUM(
            CASE
                WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                ELSE D.DiscountValue
            END
        ) as DiscountValue, 
        SUM(tb.total - 
            CASE
                WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                ELSE D.DiscountValue
            END
        ) as Nettotal 
        FROM tblorder tb
        LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
        WHERE tb.payStatus = 'Paid'
        GROUP BY  MONTH(tb.OrderDate), YEAR(tb.OrderDate)